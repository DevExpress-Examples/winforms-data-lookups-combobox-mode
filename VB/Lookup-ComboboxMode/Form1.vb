Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Lookup_ComboboxMode
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            initLookupEdit()
            initGridLookupEdit()
        End Sub


        Private Sub initLookupEdit()
            AddHandler lookUpEdit1.EditValueChanged, AddressOf LookUpEdit1_EditValueChanged

            lookUpEdit1.Properties.NullText = "(select or type value)"

            Dim colors() As String = { "Yellow", "Red", "Green", "Black", "White" }

            lookUpEdit1.Properties.DataSource = colors
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            lookUpEdit1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.Default 'Default is equivalent to True for LookupEdit control
        End Sub





        Private Sub initGridLookupEdit()
            AddHandler gridLookUpEdit1.EditValueChanged, AddressOf LookUpEdit1_EditValueChanged
            gridLookUpEdit1.Properties.NullText = "(select or type value)"

            Dim products As New List(Of Product) From { _
                New Product() With {.ProductName="Chang"}, _
                New Product() With {.ProductName="Ipoh Coffee"}, _
                New Product() With {.ProductName="Ravioli Angelo"}, _
                New Product() With {.ProductName="Filo Mix"}, _
                New Product() With {.ProductName="Tunnbröd"}, _
                New Product() With {.ProductName="Konbu"}, _
                New Product() With {.ProductName="Boston Crab Meat"} _
            }

            gridLookUpEdit1.Properties.DataSource = products
            gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            gridLookUpEdit1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True
            gridLookUpEdit1.Properties.ValueMember = "ProductName"
            gridLookUpEdit1.Properties.DisplayMember = gridLookUpEdit1.Properties.ValueMember
            AddHandler gridLookUpEdit1.ProcessNewValue, AddressOf GridLookUpEdit1_ProcessNewValue

        End Sub



        Private labelDictionaryCore As Dictionary(Of LookUpEditBase, LabelControl)
        Private ReadOnly Property labelDictionary() As Dictionary(Of LookUpEditBase, LabelControl)
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
            If lookupEditor Is Nothing Then
                Return
            End If
            Dim label As LabelControl = labelDictionary(lookupEditor)
            If label Is Nothing Then
                Return
            End If
            If lookupEditor.EditValue Is Nothing Then
                label.Text = "Current EditValue: null"
            Else
                label.Text = "Current EditValue: " & lookupEditor.EditValue.ToString()
            End If
        End Sub

        Private Sub GridLookUpEdit1_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs)
            'Add new values to GridLookUpEdit control's DataSource.
            Dim gridLookup As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            If e.DisplayValue Is Nothing Then
                Return
            End If
            Dim newValue As String = e.DisplayValue.ToString()
            If newValue = String.Empty Then
                Return
            End If
            If MessageBox.Show(Me, "Add '" & newValue & "' to list?", "Confirm", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim ds As List(Of Product) = TryCast(gridLookup.Properties.DataSource, List(Of Product))
                ds.Add(New Product With {.ProductName = newValue})
                e.Handled = True
            End If
        End Sub
    End Class

    Public Class Product
        Public Property ProductName() As String
    End Class


End Namespace
