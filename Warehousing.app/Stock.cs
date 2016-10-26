using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehousing.model;
using Warehousing.bll;

namespace Warehousing
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            gvStock.OptionsView.ShowGroupPanel = false;
            //searchAll();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ("" != txtGoodId.Text)
            {
                bll.TStock bll=new Warehousing.bll.TStock();
                gcStock.DataSource = bll.GetStock(txtGoodId.Text).Tables[0];
                
            }
        }

        private void txtGoodId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (char)8 != e.KeyChar)
            {
                e.Handled = true;
            }
        }

     

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            searchAll();
        }

        public void searchAll()
        {
            bll.TStock bll = new Warehousing.bll.TStock();
            gcStock.DataSource = bll.GetAllList().Tables[0];
        }
        
    }
}
