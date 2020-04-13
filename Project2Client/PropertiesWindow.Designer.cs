namespace Project2Client
{
    partial class PropertiesWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.PropertyTreeView = new System.Windows.Forms.TreeView();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TagInputKey = new System.Windows.Forms.TextBox();
            this.AddTagBtn = new System.Windows.Forms.Button();
            this.TagGroup = new System.Windows.Forms.GroupBox();
            this.TagInputValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TagGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Media Properties";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(480, 464);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(117, 35);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenButton.FlatAppearance.BorderSize = 0;
            this.OpenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.OpenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(350, 464);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(124, 35);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open Image";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // PropertyTreeView
            // 
            this.PropertyTreeView.BackColor = System.Drawing.Color.White;
            this.PropertyTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyTreeView.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTreeView.HotTracking = true;
            this.PropertyTreeView.Location = new System.Drawing.Point(16, 55);
            this.PropertyTreeView.Name = "PropertyTreeView";
            this.PropertyTreeView.Size = new System.Drawing.Size(308, 232);
            this.PropertyTreeView.TabIndex = 5;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(352, 55);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(247, 232);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // TagInputKey
            // 
            this.TagInputKey.Location = new System.Drawing.Point(6, 53);
            this.TagInputKey.Name = "TagInputKey";
            this.TagInputKey.Size = new System.Drawing.Size(306, 20);
            this.TagInputKey.TabIndex = 7;
            // 
            // AddTagBtn
            // 
            this.AddTagBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddTagBtn.FlatAppearance.BorderSize = 0;
            this.AddTagBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AddTagBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AddTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTagBtn.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTagBtn.Location = new System.Drawing.Point(4, 101);
            this.AddTagBtn.Name = "AddTagBtn";
            this.AddTagBtn.Size = new System.Drawing.Size(124, 35);
            this.AddTagBtn.TabIndex = 8;
            this.AddTagBtn.Text = "Add Tag";
            this.AddTagBtn.UseVisualStyleBackColor = false;
            this.AddTagBtn.Click += new System.EventHandler(this.AddTagBtn_Click);
            // 
            // TagGroup
            // 
            this.TagGroup.Controls.Add(this.AddTagBtn);
            this.TagGroup.Controls.Add(this.label3);
            this.TagGroup.Controls.Add(this.label2);
            this.TagGroup.Controls.Add(this.TagInputValue);
            this.TagGroup.Controls.Add(this.TagInputKey);
            this.TagGroup.Location = new System.Drawing.Point(12, 292);
            this.TagGroup.Name = "TagGroup";
            this.TagGroup.Size = new System.Drawing.Size(587, 142);
            this.TagGroup.TabIndex = 9;
            this.TagGroup.TabStop = false;
            this.TagGroup.Text = "Tags";
            // 
            // TagInputValue
            // 
            this.TagInputValue.Location = new System.Drawing.Point(340, 53);
            this.TagInputValue.Name = "TagInputValue";
            this.TagInputValue.Size = new System.Drawing.Size(241, 20);
            this.TagInputValue.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tag Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tag Value";
            // 
            // PropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 511);
            this.Controls.Add(this.PropertyTreeView);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TagGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PropertiesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TagGroup.ResumeLayout(false);
            this.TagGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TreeView PropertyTreeView;
        private System.Windows.Forms.TextBox TagInputKey;
        private System.Windows.Forms.Button AddTagBtn;
        private System.Windows.Forms.GroupBox TagGroup;
        private System.Windows.Forms.TextBox TagInputValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}