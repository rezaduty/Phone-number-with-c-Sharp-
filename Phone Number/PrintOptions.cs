using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace printdata
{
    public partial class PrintOptions : Form
    {
        public PrintOptions()
        {
            InitializeComponent();
        }

        public PrintOptions(List<string> availableFields)
        {
            InitializeComponent();
            foreach (string field in availableFields)
                chklst.Items.Add(field, true);
                
            
        }
        private void PrintOptions_Load(object sender, EventArgs e)
        {
            rdoallrow.Checked = true;
            checkBox1.Checked = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public List<string> GetSelectedColumns()
        {
            List<string> lst = new List<string>();
            foreach (object item in chklst.CheckedItems)
                lst.Add(item.ToString());
            return lst;
        }

        public string PrintTitle
        {
            get
            {
                return printtitle.Text;
            }
        }

        public bool PrintAllRows
        {
            get
            {
                return rdoallrow.Checked;
            }
           
        }

        public bool FitToPageWidth
        {
            get
            {
                return checkBox1.Checked;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
