namespace Real_estate_project
{
    partial class UpdatePropertyToSellList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePropertyToSellList));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxAvail = new System.Windows.Forms.GroupBox();
            this.rbtnUnavailable = new System.Windows.Forms.RadioButton();
            this.rbtnAvailable = new System.Windows.Forms.RadioButton();
            this.txtAgentId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.txtPropertyId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnUpdateProperty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxAvail.SuspendLayout();
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
            this.panel1.Controls.Add(this.groupBoxAvail);
            this.panel1.Controls.Add(this.txtAgentId);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtOwnerId);
            this.panel1.Controls.Add(this.txtPropertyId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 348);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxAvail
            // 
            this.groupBoxAvail.Controls.Add(this.rbtnUnavailable);
            this.groupBoxAvail.Controls.Add(this.rbtnAvailable);
            this.groupBoxAvail.Location = new System.Drawing.Point(165, 74);
            this.groupBoxAvail.Name = "groupBoxAvail";
            this.groupBoxAvail.Size = new System.Drawing.Size(177, 60);
            this.groupBoxAvail.TabIndex = 17;
            this.groupBoxAvail.TabStop = false;
            // 
            // rbtnUnavailable
            // 
            this.rbtnUnavailable.AutoSize = true;
            this.rbtnUnavailable.Location = new System.Drawing.Point(22, 37);
            this.rbtnUnavailable.Name = "rbtnUnavailable";
            this.rbtnUnavailable.Size = new System.Drawing.Size(81, 17);
            this.rbtnUnavailable.TabIndex = 1;
            this.rbtnUnavailable.TabStop = true;
            this.rbtnUnavailable.Text = "Unavailable";
            this.rbtnUnavailable.UseVisualStyleBackColor = true;
            // 
            // rbtnAvailable
            // 
            this.rbtnAvailable.AutoSize = true;
            this.rbtnAvailable.Location = new System.Drawing.Point(22, 14);
            this.rbtnAvailable.Name = "rbtnAvailable";
            this.rbtnAvailable.Size = new System.Drawing.Size(68, 17);
            this.rbtnAvailable.TabIndex = 0;
            this.rbtnAvailable.TabStop = true;
            this.rbtnAvailable.Text = "Available";
            this.rbtnAvailable.UseVisualStyleBackColor = true;
            // 
            // txtAgentId
            // 
            this.txtAgentId.BackColor = System.Drawing.Color.White;
            this.txtAgentId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentId.Location = new System.Drawing.Point(158, 207);
            this.txtAgentId.Name = "txtAgentId";
            this.txtAgentId.Size = new System.Drawing.Size(184, 27);
            this.txtAgentId.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(158, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 27);
            this.txtPrice.TabIndex = 15;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.BackColor = System.Drawing.Color.White;
            this.txtOwnerId.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerId.Location = new System.Drawing.Point(158, 173);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Agent ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available for sell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 181);
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
            // UpdatePropertyToSellList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(btnUpdateProperty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePropertyToSellList";
            this.Text = "AddClientPage";
            this.Load += new System.EventHandler(this.AddClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxAvail.ResumeLayout(false);
            this.groupBoxAvail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.TextBox txtPropertyId;
        private System.Windows.Forms.TextBox txtAgentId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBoxAvail;
        private System.Windows.Forms.RadioButton rbtnUnavailable;
        private System.Windows.Forms.RadioButton rbtnAvailable;
    }
}