namespace Real_estate_project
{
    partial class ShowPropertyType
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
            System.Windows.Forms.Button btnShowbyId;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPropertyType));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayPropTypeView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            btnShowbyId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPropTypeView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowbyId
            // 
            btnShowbyId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnShowbyId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowbyId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnShowbyId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(186)))), ((int)(((byte)(254)))));
            btnShowbyId.Location = new System.Drawing.Point(287, 3);
            btnShowbyId.Name = "btnShowbyId";
            btnShowbyId.Size = new System.Drawing.Size(112, 33);
            btnShowbyId.TabIndex = 14;
            btnShowbyId.Text = "Show by ID";
            btnShowbyId.UseVisualStyleBackColor = true;
            btnShowbyId.Click += new System.EventHandler(this.btnShowbyId_Click);
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
            this.panel1.Controls.Add(this.DisplayPropTypeView);
            this.panel1.Controls.Add(btnShowbyId);
            this.panel1.Location = new System.Drawing.Point(72, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 387);
            this.panel1.TabIndex = 1;
            // 
            // DisplayPropTypeView
            // 
            this.DisplayPropTypeView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DisplayPropTypeView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPropTypeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayPropTypeView.Location = new System.Drawing.Point(0, 42);
            this.DisplayPropTypeView.Name = "DisplayPropTypeView";
            this.DisplayPropTypeView.Size = new System.Drawing.Size(664, 342);
            this.DisplayPropTypeView.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display Property type";
            // 
            // ShowPropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPropertyType";
            this.Text = "AddClientPage";
            this.Load += new System.EventHandler(this.AddClientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPropTypeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DisplayPropTypeView;
    }
}