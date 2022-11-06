namespace Real_estate_project
{
    partial class AgentMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentMainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProperty);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnAgent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 453);
            this.panel1.TabIndex = 0;
            // 
            // btnProperty
            // 
            this.btnProperty.BackColor = System.Drawing.Color.Transparent;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperty.ForeColor = System.Drawing.Color.White;
            this.btnProperty.Location = new System.Drawing.Point(0, 267);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(182, 47);
            this.btnProperty.TabIndex = 3;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = false;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(0, 214);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(182, 47);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.BackColor = System.Drawing.Color.Transparent;
            this.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgent.ForeColor = System.Drawing.Color.White;
            this.btnAgent.Location = new System.Drawing.Point(0, 161);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(182, 47);
            this.btnAgent.TabIndex = 1;
            this.btnAgent.Text = "Agent";
            this.btnAgent.UseVisualStyleBackColor = false;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(179, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(799, 452);
            this.mainpanel.TabIndex = 1;
            // 
            // AgentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Name = "AgentMainPage";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAgent;
    }
}