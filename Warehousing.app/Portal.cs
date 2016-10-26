using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehousing
{
    public partial class Portal : Form
    {
        private Stock stockFra;
        private Storage storageFra;
        private Out outFra;
        //private ProductSetting productSettingFra;
        public Portal()
        {
            InitializeComponent();

            stockFra = new Stock();
            storageFra = new Storage();
            outFra = new Out();
            //productSettingFra = new ProductSetting();
            setFragmentStyle(stockFra);
            setFragmentStyle(storageFra);
            setFragmentStyle(outFra);
            //setFragmentStyle(productSettingFra);
            portalPanel.Controls.Add(stockFra);
            portalPanel.Controls.Add(storageFra);
            portalPanel.Controls.Add(outFra);
            //portalPanel.Controls.Add(productSettingFra);
        }

        private void storegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeFragment(storageFra);
        }

        private void productSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changeFragment(productSettingFra);
            new ProductSetting().Show();
        }
        private void changeFragment(Form pForm)
        {
            stockFra.Hide();
            storageFra.Hide();
            outFra.Hide();
            //productSettingFra.Hide();
            pForm.Show();
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeFragment(outFra);
        }
        private void setFragmentStyle(Form pFrom)
        {
            pFrom.FormBorderStyle = FormBorderStyle.None;
            pFrom.TopLevel = false;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockFra.searchAll();
            changeFragment(stockFra);
        }
    }
}
