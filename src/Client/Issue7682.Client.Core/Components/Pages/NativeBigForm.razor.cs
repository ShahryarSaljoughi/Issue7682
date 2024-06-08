using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Client.Core.Components.Pages;
public partial class NativeBigForm
{
    
    
    private CustomerDto CustomerDto { get; set; } = new();
    private List<ProvinceDto> Provinces { get; set; } = new();

    private ContactInfoDto newContactInfo = new ContactInfoDto()
    {
        Address = new AddressDto() { },
        Phone = new PhoneDto() { },
        Id = Guid.NewGuid()
    };

    public NativeBigForm()
    {

    }


    protected override async Task OnInitAsync()
    {
        Provinces = [new ProvinceDto{ Name = "تهران"}, new ProvinceDto{ Name = "زنجان"}];
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        return base.OnAfterRenderAsync(firstRender);
    }

    protected override bool ShouldRender()
    {
        return false;
    }

    async Task UpdateCitiesAsync()
    {
        cities = new List<BitDropdownItem<CityDto>>();
    }

    void AddContactInfo()
    {
        CustomerDto.ContactInfos.Add(newContactInfo);
        newContactInfo = new ContactInfoDto();
    }

    void ResetContactInfo()
    {
        newContactInfo = new ContactInfoDto();
    }

    async Task SaveCustomerAsync()
    {
        await Task.Delay(1000);
        CustomerDto = new CustomerDto();
        await OpenBasicSnackBar();
    }
}
