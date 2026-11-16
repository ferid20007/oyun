namespace panel_oyun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 100);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(311, 28);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 0;
            button1.Text = "Panel yarat";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(451, 28);
            button2.Name = "button2";
            button2.Size = new Size(199, 49);
            button2.TabIndex = 1;
            button2.Text = "bombanin yerini deyis";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Book Antiqua", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button3.Location = new Point(673, 28);
            button3.Name = "button3";
            button3.Size = new Size(112, 49);
            button3.TabIndex = 2;
            button3.Text = "Cixis";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(47, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 24);
            label1.TabIndex = 3;
            label1.Text = "xal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(103, 47);
            label2.Name = "label2";
            label2.Size = new Size(20, 24);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(345, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Panel oyunu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
