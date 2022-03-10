using AutoStrada.ENT;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoStrada.DAL
{
    public class PaginatedProduct
    {
        public PaginatedProduct(
            IEnumerable<Product> items, int count, int pageNumber, int ProductsPerPage)
        {
            PageInfo = new PageInfo
            {
                CurrentPage = pageNumber,
                ProductsPerPage = ProductsPerPage,
                TotalPages = (int)Math.Ceiling(count / (double)ProductsPerPage),
                TotalProducts = count
            };
            this.Products = items;
        }

        public PageInfo PageInfo { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public static PaginatedProduct ToPaginatedProduct(
            IQueryable<Product> Products, int pageNumber, int ProductsPerPage)
        {
            var count = Products.Count();
            var chunk = Products.Skip((pageNumber - 1) * ProductsPerPage).Take(ProductsPerPage);
            return new PaginatedProduct(chunk, count, pageNumber, ProductsPerPage);
        }

        public static PaginatedProduct ToPaginatedProduct(object p, int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

    public class PageInfo
    {
        public bool HasPreviousPage
        {
            get
            {
                return (CurrentPage > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (CurrentPage < TotalPages);
            }
        }

        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int ProductsPerPage { get; set; }
        public int TotalProducts { get; set; }
    }
}
