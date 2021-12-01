
namespace IU.Order
{
    partial class frmEditOrder
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
            this.lblOrder = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.lblFurniture = new System.Windows.Forms.Label();
            this.comboBoxOrderFurniture = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAddFurniture = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSpecifications = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(71, 30);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(51, 17);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(176, 30);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCliente.TabIndex = 1;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFurniture
            // 
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Location = new System.Drawing.Point(33, 88);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(137, 17);
            this.lblFurniture.TabIndex = 2;
            this.lblFurniture.Text = "Muebles en la orden";
            // 
            // comboBoxOrderFurniture
            // 
            this.comboBoxOrderFurniture.FormattingEnabled = true;
            this.comboBoxOrderFurniture.Location = new System.Drawing.Point(176, 81);
            this.comboBoxOrderFurniture.Name = "comboBoxOrderFurniture";
            this.comboBoxOrderFurniture.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrderFurniture.TabIndex = 3;
            this.comboBoxOrderFurniture.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderFurniture_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Borrar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar mueble";
            // 
            // comboBoxAddFurniture
            // 
            this.comboBoxAddFurniture.FormattingEnabled = true;
            this.comboBoxAddFurniture.Location = new System.Drawing.Point(176, 211);
            this.comboBoxAddFurniture.Name = "comboBoxAddFurniture";
            this.comboBoxAddFurniture.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAddFurniture.TabIndex = 6;
            this.comboBoxAddFurniture.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddFurniture_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(176, 345);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Especificaciones";
            // 
            // textBoxSpecifications
            // 
            this.textBoxSpecifications.Location = new System.Drawing.Point(176, 266);
            this.textBoxSpecifications.Name = "textBoxSpecifications";
            this.textBoxSpecifications.Size = new System.Drawing.Size(152, 22);
            this.textBoxSpecifications.TabIndex = 9;
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSpecifications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxAddFurniture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxOrderFurniture);
            this.Controls.Add(this.lblFurniture);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.lblOrder);
            this.Name = "frmEditOrder";
            this.Text = "frmEditOrder";
            this.Load += new System.EventHandler(this.frmEditOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label lblFurniture;
        private System.Windows.Forms.ComboBox comboBoxOrderFurniture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAddFurniture;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSpecifications;
    }
}