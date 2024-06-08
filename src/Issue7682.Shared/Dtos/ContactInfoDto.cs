using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Shared.Dtos;
public class ContactInfoDto
{
    public Guid? Id { get; set; }
    public PhoneDto Phone { get; set; } = new();
    public AddressDto Address { get; set; } = new();
}
