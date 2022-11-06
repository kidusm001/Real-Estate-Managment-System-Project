namespace Real_estate_project
{
    partial class DeletePropertyTab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DeleteProp = new System.Windows.Forms.TabPage();
            this.DeletePropType = new System.Windows.Forms.TabPage();
            this.DeleteSoldProp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DeleteProp);
            this.tabControl1.Controls.Add(this.DeletePropType);
            this.tabControl1.Controls.Add(this.DeleteSoldProp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // DeleteProp
            // 
            this.DeleteProp.Location = new System.Drawing.Point(4, 22);
            this.DeleteProp.Name = "DeleteProp";
            this.DeleteProp.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteProp.Size = new System.Drawing.Size(791, 426);
            this.DeleteProp.TabIndex = 0;
            this.DeleteProp.Text = "Delete Property";
            this.DeleteProp.UseVisualStyleBackColor = true;
            // 
            // DeletePropType
            // 
            this.DeletePropType.Location = new System.Drawing.Point(4, 22);
            this.DeletePropType.Name = "DeletePropType";
            this.DeletePropType.Padding = new System.Windows.Forms.Padding(3);
            this.DeletePropType.Size = new System.Drawing.Size(791, 426);
            this.DeletePropType.TabIndex = 1;
            this.DeletePropType.Text = "Delete Property Type";
            this.DeletePropType.UseVisualStyleBackColor = true;
            // 
            // DeleteSoldProp
            // 
            this.DeleteSoldProp.Location = new System.Drawing.Point(4, 22);
            this.DeleteSoldProp.Name = "DeleteSoldProp";
            this.DeleteSoldProp.Size = new System.Drawing.Size(791, 426);
            this.DeleteSoldProp.TabIndex = 2;
            this.DeleteSoldProp.Text = "Delete Sold Property";
            this.DeleteSoldProp.UseVisualStyleBackColor = true;
            // 
            // DeletePropertyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletePropertyTab";
            this.Text = "DeletePropertyTab";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DeleteProp;
        private System.Windows.Forms.TabPage DeletePropType;
        private System.Windows.Forms.TabPage DeleteSoldProp;
    }
}