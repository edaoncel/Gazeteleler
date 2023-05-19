using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gazeteler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (clgazeteler.SelectedItems.Count == 0)
                MessageBox.Show("gazete secilmedi");
            else 
            { 
                lblokunanalar.Items.Clear();
                for(int i=0; i<clgazeteler.CheckedItems.Count;++i)
                {
                    lblokunanalar.Items.Add(clgazeteler.CheckedItems[i].ToString());
                }
            }
        }
    }
}
