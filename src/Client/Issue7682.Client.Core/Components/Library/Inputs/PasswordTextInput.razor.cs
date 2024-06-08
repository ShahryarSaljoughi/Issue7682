using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Client.Core.Components.Library.Inputs;
public partial class PasswordTextInput
{
    [Parameter, EditorRequired]
    public string TextValue { get; set; }
    [Parameter, EditorRequired]
    public string TextLabel { get; set; }
    [Parameter, EditorRequired]
    public string TextPlaceholder { get; set; }
    [Parameter, EditorRequired]
    public BitTextFieldType TextType { get; set; }
    [Parameter, EditorRequired]
    public bool CanRevealPassword { get; set; }
    [Parameter, EditorRequired]
    public string AutoComplete { get; set; }
}
