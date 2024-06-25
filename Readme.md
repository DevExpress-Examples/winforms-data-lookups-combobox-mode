<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623190/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T378371)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Lookup Editors - Combobox mode

This example shows how to use [LookupEdit]() and [GridLookupEdit]() controls in combobox mode. In this mode, users can type in the text box and enter values that are not in the data source.

In this example, the `LookupEdit` is bound to an array of strings. The `GridLookupEdit` is bound to a list of business objects.

Do the following to enable the Combobox Mode:

* Set the `Properties.TextEditStyle` property to `TextEditStyles.Standard` to allow users to type in the text box.
* Set the `GridLookUpEdit` control's `ValueMember` and `DisplayMember` properties to the same data field (with string values). For the `LookUpEdit`, these proprties are not specified (set to an empty string).
  
  ```csharp
  gridLookUpEdit1.Properties.ValueMember = "ProductName";
  gridLookUpEdit1.Properties.DisplayMember = gridLookUpEdit1.Properties.ValueMember;
  ```
* Enable the `AcceptEditorTextAsNewValue` options property, which enables users to enter custom text in the edit box.
* Handle the `ProcessNewValue` event to parse entered values and add new records to the lookup’s data source.

Read the following help topic for more information: [ComboBox Mode - Enter New Values](https://docs.devexpress.com/WindowsForms/116019/controls-and-libraries/editors-and-simple-controls/lookup-editors/combobox-mode-allow-entering-new-values).


## Files to Review

* [Form1.cs](./CS/Lookup-ComboboxMode/Form1.cs) (VB: [Form1.vb](./VB/Lookup-ComboboxMode/Form1.vb))


## Documentation

* [ComboBox Mode - Enter New Values](https://docs.devexpress.com/WindowsForms/116019/controls-and-libraries/editors-and-simple-controls/lookup-editors/combobox-mode-allow-entering-new-values)
* [WinForms Lookup Editors](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)
* [Lookup Main Settings](https://docs.devexpress.com/WindowsForms/116029/controls-and-libraries/editors-and-simple-controls/lookup-editors/lookup-editors-and-main-settings)


## See Also

* [DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-data-lookups-combobox-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-data-lookups-combobox-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
