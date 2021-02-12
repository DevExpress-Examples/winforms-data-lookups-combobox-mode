<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Lookup-ComboboxMode/Form1.cs) (VB: [Form1.vb](./VB/Lookup-ComboboxMode/Form1.vb))
* [Program.cs](./CS/Lookup-ComboboxMode/Program.cs) (VB: [Program.vb](./VB/Lookup-ComboboxMode/Program.vb))
<!-- default file list end -->
# Lookup Editors - Combobox Mode


<p>This example shows the use of LookupEdit and GridLookupEdit controls in combobox mode, in which the editors accept any text in the edit box. An end-user can select an existing value from a lookup data source or type any string. The text entered is saved in the editor's edit value when the editor loses focus.<br>Lookup data sources for the LookupEdit and GridLookupEdit controls are an array of strings and a list of business objects, respectively.<br>Combobox mode is enabled when the following conditions are met

* the AcceptEditorTextAsNewValue property enables entering custom text in the edit box.
* the ValueMember and DisplayMember properties are set to an empty string (see the LookupEdit control initialization), or to the same field in the lookup data source (see the GridLookupEdit control initialization).
* the TextEditStyle property is set to Standard to enable text editing.</p>

<b>See also:</b>

[DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)

<br/>


