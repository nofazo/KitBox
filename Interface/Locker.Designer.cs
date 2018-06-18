namespace Interface
{
    partial class Locker
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locker));
            this.AddLocker = new System.Windows.Forms.Button();
            this.comboHeight = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.FinishLockers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Modify = new System.Windows.Forms.Button();
            this.lockerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColorLocker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeightLocker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorDoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddLocker
            // 
            this.AddLocker.BackColor = System.Drawing.Color.Silver;
            this.AddLocker.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocker.ForeColor = System.Drawing.Color.Black;
            this.AddLocker.Location = new System.Drawing.Point(1163, 504);
            this.AddLocker.Margin = new System.Windows.Forms.Padding(4);
            this.AddLocker.Name = "AddLocker";
            this.AddLocker.Size = new System.Drawing.Size(204, 101);
            this.AddLocker.TabIndex = 0;
            this.AddLocker.Text = "Add locker";
            this.AddLocker.UseVisualStyleBackColor = false;
            this.AddLocker.Click += new System.EventHandler(this.AddLocker_Click);
            // 
            // comboHeight
            // 
            this.comboHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHeight.Items.AddRange(new object[] {
            "36",
            "46",
            "56"});
            this.comboHeight.Location = new System.Drawing.Point(395, 246);
            this.comboHeight.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboHeight.Name = "comboHeight";
            this.comboHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboHeight.Size = new System.Drawing.Size(167, 39);
            this.comboHeight.TabIndex = 13;
            this.comboHeight.SelectedIndexChanged += new System.EventHandler(this.comboHeight_SelectedIndexChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBox.Items.AddRange(new object[] {
            "Brown",
            "White"});
            this.ColorBox.Location = new System.Drawing.Point(395, 319);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ColorBox.Size = new System.Drawing.Size(167, 39);
            this.ColorBox.TabIndex = 14;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(395, 396);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(477, 396);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yes";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FinishLockers
            // 
            this.FinishLockers.BackColor = System.Drawing.Color.Silver;
            this.FinishLockers.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishLockers.ForeColor = System.Drawing.Color.Black;
            this.FinishLockers.Location = new System.Drawing.Point(919, 504);
            this.FinishLockers.Margin = new System.Windows.Forms.Padding(4);
            this.FinishLockers.Name = "FinishLockers";
            this.FinishLockers.Size = new System.Drawing.Size(204, 101);
            this.FinishLockers.TabIndex = 18;
            this.FinishLockers.Text = "No more lockers";
            this.FinishLockers.UseVisualStyleBackColor = false;
            this.FinishLockers.Click += new System.EventHandler(this.FinishLockers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Interface.Properties.Resources.KITBOX_fond_basecorr;
            this.pictureBox1.Location = new System.Drawing.Point(131, 377);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 59);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.Color.Silver;
            this.Modify.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify.ForeColor = System.Drawing.Color.Black;
            this.Modify.Location = new System.Drawing.Point(395, 504);
            this.Modify.Margin = new System.Windows.Forms.Padding(4);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(204, 101);
            this.Modify.TabIndex = 21;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = false;
            this.Modify.Click += new System.EventHandler(this.button1_Click);
            // 
            // lockerBindingSource
            // 
            this.lockerBindingSource.DataSource = typeof(Kitbox.Locker);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColorLocker,
            this.HeightLocker,
            this.DoorType,
            this.ColorDoor,
            this.Disponibility});
            this.dataGridView1.Location = new System.Drawing.Point(790, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 161);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColorLocker
            // 
            this.ColorLocker.HeaderText = "Color locker";
            this.ColorLocker.Name = "ColorLocker";
            this.ColorLocker.ReadOnly = true;
            // 
            // HeightLocker
            // 
            this.HeightLocker.HeaderText = "Height Locker";
            this.HeightLocker.Name = "HeightLocker";
            this.HeightLocker.ReadOnly = true;
            // 
            // DoorType
            // 
            this.DoorType.HeaderText = "Door";
            this.DoorType.Name = "DoorType";
            this.DoorType.ReadOnly = true;
            // 
            // ColorDoor
            // 
            this.ColorDoor.HeaderText = "Door Color";
            this.ColorDoor.Name = "ColorDoor";
            this.ColorDoor.ReadOnly = true;
            // 
            // Disponibility
            // 
            this.Disponibility.HeaderText = "Disponibility";
            this.Disponibility.Name = "Disponibility";
            this.Disponibility.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Silver;
            this.Update.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(665, 504);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(204, 101);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(65, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 101);
            this.button1.TabIndex = 27;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(790, 426);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(394, 61);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Attention ! \r\nWe don\'t have corner with a corresponding height. You will be asked" +
    " for an extra charge for cutting the corner.";
            this.textBox1.Visible = false;
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FinishLockers);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.comboHeight);
            this.Controls.Add(this.AddLocker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Locker";
            this.Size = new System.Drawing.Size(1403, 729);
            this.Load += new System.EventHandler(this.UserControl4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddLocker;
        private System.Windows.Forms.ComboBox comboHeight;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button FinishLockers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.BindingSource lockerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorLocker;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeightLocker;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorDoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibility;
    }
}
