using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Shared.Dtos;
public class PhoneDto
{
    public CustomerPhoneType? Type { get; set; }
    public string? Number { get; set; }
    public string? Description { get; set; }
}
