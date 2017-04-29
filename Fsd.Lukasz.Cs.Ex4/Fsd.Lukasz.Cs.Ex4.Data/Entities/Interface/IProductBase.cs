using System;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public interface IProductBase
    {
        string Model { get; set; }

        decimal Price { get; set; }

        string Producer { get; set; }

        DateTime ProductionDate { get; set; }

        ProductType Type { get; set; }
    }
}