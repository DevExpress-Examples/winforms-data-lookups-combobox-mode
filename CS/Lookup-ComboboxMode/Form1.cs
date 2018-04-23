using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lookup_ComboboxMode {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            initLookupEdit();
            initGridLookupEdit();
        }


        void initLookupEdit() {
            lookUpEdit1.EditValueChanged += LookUpEdit1_EditValueChanged; ;
            lookUpEdit1.Properties.NullText = "(select or type value)";

            string[] colors = new string[] {
                "Yellow", "Red", "Green", "Black", "White"
            };

            lookUpEdit1.Properties.DataSource = colors;
            lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEdit1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.Default; //Default is equivalent to True for LookupEdit control
        }





        void initGridLookupEdit() {
            gridLookUpEdit1.EditValueChanged += LookUpEdit1_EditValueChanged;
            gridLookUpEdit1.Properties.NullText = "(select or type value)";

            List<Product> products = new List<Product> {
                new Product(){ ProductName="Chang" },
                new Product(){ ProductName="Ipoh Coffee" },
                new Product(){ ProductName="Ravioli Angelo" },
                new Product(){ ProductName="Filo Mix" },
                new Product(){ ProductName="Tunnbröd" },
                new Product(){ ProductName="Konbu" },
                new Product(){ ProductName="Boston Crab Meat" }
            };

            gridLookUpEdit1.Properties.DataSource = products;
            gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            gridLookUpEdit1.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            gridLookUpEdit1.Properties.ValueMember = "ProductName";
            gridLookUpEdit1.Properties.DisplayMember = gridLookUpEdit1.Properties.ValueMember;
            gridLookUpEdit1.ProcessNewValue += GridLookUpEdit1_ProcessNewValue;
            
        }

        

        Dictionary<LookUpEditBase, LabelControl> labelDictionaryCore;
        Dictionary<LookUpEditBase, LabelControl> labelDictionary {
            get {
                if (labelDictionaryCore == null) {
                    labelDictionaryCore = new Dictionary<LookUpEditBase, LabelControl>();
                    labelDictionaryCore.Add(lookUpEdit1, labelControl1);
                    labelDictionaryCore.Add(gridLookUpEdit1, labelControl2);
                }
                return labelDictionaryCore;
            }
        }

        private void LookUpEdit1_EditValueChanged(object sender, EventArgs e) {
            //Display lookup editor's current value.
            LookUpEditBase lookupEditor = sender as LookUpEditBase;
            if (lookupEditor == null) return;
            LabelControl label = labelDictionary[lookupEditor];
            if (label == null) return;
            if (lookupEditor.EditValue == null)
                label.Text = "Current EditValue: null";
            else
                label.Text = "Current EditValue: " + lookupEditor.EditValue.ToString();
        }

        private void GridLookUpEdit1_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e) {
            //Add new values to GridLookUpEdit control's DataSource.
            GridLookUpEdit gridLookup = sender as GridLookUpEdit;
            if (e.DisplayValue == null) return;
            string newValue = e.DisplayValue.ToString();
            if (newValue == String.Empty) return;
            if (MessageBox.Show(this, "Add '" + newValue + "' to list?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                List<Product> ds = gridLookup.Properties.DataSource as List<Product>;
                ds.Add(new Product { ProductName = newValue });
                e.Handled = true;
            }
        }
    }

    public class Product {
        public string ProductName { get; set; }
    }


}
