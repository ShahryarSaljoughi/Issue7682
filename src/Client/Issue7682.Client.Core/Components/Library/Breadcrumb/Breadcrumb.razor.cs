using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Client.Core.Components.Library.Breadcrumb;
public partial class Breadcrumb: AppComponentBase
{
    [Parameter, EditorRequired] public List<(string text, string href)> Items { get; set; } = default!;

    private List<BitBreadcrumbItem> BreadcrumbItems { get; set; } = default!;

    protected override Task OnInitAsync()
    {
        var queryable = from item in Items
                        select new BitBreadcrumbItem 
                        { 
                            Text = item.text, 
                            Href = item.href,
                            Class = "item",
                            
                        };
        
        BreadcrumbItems = queryable.ToList();
        return Task.CompletedTask;
    }
}
