namespace Interface
{
    partial class Extrusions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extrusions));
            this.extrusionColor = new System.Windows.Forms.ComboBox();
            this.Finish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extrusionColor
            // 
            this.extrusionColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extrusionColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrusionColor.Items.AddRange(new object[] {
            "White",
            "Brown",
            "Black",
            "Galvanised"});
            this.extrusionColor.Location = new System.Drawing.Point(720, 176);
            this.extrusionColor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.extrusionColor.Name = "extrusionColor";
            this.extrusionColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.extrusionColor.Size = new System.Drawing.Size(167, 39);
            this.extrusionColor.TabIndex = 14;
            this.extrusionColor.SelectedIndexChanged += new System.EventHandler(this.extrusionColor_SelectedIndexChanged);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Silver;
            this.Finish.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.Color.Black;
            this.Finish.Location = new System.Drawing.Point(1127, 518);
            this.Finish.Margin = new System.Windows.Forms.Padding(4);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(233, 98);
            this.Finish.TabIndex = 19;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(55, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 98);
            this.button1.TabIndex = 20;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Extrusions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.extrusionColor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Extrusions";
            this.Size = new System.Drawing.Size(1403, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox extrusionColor;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button button1;
    }
}
