namespace WindowsFormsApp7
{
    partial class AdminAdministration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindIt = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBoxPlocker = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStockMin = new System.Windows.Forms.TextBox();
            this.textBoxIStock = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxDim = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Modify = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1231, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FindIt
            // 
            this.FindIt.Location = new System.Drawing.Point(377, 33);
            this.FindIt.Name = "FindIt";
            this.FindIt.Size = new System.Drawing.Size(188, 30);
            this.FindIt.TabIndex = 2;
            this.FindIt.Text = "Find";
            this.FindIt.UseVisualStyleBackColor = true;
            this.FindIt.Click += new System.EventHandler(this.FindIt_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(76, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(40, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Find : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1126, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(559, 247);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(249, 57);
            this.Update.TabIndex = 84;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBoxPlocker
            // 
            this.textBoxPlocker.Location = new System.Drawing.Point(720, 198);
            this.textBoxPlocker.Name = "textBoxPlocker";
            this.textBoxPlocker.Size = new System.Drawing.Size(183, 22);
            this.textBoxPlocker.TabIndex = 83;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(720, 160);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(183, 22);
            this.textBoxPrice.TabIndex = 82;
            // 
            // textBoxStockMin
            // 
            this.textBoxStockMin.Location = new System.Drawing.Point(720, 124);
            this.textBoxStockMin.Name = "textBoxStockMin";
            this.textBoxStockMin.Size = new System.Drawing.Size(183, 22);
            this.textBoxStockMin.TabIndex = 81;
            // 
            // textBoxIStock
            // 
            this.textBoxIStock.Location = new System.Drawing.Point(720, 92);
            this.textBoxIStock.Name = "textBoxIStock";
            this.textBoxIStock.Size = new System.Drawing.Size(183, 22);
            this.textBoxIStock.TabIndex = 80;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(720, 55);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(183, 22);
            this.textBoxColor.TabIndex = 79;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(282, 260);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(173, 22);
            this.textBoxWidth.TabIndex = 78;
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(282, 219);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(173, 22);
            this.textBoxDepth.TabIndex = 77;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(282, 178);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(173, 22);
            this.textBoxHeight.TabIndex = 76;
            // 
            // textBoxDim
            // 
            this.textBoxDim.Location = new System.Drawing.Point(282, 131);
            this.textBoxDim.Name = "textBoxDim";
            this.textBoxDim.Size = new System.Drawing.Size(173, 22);
            this.textBoxDim.TabIndex = 75;
            this.textBoxDim.TextChanged += new System.EventHandler(this.textBoxDim_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(282, 95);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(173, 22);
            this.textBoxId.TabIndex = 74;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(282, 55);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(173, 22);
            this.textBoxRef.TabIndex = 73;
            this.textBoxRef.TextChanged += new System.EventHandler(this.textBoxRef_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(499, 205);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(83, 15);
            this.textBox11.TabIndex = 72;
            this.textBox11.Text = "Part / locker :";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(494, 167);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(83, 15);
            this.textBox10.TabIndex = 71;
            this.textBox10.Text = "Price :";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(494, 131);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(83, 15);
            this.textBox9.TabIndex = 70;
            this.textBox9.Text = "StockMin :";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(494, 99);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(83, 15);
            this.textBox8.TabIndex = 69;
            this.textBox8.Text = "InStock :";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(499, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(83, 15);
            this.textBox7.TabIndex = 68;
            this.textBox7.Text = "Color :";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(61, 267);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(73, 15);
            this.textBox6.TabIndex = 67;
            this.textBox6.Text = "Width :";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(56, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(73, 15);
            this.textBox5.TabIndex = 66;
            this.textBox5.Text = "Depth :";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(56, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(73, 15);
            this.textBox4.TabIndex = 65;
            this.textBox4.Text = "Height :";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(56, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(73, 15);
            this.textBox3.TabIndex = 64;
            this.textBox3.Text = "Dimensions :";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Location = new System.Drawing.Point(56, 102);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(73, 15);
            this.textBox23.TabIndex = 63;
            this.textBox23.Text = "IdPart :";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Location = new System.Drawing.Point(56, 62);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(73, 15);
            this.textBox24.TabIndex = 62;
            this.textBox24.Text = "REF :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.textBoxPlocker);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxStockMin);
            this.groupBox1.Controls.Add(this.textBoxIStock);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.textBoxWidth);
            this.groupBox1.Controls.Add(this.textBoxDepth);
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.textBoxDim);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.textBoxRef);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox23);
            this.groupBox1.Controls.Add(this.textBox24);
            this.groupBox1.Location = new System.Drawing.Point(76, 563);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 326);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(920, 474);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(185, 62);
            this.Modify.TabIndex = 86;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 62);
            this.button2.TabIndex = 87;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FindIt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminAdministration";
            this.Size = new System.Drawing.Size(1363, 979);
            this.Load += new System.EventHandler(this.AdminAddingExistingItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FindIt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBoxPlocker;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStockMin;
        private System.Windows.Forms.TextBox textBoxIStock;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxDim;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button button2;
    }
}
