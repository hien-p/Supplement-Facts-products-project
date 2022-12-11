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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button_delivery = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.product_search = new System.Windows.Forms.TextBox();
            this.search_product_label = new System.Windows.Forms.Label();
            this.Product_list = new System.Windows.Forms.TabControl();
            this.button_to_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.views = new System.Windows.Forms.Button();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.Product_list.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.views);
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Controls.Add(this.button_delivery);
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.button_edit);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Controls.Add(this.button_search);
            this.tabPage1.Controls.Add(this.product_search);
            this.tabPage1.Controls.Add(this.search_product_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products list";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.price,
            this.quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.GridColor = System.Drawing.Color.Black;
            this.dataGrid.Location = new System.Drawing.Point(12, 74);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(777, 354);
            this.dataGrid.TabIndex = 11;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // button_delivery
            // 
            this.button_delivery.Location = new System.Drawing.Point(811, 276);
            this.button_delivery.Name = "button_delivery";
            this.button_delivery.Size = new System.Drawing.Size(87, 33);
            this.button_delivery.TabIndex = 10;
            this.button_delivery.Text = "Delivery Note";
            this.button_delivery.UseVisualStyleBackColor = true;
            this.button_delivery.Click += new System.EventHandler(this.button_delivery_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(811, 211);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 35);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(811, 147);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(87, 35);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(811, 85);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(87, 35);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Add new";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
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
            this.Product_list.Size = new System.Drawing.Size(927, 491);
            this.Product_list.TabIndex = 2;
            // 
            // button_to_dashboard
            // 
            this.button_to_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_to_dashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_to_dashboard.Location = new System.Drawing.Point(815, 1);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(939, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // views
            // 
            this.views.BackColor = System.Drawing.Color.White;
            this.views.Location = new System.Drawing.Point(697, 34);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(92, 34);
            this.views.TabIndex = 12;
            this.views.Text = "View details";
            this.views.UseVisualStyleBackColor = false;
            this.views.Click += new System.EventHandler(this.views_Click);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "product_id";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "product_name";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 548);
            this.Controls.Add(this.button_to_dashboard);
            this.Controls.Add(this.Product_list);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Products";
            this.Text = "Warehouse ";
            this.Load += new System.EventHandler(this.Products_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button button_delivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_to_dashboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button views;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.ImageList imageList1;
    }
}