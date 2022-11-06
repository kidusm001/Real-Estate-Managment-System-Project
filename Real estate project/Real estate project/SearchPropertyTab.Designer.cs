namespace Real_estate_project
{
    partial class SearchPropertyTab
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
            this.SearchProp = new System.Windows.Forms.TabPage();
            this.SearchSoldProp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchProp);
            this.tabControl1.Controls.Add(this.SearchSoldProp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SearchProp
            // 
            this.SearchProp.Location = new System.Drawing.Point(4, 22);
            this.SearchProp.Name = "SearchProp";
            this.SearchProp.Padding = new System.Windows.Forms.Padding(3);
            this.SearchProp.Size = new System.Drawing.Size(791, 426);
            this.SearchProp.TabIndex = 0;
            this.SearchProp.Text = "Search Property";
            this.SearchProp.UseVisualStyleBackColor = true;
            // 
            // SearchSoldProp
            // 
            this.SearchSoldProp.Location = new System.Drawing.Point(4, 22);
            this.SearchSoldProp.Name = "SearchSoldProp";
            this.SearchSoldProp.Padding = new System.Windows.Forms.Padding(3);
            this.SearchSoldProp.Size = new System.Drawing.Size(791, 426);
            this.SearchSoldProp.TabIndex = 1;
            this.SearchSoldProp.Text = "Search Sold Property";
            this.SearchSoldProp.UseVisualStyleBackColor = true;
            // 
            // SearchPropertyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchPropertyTab";
            this.Text = "SearchPropertyTab";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchProp;
        private System.Windows.Forms.TabPage SearchSoldProp;
    }
}