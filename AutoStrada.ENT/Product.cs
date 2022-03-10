using System;

namespace AutoStrada.ENT
{
    public class Product
    {
        public int CodeProduct { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public DateTime DateFabrication { get; set; }
        public DateTime DateValidity { get; set; }
        public int CodeSupplier { get; set; }

    }
}
