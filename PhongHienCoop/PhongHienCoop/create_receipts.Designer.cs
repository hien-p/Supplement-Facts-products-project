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
            this.label2 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agentboxname = new System.Windows.Forms.TextBox();
            this.agentboxphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_emp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Total_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_re = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nameagent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Recieved: ";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label_date.Location = new System.Drawing.Point(166, 78);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(2, 24);
            this.label_date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(31, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agents Name";
            // 
            // agentboxname
            // 
            this.agentboxname.Location = new System.Drawing.Point(134, 126);
            this.agentboxname.Name = "agentboxname";
            this.agentboxname.Size = new System.Drawing.Size(256, 20);
            this.agentboxname.TabIndex = 5;
            // 
            // agentboxphone
            // 
            this.agentboxphone.Location = new System.Drawing.Point(134, 172);
            this.agentboxphone.Name = "agentboxphone";
            this.agentboxphone.Size = new System.Drawing.Size(256, 20);
            this.agentboxphone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(31, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agents Phone";
            // 
            // productbox
            // 
            this.productbox.Location = new System.Drawing.Point(519, 126);
            this.productbox.Multiline = true;
            this.productbox.Name = "productbox";
            this.productbox.Size = new System.Drawing.Size(256, 20);
            this.productbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(409, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Name";
            // 
            // quantitybox
            // 
            this.quantitybox.Location = new System.Drawing.Point(512, 172);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(77, 20);
            this.quantitybox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(413, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // name_emp
            // 
            this.name_emp.AutoSize = true;
            this.name_emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.name_emp.Location = new System.Drawing.Point(409, 74);
            this.name_emp.Name = "name_emp";
            this.name_emp.Size = new System.Drawing.Size(2, 24);
            this.name_emp.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label7.Location = new System.Drawing.Point(309, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Employee ";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.add_button.Location = new System.Drawing.Point(48, 217);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(139, 56);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.Color.IndianRed;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Cancel_button.Location = new System.Drawing.Point(225, 216);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(129, 56);
            this.Cancel_button.TabIndex = 15;
            this.Cancel_button.Text = "Remove";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(671, 172);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(77, 20);
            this.pricebox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(612, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Price";
            // 
            // Total_box
            // 
            this.Total_box.Location = new System.Drawing.Point(512, 217);
            this.Total_box.Name = "Total_box";
            this.Total_box.ReadOnly = true;
            this.Total_box.Size = new System.Drawing.Size(77, 20);
            this.Total_box.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(427, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total";
            // 
            // ID_re
            // 
            this.ID_re.AutoSize = true;
            this.ID_re.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ID_re.Location = new System.Drawing.Point(678, 76);
            this.ID_re.Name = "ID_re";
            this.ID_re.Size = new System.Drawing.Size(2, 24);
            this.ID_re.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label10.Location = new System.Drawing.Point(538, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID of Receipts ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nameagent,
            this.Phone,
            this.productname,
            this.Quantity,
            this.price,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(32, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 181);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nameagent
            // 
            this.Nameagent.DataPropertyName = "Nameagent";
            this.Nameagent.HeaderText = "Agents name";
            this.Nameagent.Name = "Nameagent";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // productname
            // 
            this.productname.DataPropertyName = "productname";
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "quantity";
            this.Quantity.Name = "Quantity";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // create_receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(797, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ID_re);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Total_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.name_emp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agentboxphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.agentboxname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_tab);
            this.Name = "create_receipts";
            this.Load += new System.EventHandler(this.create_invoice_Load);
            this.panel_tab.ResumeLayout(false);
            this.panel_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_tab;
        private System.Windows.Forms.Label Recieved_Note;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
       
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agentboxname;
        private System.Windows.Forms.TextBox agentboxphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name_emp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ID_re;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nameagent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}