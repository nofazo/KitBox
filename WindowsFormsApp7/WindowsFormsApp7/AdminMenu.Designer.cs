namespace WindowsFormsApp7
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.AdminAddNewItem = new System.Windows.Forms.Button();
            this.AdminBill = new System.Windows.Forms.Button();
            this.AdminAddITem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminAddNewItem
            // 
            this.AdminAddNewItem.Location = new System.Drawing.Point(158, 329);
            this.AdminAddNewItem.Name = "AdminAddNewItem";
            this.AdminAddNewItem.Size = new System.Drawing.Size(236, 52);
            this.AdminAddNewItem.TabIndex = 0;
            this.AdminAddNewItem.Text = "Add New Item to the store";
            this.AdminAddNewItem.UseVisualStyleBackColor = true;
            this.AdminAddNewItem.Click += new System.EventHandler(this.AdminAddNewItem_Click);
            // 
            // AdminBill
            // 
            this.AdminBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminBill.Location = new System.Drawing.Point(198, 477);
            this.AdminBill.Name = "AdminBill";
            this.AdminBill.Size = new System.Drawing.Size(165, 63);
            this.AdminBill.TabIndex = 3;
            this.AdminBill.Text = "Billing";
            this.AdminBill.UseVisualStyleBackColor = true;
            this.AdminBill.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminAddITem
            // 
            this.AdminAddITem.Location = new System.Drawing.Point(198, 175);
            this.AdminAddITem.Name = "AdminAddITem";
            this.AdminAddITem.Size = new System.Drawing.Size(165, 52);
            this.AdminAddITem.TabIndex = 1;
            this.AdminAddITem.Text = "Database Administration";
            this.AdminAddITem.UseVisualStyleBackColor = true;
            this.AdminAddITem.Click += new System.EventHandler(this.AdminAddITem_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.AdminBill);
            this.Controls.Add(this.AdminAddITem);
            this.Controls.Add(this.AdminAddNewItem);
            this.DoubleBuffered = true;
            this.Name = "AdminMenu";
            this.Size = new System.Drawing.Size(567, 609);
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminAddNewItem;
        private System.Windows.Forms.Button AdminBill;
        private System.Windows.Forms.Button AdminAddITem;
    }
}
