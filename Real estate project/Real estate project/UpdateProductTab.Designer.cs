namespace Real_estate_project
{
    partial class UpdateProductTab
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
            this.UpdateProp = new System.Windows.Forms.TabPage();
            this.UpdatePropSellList = new System.Windows.Forms.TabPage();
            this.UpdatePropSellListAgent = new System.Windows.Forms.TabPage();
            this.UpdatePropSellListOwner = new System.Windows.Forms.TabPage();
            this.UpdatePropType = new System.Windows.Forms.TabPage();
            this.UpdateSoldProp = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UpdateProp);
            this.tabControl1.Controls.Add(this.UpdatePropSellList);
            this.tabControl1.Controls.Add(this.UpdatePropSellListAgent);
            this.tabControl1.Controls.Add(this.UpdatePropSellListOwner);
            this.tabControl1.Controls.Add(this.UpdatePropType);
            this.tabControl1.Controls.Add(this.UpdateSoldProp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // UpdateProp
            // 
            this.UpdateProp.Location = new System.Drawing.Point(4, 22);
            this.UpdateProp.Name = "UpdateProp";
            this.UpdateProp.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateProp.Size = new System.Drawing.Size(791, 426);
            this.UpdateProp.TabIndex = 0;
            this.UpdateProp.Text = "Update Property";
            this.UpdateProp.UseVisualStyleBackColor = true;
            // 
            // UpdatePropSellList
            // 
            this.UpdatePropSellList.Location = new System.Drawing.Point(4, 22);
            this.UpdatePropSellList.Name = "UpdatePropSellList";
            this.UpdatePropSellList.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatePropSellList.Size = new System.Drawing.Size(791, 426);
            this.UpdatePropSellList.TabIndex = 1;
            this.UpdatePropSellList.Text = "Update Property To sell List";
            this.UpdatePropSellList.UseVisualStyleBackColor = true;
            // 
            // UpdatePropSellListAgent
            // 
            this.UpdatePropSellListAgent.Location = new System.Drawing.Point(4, 22);
            this.UpdatePropSellListAgent.Name = "UpdatePropSellListAgent";
            this.UpdatePropSellListAgent.Size = new System.Drawing.Size(791, 426);
            this.UpdatePropSellListAgent.TabIndex = 2;
            this.UpdatePropSellListAgent.Text = "Update Agent on Listed Property ";
            this.UpdatePropSellListAgent.UseVisualStyleBackColor = true;
            // 
            // UpdatePropSellListOwner
            // 
            this.UpdatePropSellListOwner.Location = new System.Drawing.Point(4, 22);
            this.UpdatePropSellListOwner.Name = "UpdatePropSellListOwner";
            this.UpdatePropSellListOwner.Size = new System.Drawing.Size(791, 426);
            this.UpdatePropSellListOwner.TabIndex = 3;
            this.UpdatePropSellListOwner.Text = "Update Owner on Listed Property";
            this.UpdatePropSellListOwner.UseVisualStyleBackColor = true;
            // 
            // UpdatePropType
            // 
            this.UpdatePropType.Location = new System.Drawing.Point(4, 22);
            this.UpdatePropType.Name = "UpdatePropType";
            this.UpdatePropType.Size = new System.Drawing.Size(791, 426);
            this.UpdatePropType.TabIndex = 4;
            this.UpdatePropType.Text = "Update Propert Type";
            this.UpdatePropType.UseVisualStyleBackColor = true;
            // 
            // UpdateSoldProp
            // 
            this.UpdateSoldProp.Location = new System.Drawing.Point(4, 22);
            this.UpdateSoldProp.Name = "UpdateSoldProp";
            this.UpdateSoldProp.Size = new System.Drawing.Size(791, 426);
            this.UpdateSoldProp.TabIndex = 5;
            this.UpdateSoldProp.Text = "Update Sold Property";
            this.UpdateSoldProp.UseVisualStyleBackColor = true;
            // 
            // UpdateProductTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateProductTab";
            this.Text = "UpdateProductTab";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UpdateProp;
        private System.Windows.Forms.TabPage UpdatePropSellList;
        private System.Windows.Forms.TabPage UpdatePropSellListAgent;
        private System.Windows.Forms.TabPage UpdatePropSellListOwner;
        private System.Windows.Forms.TabPage UpdatePropType;
        private System.Windows.Forms.TabPage UpdateSoldProp;
    }
}