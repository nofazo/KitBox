namespace WindowsFormsApp7
{
    partial class AdminAddNewITem
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartForLocker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF,
            this.IdPart,
            this.Dimensions,
            this.Height,
            this.depth,
            this.width,
            this.color,
            this.Instock,
            this.StockMin,
            this.Price,
            this.PartForLocker});
            this.dataGridView1.Location = new System.Drawing.Point(515, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 546);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // REF
            // 
            this.REF.HeaderText = "REF";
            this.REF.Name = "REF";
            this.REF.ReadOnly = true;
            // 
            // IdPart
            // 
            this.IdPart.HeaderText = "IdPart";
            this.IdPart.Name = "IdPart";
            this.IdPart.ReadOnly = true;
            // 
            // Dimensions
            // 
            this.Dimensions.HeaderText = "Dimensions";
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.ReadOnly = true;
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            // 
            // depth
            // 
            this.depth.HeaderText = "depth";
            this.depth.Name = "depth";
            this.depth.ReadOnly = true;
            // 
            // width
            // 
            this.width.HeaderText = "width";
            this.width.Name = "width";
            this.width.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // Instock
            // 
            this.Instock.HeaderText = "Instock";
            this.Instock.Name = "Instock";
            this.Instock.ReadOnly = true;
            // 
            // StockMin
            // 
            this.StockMin.HeaderText = "StockMin";
            this.StockMin.Name = "StockMin";
            this.StockMin.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // PartForLocker
            // 
            this.PartForLocker.HeaderText = "Part/locker";
            this.PartForLocker.Name = "PartForLocker";
            this.PartForLocker.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add To Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(38, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 15);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "REF :";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(38, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(145, 15);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "IdPart :";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(38, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(145, 15);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Dimensions :";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(38, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(145, 15);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "Height :";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(38, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(145, 15);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "Depth :";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(38, 268);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(145, 15);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "Width :";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(38, 316);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(145, 15);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "Color :";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(38, 377);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(145, 15);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "InStock :";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(38, 429);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(145, 15);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "StockMin :";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(38, 483);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(145, 15);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "Price :";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(38, 538);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(145, 15);
            this.textBox11.TabIndex = 26;
            this.textBox11.Text = "Part / locker :";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(240, 25);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(245, 22);
            this.textBox12.TabIndex = 27;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(240, 70);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(245, 22);
            this.textBox13.TabIndex = 29;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(240, 114);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(245, 22);
            this.textBox14.TabIndex = 30;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(240, 167);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(245, 22);
            this.textBox15.TabIndex = 31;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(240, 211);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(245, 22);
            this.textBox16.TabIndex = 32;
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(240, 261);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(245, 22);
            this.textBox17.TabIndex = 33;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(240, 309);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(245, 22);
            this.textBox18.TabIndex = 34;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(240, 370);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(245, 22);
            this.textBox19.TabIndex = 35;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(240, 422);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(245, 22);
            this.textBox20.TabIndex = 36;
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(240, 476);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(245, 22);
            this.textBox21.TabIndex = 37;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(240, 531);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(245, 22);
            this.textBox22.TabIndex = 38;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 56);
            this.button2.TabIndex = 39;
            this.button2.Text = "Add item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 56);
            this.button3.TabIndex = 40;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminAddNewITem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminAddNewITem";
            this.Size = new System.Drawing.Size(1807, 904);
            this.Load += new System.EventHandler(this.AdminAddNewITem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartForLocker;
        private System.Windows.Forms.Button button3;
    }
}
