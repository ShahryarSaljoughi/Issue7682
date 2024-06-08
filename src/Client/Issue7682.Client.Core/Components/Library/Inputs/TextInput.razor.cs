using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Client.Core.Components.Library.Inputs;

public partial class TextInput: BitTextField
{
    protected override void OnInitialized()
    {
        AddCustomization();
        base.OnInitialized();
        
    }

    private void AddCustomization()
    {
        Classes ??= new BitTextFieldClassStyles();
        Classes.FieldGroup += "custom-field";
        Classes.Focused += "custom-focus";
    }
}
