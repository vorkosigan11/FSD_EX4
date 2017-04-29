namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public interface IBrake : IProductBase
    {
        BrakeType BrakeType { get; set; }
    }
}