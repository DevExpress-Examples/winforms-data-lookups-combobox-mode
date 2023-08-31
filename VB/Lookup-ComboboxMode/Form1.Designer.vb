Namespace Lookup_ComboboxMode

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.lblLookupEdit = New DevExpress.XtraEditors.LabelControl()
            Me.lblGridLookupEdit = New DevExpress.XtraEditors.LabelControl()
            CType((Me.lookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lookUpEdit1
            ' 
            Me.lookUpEdit1.Location = New System.Drawing.Point(14, 73)
            Me.lookUpEdit1.Name = "lookUpEdit1"
            Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.lookUpEdit1.Size = New System.Drawing.Size(187, 20)
            Me.lookUpEdit1.TabIndex = 0
            AddHandler Me.lookUpEdit1.ProcessNewValue, New DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(AddressOf Me.lookUpEdit1_ProcessNewValue)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(14, 54)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(87, 13)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "Current EditValue "
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(314, 54)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(84, 13)
            Me.labelControl2.TabIndex = 2
            Me.labelControl2.Text = "Current EditValue"
            ' 
            ' gridLookUpEdit1
            ' 
            Me.gridLookUpEdit1.Location = New System.Drawing.Point(314, 73)
            Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
            Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.gridLookUpEdit1.Properties.View = Me.gridLookUpEdit1View
            Me.gridLookUpEdit1.Size = New System.Drawing.Size(187, 20)
            Me.gridLookUpEdit1.TabIndex = 3
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.[Default]
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            ' 
            ' lblLookupEdit
            ' 
            Me.lblLookupEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lblLookupEdit.Location = New System.Drawing.Point(14, 13)
            Me.lblLookupEdit.Name = "lblLookupEdit"
            Me.lblLookupEdit.Size = New System.Drawing.Size(164, 26)
            Me.lblLookupEdit.TabIndex = 4
            Me.lblLookupEdit.Text = "LookupEdit " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "(lookup data source is array)"
            ' 
            ' lblGridLookupEdit
            ' 
            Me.lblGridLookupEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lblGridLookupEdit.Location = New System.Drawing.Point(314, 12)
            Me.lblGridLookupEdit.Name = "lblGridLookupEdit"
            Me.lblGridLookupEdit.Size = New System.Drawing.Size(261, 26)
            Me.lblGridLookupEdit.TabIndex = 4
            Me.lblGridLookupEdit.Text = "GridLookupEdit " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "(lookup data source is list of business objects)"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(606, 320)
            Me.Controls.Add(Me.lblGridLookupEdit)
            Me.Controls.Add(Me.lblLookupEdit)
            Me.Controls.Add(Me.gridLookUpEdit1)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.lookUpEdit1)
            Me.Name = "Form1"
            Me.Text = "Lookup - Combobox Mode"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.lookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private gridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit

        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private lblLookupEdit As DevExpress.XtraEditors.LabelControl

        Private lblGridLookupEdit As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
