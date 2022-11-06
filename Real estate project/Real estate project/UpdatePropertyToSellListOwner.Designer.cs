namespace Real_estate_project
{
    partial class UpdatePropertyToSellListOwner
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
            System.Windows.Forms.Button btnUpdateProperty;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePropertyToSellListOwner));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.txtPropertyId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnUpdateProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateProperty
            // 
            btnUpdateProperty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnUpdateProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateProperty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnUpdateProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(186)))), ((int)(((byte)(254)))));
            btnUpdateProperty.Location = new System.Drawing.Point(312, 412);
            btnUpdateProperty.Name = "btnUpdateProperty";
            btnUpdateProperty.Size = new System.Drawing.Size(181, 28);
            btnUpdateProperty.TabIndex = 14;
            btnUpdateProperty.Text = "Update Property";
            btnUpdateProperty.UseVisualStyleBackColor = true;
            btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOwnerId);
            this.panel1.Controls.Add(this.txtPropertyId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 348);
            this.panel1.TabIndex = 1;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.BackColor = System.Drawing.Color.White;
            this.txtOwnerId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerId.Location = new System.Drawing.Point(158, 96);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(184, 27);
            this.txtOwnerId.TabIndex = 10;
            // 
            // txtPropertyId
            // 
            this.txtPropertyId.BackColor = System.Drawing.Color.White;
            this.txtPropertyId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyId.Location = new System.Drawing.Point(158, 41);
            this.txtPropertyId.Name = "txtPropertyId";
            this.txtPropertyId.Size = new System.Drawing.Size(184, 27);
            this.txtPropertyId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Owner ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Property ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Property to For Sell List";
            // 
            // UpdatePropertyToSellListOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(btnUpdateProperty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePropertyToSellListOwner";
            this.Text = "AddClientPage";
            this.Load += new System.EventHandler(this.AddClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.TextBox txtPropertyId;
    }
}