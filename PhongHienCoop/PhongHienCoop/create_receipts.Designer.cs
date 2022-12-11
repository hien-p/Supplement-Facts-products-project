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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            //this.Boxdate = new System.Windows.Forms.TextBox();
            this.panel_tab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel_tab.Size = new System.Drawing.Size(801, 47);
            this.panel_tab.TabIndex = 0;
            this.panel_tab.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_tab_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button2.Location = new System.Drawing.Point(589, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back to Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.backtodashboard);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.Location = new System.Drawing.Point(463, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(765, 368);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(413, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Recieved: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Boxdate
            // 
            
            // 
            // create_receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(797, 477);
            //this.Controls.Add(this.Boxdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_tab);
            this.Name = "create_receipts";
            this.Load += new System.EventHandler(this.create_invoice_Load);
            this.panel_tab.ResumeLayout(false);
            this.panel_tab.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_tab;
        private System.Windows.Forms.Label Recieved_Note;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Boxdate;
    }
}