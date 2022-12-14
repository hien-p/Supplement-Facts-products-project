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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_delivery));
            this.panel_tab = new System.Windows.Forms.Panel();
            this.label_Note = new System.Windows.Forms.Label();
            this.input_date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordertab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.details_print = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_delivery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_box = new System.Windows.Forms.TextBox();
            this.Agent_phone_box = new System.Windows.Forms.TextBox();
            this.agent_name_box = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ordertab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.details_print.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tab
            // 
            this.panel_tab.BackColor = System.Drawing.Color.SkyBlue;
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
            // input_date
            // 
            this.input_date.AutoSize = true;
            this.input_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.input_date.Location = new System.Drawing.Point(441, 34);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(50, 20);
            this.input_date.TabIndex = 17;
            this.input_date.Text = "Date:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.button1.Location = new System.Drawing.Point(491, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSalmon;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button5.Location = new System.Drawing.Point(611, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 36);
            this.button5.TabIndex = 32;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 261);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datagridkeydown);
            // 
            // ordertab
            // 
            this.ordertab.Controls.Add(this.tabPage1);
            this.ordertab.Controls.Add(this.details_print);
            this.ordertab.Location = new System.Drawing.Point(12, 61);
            this.ordertab.Name = "ordertab";
            this.ordertab.SelectedIndex = 0;
            this.ordertab.Size = new System.Drawing.Size(772, 418);
            this.ordertab.TabIndex = 33;
            this.ordertab.SelectedIndexChanged += new System.EventHandler(this.ordertab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // details_print
            // 
            this.details_print.Controls.Add(this.label3);
            this.details_print.Controls.Add(this.comboBox1);
            this.details_print.Controls.Add(this.dataGridView2);
            this.details_print.Controls.Add(this.ID_delivery);
            this.details_print.Controls.Add(this.input_date);
            this.details_print.Controls.Add(this.label1);
            this.details_print.Controls.Add(this.Date_box);
            this.details_print.Controls.Add(this.Agent_phone_box);
            this.details_print.Controls.Add(this.agent_name_box);
            this.details_print.Controls.Add(this.Print);
            this.details_print.Location = new System.Drawing.Point(4, 22);
            this.details_print.Name = "details_print";
            this.details_print.Padding = new System.Windows.Forms.Padding(3);
            this.details_print.Size = new System.Drawing.Size(764, 392);
            this.details_print.TabIndex = 1;
            this.details_print.Text = "Details";
            this.details_print.UseVisualStyleBackColor = true;
            this.details_print.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(441, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Payment Status ";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "paid",
            "unpaid"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "paid \t",
            "unpaid"});
            this.comboBox1.Location = new System.Drawing.Point(445, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.quantity,
            this.Column2,
            this.total});
            this.dataGridView2.Location = new System.Drawing.Point(37, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(678, 174);
            this.dataGridView2.TabIndex = 47;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID_product";
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "price";
            this.Column2.Name = "Column2";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // ID_delivery
            // 
            this.ID_delivery.BackColor = System.Drawing.Color.Yellow;
            this.ID_delivery.Location = new System.Drawing.Point(69, 20);
            this.ID_delivery.Name = "ID_delivery";
            this.ID_delivery.ReadOnly = true;
            this.ID_delivery.Size = new System.Drawing.Size(72, 20);
            this.ID_delivery.TabIndex = 46;
            this.ID_delivery.TextChanged += new System.EventHandler(this.ID_delivery_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID: ";
            // 
            // Date_box
            // 
            this.Date_box.Location = new System.Drawing.Point(507, 34);
            this.Date_box.Name = "Date_box";
            this.Date_box.Size = new System.Drawing.Size(169, 20);
            this.Date_box.TabIndex = 44;
            // 
            // Agent_phone_box
            // 
            this.Agent_phone_box.Location = new System.Drawing.Point(37, 99);
            this.Agent_phone_box.Name = "Agent_phone_box";
            this.Agent_phone_box.ReadOnly = true;
            this.Agent_phone_box.Size = new System.Drawing.Size(233, 20);
            this.Agent_phone_box.TabIndex = 43;
            this.Agent_phone_box.TextChanged += new System.EventHandler(this.Agent_phone_box_TextChanged);
            // 
            // agent_name_box
            // 
            this.agent_name_box.Location = new System.Drawing.Point(37, 56);
            this.agent_name_box.Name = "agent_name_box";
            this.agent_name_box.ReadOnly = true;
            this.agent_name_box.Size = new System.Drawing.Size(233, 20);
            this.agent_name_box.TabIndex = 42;
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.Turquoise;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Print.Location = new System.Drawing.Point(445, 328);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(122, 45);
            this.Print.TabIndex = 41;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // create_delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(796, 490);
            this.Controls.Add(this.ordertab);
            this.Controls.Add(this.panel_tab);
            this.Name = "create_delivery";
            this.Text = "create_delivery";
            this.Load += new System.EventHandler(this.create_delivery_Load);
            this.panel_tab.ResumeLayout(false);
            this.panel_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ordertab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.details_print.ResumeLayout(false);
            this.details_print.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Note;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label input_date;
        private System.Windows.Forms.TabControl ordertab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage details_print;
        private System.Windows.Forms.Button Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox Date_box;
        private System.Windows.Forms.TextBox Agent_phone_box;
        private System.Windows.Forms.TextBox agent_name_box;
        private System.Windows.Forms.TextBox ID_delivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}