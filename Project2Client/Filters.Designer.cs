namespace Project2Client
{
    partial class Filters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filters));
            this.CloseButton = new System.Windows.Forms.Button();
            this.FiltersCombo = new System.Windows.Forms.ComboBox();
            this.DeleteTagBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchPane = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(305, 214);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(117, 35);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // FiltersCombo
            // 
            this.FiltersCombo.FormattingEnabled = true;
            this.FiltersCombo.Location = new System.Drawing.Point(12, 95);
            this.FiltersCombo.Name = "FiltersCombo";
            this.FiltersCombo.Size = new System.Drawing.Size(410, 26);
            this.FiltersCombo.TabIndex = 5;
            // 
            // DeleteTagBtn
            // 
            this.DeleteTagBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteTagBtn.Enabled = false;
            this.DeleteTagBtn.FlatAppearance.BorderSize = 0;
            this.DeleteTagBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.DeleteTagBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.DeleteTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTagBtn.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTagBtn.Location = new System.Drawing.Point(12, 214);
            this.DeleteTagBtn.Name = "DeleteTagBtn";
            this.DeleteTagBtn.Size = new System.Drawing.Size(117, 35);
            this.DeleteTagBtn.TabIndex = 6;
            this.DeleteTagBtn.Text = "Delete Tag";
            this.DeleteTagBtn.UseVisualStyleBackColor = false;
            this.DeleteTagBtn.Click += new System.EventHandler(this.DeleteTagBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tags & Filters";
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ApplyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.ApplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(182, 214);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(117, 35);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.Text = "Apply Filter";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(57, 138);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(342, 18);
            this.SearchBox.TabIndex = 9;
            // 
            // SearchPane
            // 
            this.SearchPane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchPane.BackColor = System.Drawing.Color.White;
            this.SearchPane.Controls.Add(this.pictureBox1);
            this.SearchPane.Location = new System.Drawing.Point(12, 129);
            this.SearchPane.Name = "SearchPane";
            this.SearchPane.Size = new System.Drawing.Size(410, 35);
            this.SearchPane.TabIndex = 10;
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
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchPane);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteTagBtn);
            this.Controls.Add(this.FiltersCombo);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filters";
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.Filters_Load);
            this.SearchPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox FiltersCombo;
        private System.Windows.Forms.Button DeleteTagBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel SearchPane;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}