namespace Project2Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AllMediaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ImageGridFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchPane = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SearchPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.AutoSize = true;
            this.MenuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuPanel.Controls.Add(this.pictureBox2);
            this.MenuPanel.Controls.Add(this.button2);
            this.MenuPanel.Controls.Add(this.AllMediaButton);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.AddImageButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.MaximumSize = new System.Drawing.Size(250, 0);
            this.MenuPanel.MinimumSize = new System.Drawing.Size(250, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(250, 450);
            this.MenuPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(42, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 135);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(217, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apply Filter";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllMediaButton
            // 
            this.AllMediaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllMediaButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AllMediaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AllMediaButton.FlatAppearance.BorderSize = 0;
            this.AllMediaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AllMediaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.AllMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllMediaButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllMediaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllMediaButton.Location = new System.Drawing.Point(16, 94);
            this.AllMediaButton.Name = "AllMediaButton";
            this.AllMediaButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AllMediaButton.Size = new System.Drawing.Size(217, 35);
            this.AllMediaButton.TabIndex = 2;
            this.AllMediaButton.Text = "Load All Media";
            this.AllMediaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllMediaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AllMediaButton.UseVisualStyleBackColor = false;
            this.AllMediaButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album";
            // 
            // AddImageButton
            // 
            this.AddImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddImageButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddImageButton.BackgroundImage = global::Project2Client.Properties.Resources.addicon;
            this.AddImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddImageButton.FlatAppearance.BorderSize = 0;
            this.AddImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.AddImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImageButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddImageButton.Location = new System.Drawing.Point(198, 13);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(35, 35);
            this.AddImageButton.TabIndex = 1;
            this.AddImageButton.UseVisualStyleBackColor = false;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ContentPanel);
            this.panel2.Controls.Add(this.SearchPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 450);
            this.panel2.TabIndex = 1;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.White;
            this.ContentPanel.Controls.Add(this.ImageGridFlow);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 62);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(550, 388);
            this.ContentPanel.TabIndex = 1;
            // 
            // ImageGridFlow
            // 
            this.ImageGridFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageGridFlow.Location = new System.Drawing.Point(0, 0);
            this.ImageGridFlow.Name = "ImageGridFlow";
            this.ImageGridFlow.Size = new System.Drawing.Size(550, 388);
            this.ImageGridFlow.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.White;
            this.SearchPanel.Controls.Add(this.SearchBox);
            this.SearchPanel.Controls.Add(this.SearchPane);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(550, 62);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(64, 21);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(356, 18);
            this.SearchBox.TabIndex = 0;
            // 
            // SearchPane
            // 
            this.SearchPane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchPane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchPane.Controls.Add(this.SearchButton);
            this.SearchPane.Controls.Add(this.pictureBox1);
            this.SearchPane.Location = new System.Drawing.Point(19, 12);
            this.SearchPane.Name = "SearchPane";
            this.SearchPane.Size = new System.Drawing.Size(486, 35);
            this.SearchPane.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(407, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 35);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = " Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.SearchPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel SearchPane;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AllMediaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ImageGridFlow;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

