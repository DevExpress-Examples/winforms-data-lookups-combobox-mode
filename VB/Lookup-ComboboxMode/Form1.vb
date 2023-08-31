Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace Lookup_ComboboxMode

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            initLookupEdit()
            initGridLookupEdit()
        End Sub

        Private Sub initLookupEdit()
            AddHandler lookUpEdit1.EditValueChanged, AddressOf LookUpEdit1_EditValueChanged
            lookUpEdit1.Properties.NullText = "(select or type value)"
            Dim colors As String() = New String() {"Yellow", "Red", "Green", "Black", "White"}
            lookUpEdit1.Properties.DataSource = colors
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            lookUpEdit1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.Default 'Default is equivalent to True for LookupEdit control
        End Sub

        Private Sub initGridLookupEdit()
            AddHandler gridLookUpEdit1.EditValueChanged, AddressOf LookUpEdit1_EditValueChanged
            gridLookUpEdit1.Properties.NullText = "(select or type value)"
            Dim products As List(Of Product) = New List(Of Product) From {New Product() With {.ProductName = "Chang"}, New Product() With {.ProductName = "Ipoh Coffee"}, New Product() With {.ProductName = "Ravioli Angelo"}, New Product() With {.ProductName = "Filo Mix"}, New Product() With {.ProductName = "Tunnbröd"}, New Product() With {.ProductName = "Konbu"}, New Product() With {.ProductName = "Boston Crab Meat"}}
            gridLookUpEdit1.Properties.DataSource = products
            gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            gridLookUpEdit1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True
            gridLookUpEdit1.Properties.ValueMember = "ProductName"
            gridLookUpEdit1.Properties.DisplayMember = gridLookUpEdit1.Properties.ValueMember
        End Sub

        Private labelDictionaryCore As Dictionary(Of LookUpEditBase, LabelControl)

        Private ReadOnly Property labelDictionary As Dictionary(Of LookUpEditBase, LabelControl)
            Get
                If labelDictionaryCore Is Nothing Then
                    labelDictionaryCore = New Dictionary(Of LookUpEditBase, LabelControl)()
                    labelDictionaryCore.Add(lookUpEdit1, labelControl1)
                    labelDictionaryCore.Add(gridLookUpEdit1, labelControl2)
                End If

                Return labelDictionaryCore
            End Get
        End Property

        Private Sub LookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            'Display lookup editor's current value.
            Dim lookupEditor As LookUpEditBase = TryCast(sender, LookUpEditBase)
            If lookupEditor Is Nothing Then Return
            Dim label As LabelControl = labelDictionary(lookupEditor)
            If label Is Nothing Then Return
            If lookupEditor.EditValue Is Nothing Then
                label.Text = "Current EditValue: null"
            Else
                label.Text = "Current EditValue: " & lookupEditor.EditValue.ToString()
            End If
        End Sub

        Private Sub lookUpEdit1_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs)
        End Sub
    End Class

    Public Class Product

        Public Property ProductName As String
    End Class
End Namespace
