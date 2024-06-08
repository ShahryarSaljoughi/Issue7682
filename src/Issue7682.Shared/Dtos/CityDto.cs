using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Shared.Dtos;
public class CityDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public Guid? ProvinceId { get; set; }
}
