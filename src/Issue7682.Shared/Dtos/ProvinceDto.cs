using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Shared.Dtos;
public class ProvinceDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public virtual List<CityDto> Cities { get; set; } = new List<CityDto>();
}
