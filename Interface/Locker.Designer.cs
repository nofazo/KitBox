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
            this.Finish = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Modify = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lockerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.couleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hauteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profondeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
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
            this.AddLocker.Location = new System.Drawing.Point(1161, 517);
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
            "56",
            "72",
            "92",
            "108",
            "112",
            "138",
            "144",
            "168",
            "180",
            "184",
            "216",
            "224",
            "230",
            "252",
            "276",
            "280"});
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
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Silver;
            this.Finish.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.Color.Black;
            this.Finish.Location = new System.Drawing.Point(601, 517);
            this.Finish.Margin = new System.Windows.Forms.Padding(4);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(204, 101);
            this.Finish.TabIndex = 18;
            this.Finish.Text = "No more locker";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Interface.Properties.Resources.KITBOX_fond_basecorr;
            this.pictureBox1.Location = new System.Drawing.Point(85, 382);
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
            this.Modify.Location = new System.Drawing.Point(57, 517);
            this.Modify.Margin = new System.Windows.Forms.Padding(4);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(204, 101);
            this.Modify.TabIndex = 21;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = false;
            this.Modify.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.DataSource = this.lockerBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(893, 517);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 100);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lockerBindingSource
            // 
            this.lockerBindingSource.DataSource = typeof(Kitbox.Locker);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.couleur,
            this.hauteur,
            this.profondeur,
            this.largeur});
            this.dataGridView1.Location = new System.Drawing.Point(785, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 161);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // couleur
            // 
            this.couleur.HeaderText = "couleur";
            this.couleur.Name = "couleur";
            this.couleur.ReadOnly = true;
            // 
            // hauteur
            // 
            this.hauteur.HeaderText = "hauteur";
            this.hauteur.Name = "hauteur";
            this.hauteur.ReadOnly = true;
            // 
            // profondeur
            // 
            this.profondeur.HeaderText = "profondeur";
            this.profondeur.Name = "profondeur";
            this.profondeur.ReadOnly = true;
            // 
            // largeur
            // 
            this.largeur.HeaderText = "largeur";
            this.largeur.Name = "largeur";
            this.largeur.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Silver;
            this.Update.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(310, 516);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(204, 101);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Finish);
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
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource lockerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn hauteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn profondeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn largeur;
        private System.Windows.Forms.Button Update;
    }
}
