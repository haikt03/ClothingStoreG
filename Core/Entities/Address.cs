namespace Core.Entities;

public class Address : BaseEntity
{
    public required string HouseNumber { get; set; }
    public required string Alley { get; set; }
    public required string Street { get; set; }
    public required string Ward { get; set; }
    public required string District { get; set; }
    public required string City { get; set; }
}