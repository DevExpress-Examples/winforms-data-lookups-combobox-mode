namespace Lookup_ComboboxMode {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblLookupEdit = new DevExpress.XtraEditors.LabelControl();
            this.lblGridLookupEdit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(14, 73);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(187, 20);
            this.lookUpEdit1.TabIndex = 0;
            this.lookUpEdit1.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.lookUpEdit1_ProcessNewValue);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Current EditValue ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(314, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Current EditValue";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(314, 73);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(187, 20);
            this.gridLookUpEdit1.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblLookupEdit
            // 
            this.lblLookupEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLookupEdit.Location = new System.Drawing.Point(14, 13);
            this.lblLookupEdit.Name = "lblLookupEdit";
            this.lblLookupEdit.Size = new System.Drawing.Size(164, 26);
            this.lblLookupEdit.TabIndex = 4;
            this.lblLookupEdit.Text = "LookupEdit \r\n(lookup data source is array)";
            // 
            // lblGridLookupEdit
            // 
            this.lblGridLookupEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblGridLookupEdit.Location = new System.Drawing.Point(314, 12);
            this.lblGridLookupEdit.Name = "lblGridLookupEdit";
            this.lblGridLookupEdit.Size = new System.Drawing.Size(261, 26);
            this.lblGridLookupEdit.TabIndex = 4;
            this.lblGridLookupEdit.Text = "GridLookupEdit \r\n(lookup data source is list of business objects)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 320);
            this.Controls.Add(this.lblGridLookupEdit);
            this.Controls.Add(this.lblLookupEdit);
            this.Controls.Add(this.gridLookUpEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpEdit1);
            this.Name = "Form1";
            this.Text = "Lookup - Combobox Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblLookupEdit;
        private DevExpress.XtraEditors.LabelControl lblGridLookupEdit;
    }
}

