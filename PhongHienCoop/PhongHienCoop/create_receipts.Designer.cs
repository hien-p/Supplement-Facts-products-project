namespace PhongHienCoop
{
    partial class create_receipts
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
            this.panel_tab = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Recieved_Note = new System.Windows.Forms.Label();
            this.panel_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tab
            // 
            this.panel_tab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_tab.Controls.Add(this.button2);
            this.panel_tab.Controls.Add(this.button1);
            this.panel_tab.Controls.Add(this.Recieved_Note);
            this.panel_tab.Location = new System.Drawing.Point(0, 0);
            this.panel_tab.Name = "panel_tab";
            this.panel_tab.Size = new System.Drawing.Size(801, 48);
            this.panel_tab.TabIndex = 0;
            this.panel_tab.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_tab_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(599, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back to Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.backtodashboard);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(461, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Product List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_products);
            // 
            // Recieved_Note
            // 
            this.Recieved_Note.AutoSize = true;
            this.Recieved_Note.Font = new System.Drawing.Font("Sylfaen", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recieved_Note.Location = new System.Drawing.Point(12, 2);
            this.Recieved_Note.Name = "Recieved_Note";
            this.Recieved_Note.Size = new System.Drawing.Size(233, 46);
            this.Recieved_Note.TabIndex = 1;
            this.Recieved_Note.Text = "Recieved Note";
            // 
            // create_receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 477);
            this.Controls.Add(this.panel_tab);
            this.Name = "create_receipts";
            this.Load += new System.EventHandler(this.create_invoice_Load);
            this.panel_tab.ResumeLayout(false);
            this.panel_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tab;
        private System.Windows.Forms.Label Recieved_Note;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}