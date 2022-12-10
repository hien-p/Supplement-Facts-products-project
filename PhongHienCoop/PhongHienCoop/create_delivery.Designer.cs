namespace PhongHienCoop
{
    partial class create_delivery
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
            this.label_Note = new System.Windows.Forms.Label();
            this.button_to_product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.total_amount_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tab
            // 
            this.panel_tab.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_tab.Controls.Add(this.button1);
            this.panel_tab.Controls.Add(this.button_to_product);
            this.panel_tab.Controls.Add(this.label_Note);
            this.panel_tab.Location = new System.Drawing.Point(2, 4);
            this.panel_tab.Name = "panel_tab";
            this.panel_tab.Size = new System.Drawing.Size(799, 51);
            this.panel_tab.TabIndex = 0;
            // 
            // label_Note
            // 
            this.label_Note.AutoSize = true;
            this.label_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_Note.Location = new System.Drawing.Point(10, 5);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(222, 39);
            this.label_Note.TabIndex = 0;
            this.label_Note.Text = "Delivery Note";
            // 
            // button_to_product
            // 
            this.button_to_product.BackColor = System.Drawing.Color.White;
            this.button_to_product.FlatAppearance.BorderSize = 3;
            this.button_to_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_to_product.Location = new System.Drawing.Point(583, 8);
            this.button_to_product.Name = "button_to_product";
            this.button_to_product.Size = new System.Drawing.Size(181, 36);
            this.button_to_product.TabIndex = 1;
            this.button_to_product.Text = "Back to Product";
            this.button_to_product.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button1.Location = new System.Drawing.Point(458, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label_total.Location = new System.Drawing.Point(529, 420);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(120, 22);
            this.label_total.TabIndex = 1;
            this.label_total.Text = "Total amount:";
            // 
            // total_amount_box
            // 
            this.total_amount_box.BackColor = System.Drawing.Color.LightGray;
            this.total_amount_box.Location = new System.Drawing.Point(655, 421);
            this.total_amount_box.Name = "total_amount_box";
            this.total_amount_box.Size = new System.Drawing.Size(84, 20);
            this.total_amount_box.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 280);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordered list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // create_delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(777, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.total_amount_box);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.panel_tab);
            this.Name = "create_delivery";
            this.Text = "create_delivery";
            this.panel_tab.ResumeLayout(false);
            this.panel_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_tab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_to_product;
        private System.Windows.Forms.Label label_Note;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox total_amount_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}