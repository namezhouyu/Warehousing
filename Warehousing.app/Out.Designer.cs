namespace Warehousing
{
    partial class Out
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtGoodId = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnReType = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSpec = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(75, 51);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 22);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "一料一号：";
            // 
            // txtGoodId
            // 
            this.txtGoodId.Location = new System.Drawing.Point(171, 48);
            this.txtGoodId.Name = "txtGoodId";
            this.txtGoodId.Size = new System.Drawing.Size(271, 28);
            this.txtGoodId.TabIndex = 28;
            this.txtGoodId.EditValueChanged += new System.EventHandler(this.txtGoodId_EditValueChanged);
            this.txtGoodId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodId_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 38);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "确认出库";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReType
            // 
            this.btnReType.Location = new System.Drawing.Point(75, 449);
            this.btnReType.Name = "btnReType";
            this.btnReType.Size = new System.Drawing.Size(169, 38);
            this.btnReType.TabIndex = 36;
            this.btnReType.Text = "重新填写";
            this.btnReType.Click += new System.EventHandler(this.btnReType_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(75, 311);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 22);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "商品数量：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(171, 308);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(271, 28);
            this.txtNumber.TabIndex = 32;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(451, 378);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(10, 22);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "¥";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(266, 376);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 22);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "单价：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(326, 373);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 28);
            this.txtPrice.TabIndex = 34;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(75, 376);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 22);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "商品单位：";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(171, 373);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(86, 28);
            this.txtUnit.TabIndex = 33;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(75, 246);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 22);
            this.labelControl4.TabIndex = 39;
            this.labelControl4.Text = "规格型号：";
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(171, 243);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(271, 28);
            this.txtSpec.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(75, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 22);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "商品名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 28);
            this.txtName.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(75, 116);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 22);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "商品编码：";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(171, 113);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(271, 28);
            this.txtCode.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 50F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Location = new System.Drawing.Point(681, 190);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(400, 121);
            this.labelControl9.TabIndex = 45;
            this.labelControl9.Text = "简易出库";
            // 
            // Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 801);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtGoodId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReType);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCode);
            this.Name = "Out";
            this.Text = "Out";
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtGoodId;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnReType;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSpec;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;

    }
}