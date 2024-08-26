using API.DTOs;
using Core.Entities;
using System.Net;

namespace API.Extensions;

public static class AddressMappingExtensions
{
    public static AddressDto? ToDto(this Address? address)
    {
        if (address == null) return null;

        return new AddressDto
        {
            HouseNumber = address.HouseNumber,
            Alley = address.Alley,
            Street = address.Street,
            Ward = address.Ward,
            District = address.District,
            City = address.City,
        };
    }

    public static Address ToEntity(this AddressDto addressDto)
    {
        if (addressDto == null) throw new ArgumentNullException(nameof(addressDto));

        return new Address
        {
            HouseNumber = addressDto.HouseNumber,
            Alley = addressDto.Alley,
            Street = addressDto.Street,
            Ward = addressDto.Ward,
            District = addressDto.District,
            City = addressDto.City,
        };
    }

    public static void UpdateFromDto(this Address address, AddressDto addressDto)
    {
        if (addressDto == null) throw new ArgumentNullException(nameof(addressDto));
        if (address == null) throw new ArgumentNullException(nameof(address));

        address.HouseNumber = addressDto.HouseNumber;
        address.Alley = addressDto.Alley;
        address.Street = addressDto.Street;
        address.Ward = addressDto.Ward;
        address.District = addressDto.District;
        address.City = addressDto.City;
    }
}