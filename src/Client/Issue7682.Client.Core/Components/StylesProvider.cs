using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Client.Core.Components;

public static class StylesProvider
{
    public static BitTextFieldClassStyles textFieldStyleClasses { get; } = new BitTextFieldClassStyles()
    {
        FieldGroup = "text-field",
        Input = "font-regular font-md text-input",
        Label = "font-regular font-sm text-lbl"
    };

    public static BitTextFieldClassStyles signInTextFieldStyles { get; } = new BitTextFieldClassStyles()
    {
        FieldGroup = "text-field",
        Input = "font-regular font-md",
        Label = "font-regular font-sm text-lbl",
        Focused = "text-focus"
    };

    public static BitNumberFieldClassStyles numberFieldClassStyles { get; } = new BitNumberFieldClassStyles()
    {
        InputWrapper= "text-field",
        Input = "font-regular font-md text-input",
        Label = "font-regular font-sm text-lbl",
        Focused = "text-focus"
    };

    public static BitDatePickerClassStyles datePickerClassStyles { get; } = new BitDatePickerClassStyles()
    {
        InputContainer = "text-input h-40",
        Input = "font-regular font-md ",
        Label = "font-regular font-sm text-lbl",
    };

    public static BitAccordionClassStyles accordionStyles { get; } = new BitAccordionClassStyles()
    {
        HeaderContent = "flex-grow: unset;",
        Header = "font-size: 18px; font-family: 'Dana'; font-weight: 500;",
        Title = "font-size: 18px; font-family: 'Dana'; font-weight: 500;"
    };

    public static BitAccordionClassStyles profileAccordionStyle { get; } = new BitAccordionClassStyles()
    {
        Root = "max-width:max-content; z-index:18;",
        HeaderContent = "flex-grow: unset;",
        Header = "font-md font-medium width-content",
        Title = "font-md font-medium width-content hide"
    };

    public static BitDropdownClassStyles dropdownClassStyles { get; } = new BitDropdownClassStyles
    {
        Container = "drop-down-container",
        Label = "font-regular padding-4"
    };

    public static BitButtonClassStyles blueButtonClassTryles { get; } = new BitButtonClassStyles()
    {
        Root = "btn-style btn-blue w-auto",
    };

    public static BitButtonClassStyles whiteButtonClassTryles { get; } = new BitButtonClassStyles()
    {
        Root = "btn-style btn-white w-auto",
    };

    public static BitMenuButtonClassStyles profileMenuButton { get; } = new BitMenuButtonClassStyles()
    {
        Text = "display-hidden-lg"
        //ItemIcon = "exit-icon"
    };
}
