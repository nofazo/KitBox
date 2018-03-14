namespace Interface
{
    partial class UserControl3
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
            this.comboWidth = new System.Windows.Forms.ComboBox();
            this.comboDepth = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboWidth
            // 
            this.comboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboWidth.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.comboWidth.Location = new System.Drawing.Point(383, 196);
            this.comboWidth.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboWidth.Name = "comboWidth";
            this.comboWidth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboWidth.Size = new System.Drawing.Size(122, 33);
            this.comboWidth.TabIndex = 13;
            this.comboWidth.SelectedIndexChanged += new System.EventHandler(this.comboWidth_SelectedIndexChanged);
            // 
            // comboDepth
            // 
            this.comboDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepth.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.comboDepth.Location = new System.Drawing.Point(383, 269);
            this.comboDepth.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboDepth.Name = "comboDepth";
            this.comboDepth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboDepth.Size = new System.Drawing.Size(122, 33);
            this.comboDepth.TabIndex = 14;
            this.comboDepth.SelectedIndexChanged += new System.EventHandler(this.comboDepth_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(362, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 73);
            this.button1.TabIndex = 15;
            this.button1.Text = "Choose Locker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interface.Properties.Resources._long;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboDepth);
            this.Controls.Add(this.comboWidth);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1054, 592);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWidth;
        private System.Windows.Forms.ComboBox comboDepth;
        private System.Windows.Forms.Button button1;
    }
}
