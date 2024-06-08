using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Client.Core.Components.Library;
public partial class BackBtn: AppComponentBase
{
    [Parameter, EditorRequired] public string Href {get; set;} = default!;

    void NavigateBack() 
    {
        NavigationManager.NavigateTo(Href);
    }
}
