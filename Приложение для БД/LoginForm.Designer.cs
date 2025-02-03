namespace Приложение_для_БД
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            loginField = new TextBox();
            pictureBox2 = new PictureBox();
            passField = new TextBox();
            button1 = new Button();
            closebutton = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(130, 114);
            loginField.Name = "loginField";
            loginField.Size = new Size(299, 52);
            loginField.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 212);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // passField
            // 
            passField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passField.Location = new Point(130, 212);
            passField.Name = "passField";
            passField.Size = new Size(299, 56);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(180, 314);
            button1.Name = "button1";
            button1.Size = new Size(141, 41);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // closebutton
            // 
            closebutton.AutoSize = true;
            closebutton.BackColor = Color.Transparent;
            closebutton.Cursor = Cursors.Hand;
            closebutton.FlatStyle = FlatStyle.Flat;
            closebutton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closebutton.Location = new Point(474, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(26, 27);
            closebutton.TabIndex = 1;
            closebutton.Text = "X";
            closebutton.Click += closebutton_Click;
            closebutton.MouseEnter += closebutton_MouseEnter;
            closebutton.MouseLeave += closebutton_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(194, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(201, 84);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 153, 225);
            panel1.Controls.Add(closebutton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(46, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 372);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("SimSun-ExtB", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 103);
            label1.TabIndex = 6;
            label1.Text = "Authorization";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(591, 486);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm2";
            MouseDown += LoginForm_MouseDown;
            MouseMove += LoginForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox loginField;
        private PictureBox pictureBox2;
        private TextBox passField;
        private Button button1;
        private Label closebutton;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label1;
    }
}