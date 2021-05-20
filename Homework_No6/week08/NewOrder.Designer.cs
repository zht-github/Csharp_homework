
namespace week08
{
    partial class NewOrder
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cusName = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addDetail = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.tb_goodPrice = new System.Windows.Forms.TextBox();
            this.tb_goodName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDetailBinding = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDetailBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加订单";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名称";
            // 
            // tb_cusName
            // 
            this.tb_cusName.Location = new System.Drawing.Point(109, 55);
            this.tb_cusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_cusName.Name = "tb_cusName";
            this.tb_cusName.Size = new System.Drawing.Size(159, 28);
            this.tb_cusName.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(393, 0);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(132, 41);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "id";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(336, 55);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(226, 28);
            this.tb_id.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "地址";
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(639, 55);
            this.tb_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(232, 28);
            this.tb_addr.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_addDetail);
            this.panel1.Controls.Add(this.tb_amount);
            this.panel1.Controls.Add(this.tb_goodPrice);
            this.panel1.Controls.Add(this.tb_goodName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_addr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_cusName);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 167);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_addDetail
            // 
            this.btn_addDetail.Location = new System.Drawing.Point(746, 116);
            this.btn_addDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addDetail.Name = "btn_addDetail";
            this.btn_addDetail.Size = new System.Drawing.Size(153, 34);
            this.btn_addDetail.TabIndex = 14;
            this.btn_addDetail.Text = "添加订单详细";
            this.btn_addDetail.UseVisualStyleBackColor = true;
            this.btn_addDetail.Click += new System.EventHandler(this.btn_addDetail_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(544, 120);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(133, 28);
            this.tb_amount.TabIndex = 13;
            // 
            // tb_goodPrice
            // 
            this.tb_goodPrice.Location = new System.Drawing.Point(324, 116);
            this.tb_goodPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_goodPrice.Name = "tb_goodPrice";
            this.tb_goodPrice.Size = new System.Drawing.Size(112, 28);
            this.tb_goodPrice.TabIndex = 12;
            // 
            // tb_goodName
            // 
            this.tb_goodName.Location = new System.Drawing.Point(82, 116);
            this.tb_goodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_goodName.Name = "tb_goodName";
            this.tb_goodName.Size = new System.Drawing.Size(150, 28);
            this.tb_goodName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "商品数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "商品单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "商品名";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 67);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.numOfGoodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addDetailBinding;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(939, 342);
            this.dataGridView1.TabIndex = 10;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // numOfGoodDataGridViewTextBoxColumn
            // 
            this.numOfGoodDataGridViewTextBoxColumn.DataPropertyName = "numOfGood";
            this.numOfGoodDataGridViewTextBoxColumn.HeaderText = "numOfGood";
            this.numOfGoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numOfGoodDataGridViewTextBoxColumn.Name = "numOfGoodDataGridViewTextBoxColumn";
            this.numOfGoodDataGridViewTextBoxColumn.Width = 125;
            // 
            // addDetailBinding
            // 
            this.addDetailBinding.DataSource = typeof(week08.OrderDetails);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDetailBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cusName;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource addDetailBinding;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_goodPrice;
        private System.Windows.Forms.TextBox tb_goodName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfGoodDataGridViewTextBoxColumn;
    }
}