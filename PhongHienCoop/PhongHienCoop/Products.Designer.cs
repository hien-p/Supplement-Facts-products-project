namespace PhongHienCoop
{
    partial class Products
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.product_search = new System.Windows.Forms.TextBox();
            this.search_product_label = new System.Windows.Forms.Label();
            this.Product_list = new System.Windows.Forms.TabControl();
            this.button_to_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1.SuspendLayout();
            this.Product_list.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.button_edit);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Controls.Add(this.button_search);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.product_search);
            this.tabPage1.Controls.Add(this.search_product_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products list";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(710, 225);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 35);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(710, 174);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(87, 35);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(710, 121);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(87, 35);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Add new";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.White;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_search.Location = new System.Drawing.Point(562, 34);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(116, 34);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "search";
            this.button_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_search.UseMnemonic = false;
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 282);
            this.panel1.TabIndex = 5;
            // 
            // product_search
            // 
            this.product_search.Location = new System.Drawing.Point(12, 37);
            this.product_search.Multiline = true;
            this.product_search.Name = "product_search";
            this.product_search.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.product_search.Size = new System.Drawing.Size(531, 26);
            this.product_search.TabIndex = 4;
            // 
            // search_product_label
            // 
            this.search_product_label.AutoSize = true;
            this.search_product_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.search_product_label.Location = new System.Drawing.Point(8, 14);
            this.search_product_label.Name = "search_product_label";
            this.search_product_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_product_label.Size = new System.Drawing.Size(128, 20);
            this.search_product_label.TabIndex = 3;
            this.search_product_label.Text = "Search product:";
            this.search_product_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.search_product_label.UseMnemonic = false;
            // 
            // Product_list
            // 
            this.Product_list.Controls.Add(this.tabPage1);
            this.Product_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Product_list.Location = new System.Drawing.Point(0, 45);
            this.Product_list.Name = "Product_list";
            this.Product_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Product_list.SelectedIndex = 0;
            this.Product_list.Size = new System.Drawing.Size(831, 428);
            this.Product_list.TabIndex = 2;
            // 
            // button_to_dashboard
            // 
            this.button_to_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_to_dashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_to_dashboard.Location = new System.Drawing.Point(705, 1);
            this.button_to_dashboard.Name = "button_to_dashboard";
            this.button_to_dashboard.Size = new System.Drawing.Size(112, 38);
            this.button_to_dashboard.TabIndex = 11;
            this.button_to_dashboard.Text = "Back To Dashboard";
            this.button_to_dashboard.UseVisualStyleBackColor = false;
            this.button_to_dashboard.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(835, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 485);
            this.Controls.Add(this.button_to_dashboard);
            this.Controls.Add(this.Product_list);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Products";
            this.Text = "Warehouse ";
            this.Load += new System.EventHandler(this.Products_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Product_list.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Product_list;
        private System.Windows.Forms.TextBox product_search;
        private System.Windows.Forms.Label search_product_label;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_to_dashboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}