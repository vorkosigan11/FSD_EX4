using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using System;

namespace Fsd.Lukasz.Cs.Ex4.Models
{
    public class ProductModel
    {
        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Producer { get; set; }

        public DateTime ProductionDate { get; set; }

        public ProductType Type { get; set; }
    }
}