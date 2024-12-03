namespace FrameFlip
{
    partial class Form_FrameFlip
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FrameFlip));
            buttonSelectImage = new Button();
            buttonConvert = new Button();
            textBoxInputPath = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonSelectImage
            // 
            buttonSelectImage.Location = new Point(12, 12);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(120, 23);
            buttonSelectImage.TabIndex = 0;
            buttonSelectImage.Text = "Bild auswählen";
            buttonSelectImage.UseVisualStyleBackColor = true;
            buttonSelectImage.Click += buttonSelectImage_Click;
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(12, 41);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(120, 23);
            buttonConvert.TabIndex = 1;
            buttonConvert.Text = "Konvertieren";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // textBoxInputPath
            // 
            textBoxInputPath.Location = new Point(150, 13);
            textBoxInputPath.Name = "textBoxInputPath";
            textBoxInputPath.Size = new Size(330, 23);
            textBoxInputPath.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 4;
            label1.Text = "Zielformat";
            // 
            // Form_FrameFlip
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 111);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBoxInputPath);
            Controls.Add(buttonConvert);
            Controls.Add(buttonSelectImage);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_FrameFlip";
            Text = "FrameFlip";
            Load += Form_FrameFlip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxInputPath;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
