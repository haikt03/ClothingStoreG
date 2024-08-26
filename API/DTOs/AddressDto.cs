using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class AddressDto
{
    [Required]
    public string HouseNumber { get; set; } = string.Empty;
    [Required]
    public string Alley { get; set; } = string.Empty;
    [Required]
    public string Street { get; set; } = string.Empty;
    [Required]
    public string Ward { get; set; } = string.Empty;
    [Required]
    public string District { get; set; } = string.Empty;
    [Required]
    public string City { get; set; } = string.Empty;
}