namespace Real_estate_project
{
    partial class ShowPropertyTab
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
            this.ShowProp = new System.Windows.Forms.TabPage();
            this.ShowProptobeSold = new System.Windows.Forms.TabPage();
            this.ShowPropByAgent = new System.Windows.Forms.TabPage();
            this.ShowPropByOwner = new System.Windows.Forms.TabPage();
            this.ShowPropType = new System.Windows.Forms.TabPage();
            this.ShowSoldProp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ShowProp);
            this.tabControl1.Controls.Add(this.ShowProptobeSold);
            this.tabControl1.Controls.Add(this.ShowPropByAgent);
            this.tabControl1.Controls.Add(this.ShowPropByOwner);
            this.tabControl1.Controls.Add(this.ShowPropType);
            this.tabControl1.Controls.Add(this.ShowSoldProp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ShowProp
            // 
            this.ShowProp.Location = new System.Drawing.Point(4, 22);
            this.ShowProp.Name = "ShowProp";
            this.ShowProp.Padding = new System.Windows.Forms.Padding(3);
            this.ShowProp.Size = new System.Drawing.Size(791, 426);
            this.ShowProp.TabIndex = 0;
            this.ShowProp.Text = "Show Property";
            this.ShowProp.UseVisualStyleBackColor = true;
            // 
            // ShowProptobeSold
            // 
            this.ShowProptobeSold.Location = new System.Drawing.Point(4, 22);
            this.ShowProptobeSold.Name = "ShowProptobeSold";
            this.ShowProptobeSold.Padding = new System.Windows.Forms.Padding(3);
            this.ShowProptobeSold.Size = new System.Drawing.Size(791, 426);
            this.ShowProptobeSold.TabIndex = 1;
            this.ShowProptobeSold.Text = "Show Property to be Sold";
            this.ShowProptobeSold.UseVisualStyleBackColor = true;
            // 
            // ShowPropByAgent
            // 
            this.ShowPropByAgent.Location = new System.Drawing.Point(4, 22);
            this.ShowPropByAgent.Name = "ShowPropByAgent";
            this.ShowPropByAgent.Size = new System.Drawing.Size(791, 426);
            this.ShowPropByAgent.TabIndex = 2;
            this.ShowPropByAgent.Text = "Show Propert to be sold by Agent";
            this.ShowPropByAgent.UseVisualStyleBackColor = true;
            // 
            // ShowPropByOwner
            // 
            this.ShowPropByOwner.Location = new System.Drawing.Point(4, 22);
            this.ShowPropByOwner.Name = "ShowPropByOwner";
            this.ShowPropByOwner.Size = new System.Drawing.Size(791, 426);
            this.ShowPropByOwner.TabIndex = 3;
            this.ShowPropByOwner.Text = "Show Listed property by Owner ";
            this.ShowPropByOwner.UseVisualStyleBackColor = true;
            // 
            // ShowPropType
            // 
            this.ShowPropType.Location = new System.Drawing.Point(4, 22);
            this.ShowPropType.Name = "ShowPropType";
            this.ShowPropType.Size = new System.Drawing.Size(791, 426);
            this.ShowPropType.TabIndex = 4;
            this.ShowPropType.Text = "Show Property Type";
            this.ShowPropType.UseVisualStyleBackColor = true;
            // 
            // ShowSoldProp
            // 
            this.ShowSoldProp.Location = new System.Drawing.Point(4, 22);
            this.ShowSoldProp.Name = "ShowSoldProp";
            this.ShowSoldProp.Size = new System.Drawing.Size(791, 426);
            this.ShowSoldProp.TabIndex = 5;
            this.ShowSoldProp.Text = "Show Sold Property";
            this.ShowSoldProp.UseVisualStyleBackColor = true;
            // 
            // ShowPropertyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPropertyTab";
            this.Text = "ShowPropertyTab";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShowProp;
        private System.Windows.Forms.TabPage ShowProptobeSold;
        private System.Windows.Forms.TabPage ShowPropByAgent;
        private System.Windows.Forms.TabPage ShowPropByOwner;
        private System.Windows.Forms.TabPage ShowPropType;
        private System.Windows.Forms.TabPage ShowSoldProp;
    }
}