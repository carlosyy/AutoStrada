using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStrada.ENT
{
    public class QueryParams
    {
        private const int _maxPageSize = 50;

        private int _page = 10;

        public int Page { get; set; } = 1;

        public int ProductsPerPage
        {
            get
            {
                return _page;
            }
            set
            {
                if (value > _maxPageSize) _page = _maxPageSize;
                else _page = value;
            }
        }
    }
}
