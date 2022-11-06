namespace Real_estate_project
{
    partial class AddPropertyTab
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
            this.AddProperty = new System.Windows.Forms.TabPage();
            this.AddPropToSellList = new System.Windows.Forms.TabPage();
            this.AddPropertyType = new System.Windows.Forms.TabPage();
            this.AddSoldProperty = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddProperty);
            this.tabControl1.Controls.Add(this.AddPropToSellList);
            this.tabControl1.Controls.Add(this.AddPropertyType);
            this.tabControl1.Controls.Add(this.AddSoldProperty);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddProperty
            // 
            this.AddProperty.Location = new System.Drawing.Point(4, 22);
            this.AddProperty.Name = "AddProperty";
            this.AddProperty.Padding = new System.Windows.Forms.Padding(3);
            this.AddProperty.Size = new System.Drawing.Size(791, 426);
            this.AddProperty.TabIndex = 0;
            this.AddProperty.Text = "Add Property";
            this.AddProperty.UseVisualStyleBackColor = true;
            // 
            // AddPropToSellList
            // 
            this.AddPropToSellList.Location = new System.Drawing.Point(4, 22);
            this.AddPropToSellList.Name = "AddPropToSellList";
            this.AddPropToSellList.Padding = new System.Windows.Forms.Padding(3);
            this.AddPropToSellList.Size = new System.Drawing.Size(791, 426);
            this.AddPropToSellList.TabIndex = 1;
            this.AddPropToSellList.Text = "Add Property to Sell List";
            this.AddPropToSellList.UseVisualStyleBackColor = true;
            // 
            // AddPropertyType
            // 
            this.AddPropertyType.Location = new System.Drawing.Point(4, 22);
            this.AddPropertyType.Name = "AddPropertyType";
            this.AddPropertyType.Size = new System.Drawing.Size(791, 426);
            this.AddPropertyType.TabIndex = 2;
            this.AddPropertyType.Text = "Add Property Type";
            this.AddPropertyType.UseVisualStyleBackColor = true;
            // 
            // AddSoldProperty
            // 
            this.AddSoldProperty.Location = new System.Drawing.Point(4, 22);
            this.AddSoldProperty.Name = "AddSoldProperty";
            this.AddSoldProperty.Size = new System.Drawing.Size(791, 426);
            this.AddSoldProperty.TabIndex = 3;
            this.AddSoldProperty.Text = "Add Sold Property";
            this.AddSoldProperty.UseVisualStyleBackColor = true;
            // 
            // AddPropertyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPropertyTab";
            this.Text = "AddPropertyTab";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddProperty;
        private System.Windows.Forms.TabPage AddPropToSellList;
        private System.Windows.Forms.TabPage AddPropertyType;
        private System.Windows.Forms.TabPage AddSoldProperty;
    }
}