using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Shared.Dtos;
public class AddressDto
{
    public ProvinceDto Province { get; set; } = new();
    public CityDto City { get; set; } = new();
    public string? AddressRest { get; set; }
    public string? PostalCode { get; set; }
    public string? Title { get; set; }
}
