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
    public partial class Out : Form
    {
        public Out()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if ("" == txtGoodId.Text)
            {
                MessageBox.Show("请填写一料一号");
                return;
            }
            //if ("" == txtCode.Text)
            //{
            //    MessageBox.Show("请填写商品编码");
            //    return;
            //}
            //if ("" == txtName.Text)
            //{
            //    MessageBox.Show("请填写商品名称");
            //    return;
            //}
            //if ("" == txtNumber.Text)
            //{
            //    MessageBox.Show("请填写出库数量");
            //    return;
            //}
            //if ("" == txtPrice.Text)
            //{
            //    MessageBox.Show("请填写商品商品价格");
            //    return;
            //}
            //if ("" == txtSpec.Text)
            //{
            //    MessageBox.Show("请填写规格型号");
            //    return;
            //}
            //if ("" == txtUnit.Text)
            //{
            //    MessageBox.Show("请填写计量单位");
            //    return;
            //}
    
            //model.TStock mod = new model.TStock();
            bll.TStock bll = new bll.TStock();
            //mod.id = txtGoodId.Text;
            //mod.code = txtCode.Text;
            //mod.name = txtName.Text;
            //mod.number = int.Parse(txtNumber.Text);
            //mod.price = decimal.Parse(txtPrice.Text);
            //mod.spec = txtSpec.Text;
            //mod.unit = txtUnit.Text;
            bool isExists = bll.Exists(txtGoodId.Text);
            if (isExists)
            {
                if ("" == txtNumber.Text)
                {
                    MessageBox.Show("请填写出库数量");
                    return;
                }
                model.TStock mod = new model.TStock();
                mod.number = int.Parse(txtNumber.Text);
                model.TStock dataRow = bll.GetModel(txtGoodId.Text);
                    if (0<dataRow.number)
                    {
                        
                        if (mod.number > dataRow.number)
                        {
                            MessageBox.Show("该商品库存为" + dataRow.number + dataRow.unit + "，无法出库" + mod.number + mod.unit);
                        }
                        else
                        {
                            mod.id = dataRow.id;
                            mod.code = dataRow.code;
                            mod.name = dataRow.name;
                            mod.spec = dataRow.spec;
                            mod.unit = dataRow.unit;
                            mod.price = dataRow.price;
                            DialogResult dr = MessageBox.Show("确认出库 "+mod.number+mod.unit+"?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dr == DialogResult.OK)
                            {
                                mod.number = dataRow.number - mod.number;
                                if (bll.Update(mod))
                                {
                                    txtGoodId.Text = "";
                                    reset();
                                    MessageBox.Show("出库成功");
                                }
                                else
                                {
                                    MessageBox.Show("未知原因，出库失败");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该商品库存为零，无法完成出库操作");
                    }
                }
               
            
            else
            {
                MessageBox.Show("未在仓库中查找到该商品，无法完成出库操作");
            }


        }

       
        private void integerLimit(KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (char)8 != e.KeyChar)
            {
                e.Handled = true;
            }
        }




        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;
            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (txtPrice.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtPrice.Text, out oldf);
                    b2 = float.TryParse(txtPrice.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            integerLimit(e);
        }

        private void txtGoodId_KeyPress(object sender, KeyPressEventArgs e)
        {
            integerLimit(e);
        }

        private void txtGoodId_EditValueChanged(object sender, EventArgs e)
        {
            bll.TStock bll = new bll.TStock();
            model.TStock mod = bll.GetModel(txtGoodId.Text);
            if (null != mod)
            {
                txtCode.Text = mod.code;
                txtName.Text = mod.name;
                txtNumber.Text = mod.number + "";
                txtPrice.Text = mod.price + "";
                txtSpec.Text = mod.spec;
                txtUnit.Text = mod.unit;
            }
            else
            {
                reset();
            }
        }

        private void reset()
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtNumber.Text =  "";
            txtPrice.Text = "";
            txtSpec.Text = "";
            txtUnit.Text = "";
        }

        private void btnReType_Click(object sender, EventArgs e)
        {
            txtGoodId.Text = "";
            reset();
        }
    }
  
}
