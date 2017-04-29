using System;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public class Brake : ProductBase, IBrake
    {
        #region Constructors

        public Brake(string producer, string model, decimal price, DateTime productoinDate, ProductType type, BrakeType brakeType) : base(producer, model, price, productoinDate, type)
        {
            type = ProductType.Brake;
            BrakeType = brakeType;
        }

        #endregion Constructors

        #region Properties

        public BrakeType BrakeType { get; set; }

        #endregion Properties
    }
}