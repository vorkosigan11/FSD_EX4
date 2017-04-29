namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public interface IBike : IProductBase
    {
        bool? FrontShock { get; }

        string NameOfFronSHock { get; set; }

        int NumberOfGears { get; set; }
    }
}