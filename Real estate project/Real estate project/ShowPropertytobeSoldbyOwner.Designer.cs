namespace Real_estate_project
{
    partial class ShowPropertytobeSoldbyOwner
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
            System.Windows.Forms.Button btnShowbyOwnerId;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPropertytobeSoldbyOwner));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.DisplayPropertytobesoldView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            btnShowbyOwnerId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPropertytobesoldView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowbyOwnerId
            // 
            btnShowbyOwnerId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnShowbyOwnerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowbyOwnerId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnShowbyOwnerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(186)))), ((int)(((byte)(254)))));
            btnShowbyOwnerId.Location = new System.Drawing.Point(97, 7);
            btnShowbyOwnerId.Name = "btnShowbyOwnerId";
            btnShowbyOwnerId.Size = new System.Drawing.Size(209, 33);
            btnShowbyOwnerId.TabIndex = 15;
            btnShowbyOwnerId.Text = "Show by Owner ID";
            btnShowbyOwnerId.UseVisualStyleBackColor = true;
            btnShowbyOwnerId.Click += new System.EventHandler(this.btnShowbyOwnerId_Click);
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
            this.panel1.Controls.Add(this.txtOwnerID);
            this.panel1.Controls.Add(this.DisplayPropertytobesoldView);
            this.panel1.Controls.Add(btnShowbyOwnerId);
            this.panel1.Location = new System.Drawing.Point(72, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 387);
            this.panel1.TabIndex = 1;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.BackColor = System.Drawing.Color.White;
            this.txtOwnerID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerID.Location = new System.Drawing.Point(324, 11);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(164, 27);
            this.txtOwnerID.TabIndex = 17;
            // 
            // DisplayPropertytobesoldView
            // 
            this.DisplayPropertytobesoldView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DisplayPropertytobesoldView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPropertytobesoldView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayPropertytobesoldView.Location = new System.Drawing.Point(0, 42);
            this.DisplayPropertytobesoldView.Name = "DisplayPropertytobesoldView";
            this.DisplayPropertytobesoldView.Size = new System.Drawing.Size(664, 342);
            this.DisplayPropertytobesoldView.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display Property To be sold";
            // 
            // ShowPropertytobeSoldbyOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPropertytobeSoldbyOwner";
            this.Text = "AddClientPage";
            this.Load += new System.EventHandler(this.AddClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPropertytobesoldView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DisplayPropertytobesoldView;
        private System.Windows.Forms.TextBox txtOwnerID;
    }
}