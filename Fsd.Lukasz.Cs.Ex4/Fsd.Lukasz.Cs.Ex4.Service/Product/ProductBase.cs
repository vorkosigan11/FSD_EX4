using System;

namespace Fsd.Lukasz.Cs.Ex4.Service.Product
{
    public abstract class ProductBase
    {
        #region Constructors

        public ProductBase(string producer, string model, decimal price, DateTime productoinDate, ProductType type)
        {
            Producer = producer;
            Model = model;
            Price = price;
            ProductionDate = productoinDate;
            Type = type;
        }

        #endregion Constructors

        #region Properties

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Producer { get; set; }

        public DateTime ProductionDate { get; set; }

        public ProductType Type { get; set; }

        #endregion Properties
    }
}