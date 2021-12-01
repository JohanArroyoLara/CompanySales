
namespace IU.Billing
{
    partial class frmAddBilling
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.orderID = new System.Windows.Forms.ListBox();
            this.orderDate = new System.Windows.Forms.ListBox();
            this.orderPrice = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.lblID.Location = new System.Drawing.Point(12, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(224, 27);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "Cédula del cliente:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(281, 52);
            this.txtClientID.MaxLength = 9;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(239, 20);
            this.txtClientID.TabIndex = 28;
            this.txtClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientID_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.lblCode.Location = new System.Drawing.Point(127, 142);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(109, 27);
            this.lblCode.TabIndex = 31;
            this.lblCode.Text = "Pedidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(141, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "SubTotal:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(281, 413);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(165, 20);
            this.txtSubTotal.TabIndex = 36;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnInvoice.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(555, 399);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(155, 39);
            this.btnInvoice.TabIndex = 38;
            this.btnInvoice.Text = "Facturar";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(555, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 39);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // orderID
            // 
            this.orderID.FormattingEnabled = true;
            this.orderID.Location = new System.Drawing.Point(281, 142);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(104, 212);
            this.orderID.TabIndex = 40;
            // 
            // orderDate
            // 
            this.orderDate.FormattingEnabled = true;
            this.orderDate.Location = new System.Drawing.Point(383, 142);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(173, 212);
            this.orderDate.TabIndex = 41;
            // 
            // orderPrice
            // 
            this.orderPrice.FormattingEnabled = true;
            this.orderPrice.Location = new System.Drawing.Point(555, 142);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(155, 212);
            this.orderPrice.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(281, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "Número de pedido";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(383, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 44;
            this.textBox2.Text = "Fecha";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(555, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 45;
            this.textBox3.Text = "Monto";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // frmAddBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(830, 485);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.orderPrice);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtClientID);
            this.Name = "frmAddBilling";
            this.Text = "Facturación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox orderID;
        private System.Windows.Forms.ListBox orderDate;
        private System.Windows.Forms.ListBox orderPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}