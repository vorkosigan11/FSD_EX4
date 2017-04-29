using System;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public class Bike : ProductBase
    {
        #region Fields

        private string _NameOfFrontShock;

        #endregion Fields

        #region Constructors

        public Bike(string producer, string model, decimal price, DateTime productoinDate, ProductType type, int numbersOfGears, string nameOfFrontShock) : base(producer, model, price, productoinDate, type)
        {
            Type = ProductType.Bike;
            NumberOfGears = numbersOfGears;
            NameOfFronSHock = nameOfFrontShock;
        }

        #endregion Constructors

        #region Properties

        public bool? FrontShock { get; private set; }

        public string NameOfFronSHock
        {
            get { return _NameOfFrontShock; }
            set
            {
                _NameOfFrontShock = value;
                FrontShock = true;
            }
        }

        public int NumberOfGears { get; set; }

        #endregion Properties
    }
}