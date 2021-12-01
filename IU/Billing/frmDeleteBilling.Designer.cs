
namespace IU.Billing
{
    partial class frmDeleteBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteBilling));
            this.cbBilling = new System.Windows.Forms.ComboBox();
            this.btnDeleteBilling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBilling
            // 
            this.cbBilling.Enabled = false;
            this.cbBilling.FormattingEnabled = true;
            this.cbBilling.Location = new System.Drawing.Point(246, 73);
            this.cbBilling.Margin = new System.Windows.Forms.Padding(2);
            this.cbBilling.Name = "cbBilling";
            this.cbBilling.Size = new System.Drawing.Size(156, 21);
            this.cbBilling.TabIndex = 6;
            // 
            // btnDeleteBilling
            // 
            this.btnDeleteBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBilling.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBilling.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBilling.Location = new System.Drawing.Point(246, 109);
            this.btnDeleteBilling.Name = "btnDeleteBilling";
            this.btnDeleteBilling.Size = new System.Drawing.Size(155, 39);
            this.btnDeleteBilling.TabIndex = 5;
            this.btnDeleteBilling.Text = "Eliminar";
            this.btnDeleteBilling.UseVisualStyleBackColor = false;
            this.btnDeleteBilling.Click += new System.EventHandler(this.btnDeleteBilling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(246, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de factura";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(46, 73);
            this.cbClient.Margin = new System.Windows.Forms.Padding(2);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(156, 21);
            this.cbClient.TabIndex = 8;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // frmDeleteBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(463, 176);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBilling);
            this.Controls.Add(this.btnDeleteBilling);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteBilling";
            this.Text = "Eliminar factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBilling;
        private System.Windows.Forms.Button btnDeleteBilling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label2;
    }
}