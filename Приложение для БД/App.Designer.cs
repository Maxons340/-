namespace Приложение_для_БД
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            panel1 = new Panel();
            dataGrid = new DataGridView();
            Game = new Button();
            ThePlatform = new Button();
            GameReferee = new Button();
            PersonalMeeting = new Button();
            Referee = new Button();
            Team = new Button();
            HoldContests = new Button();
            TeamPlayers = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            AppCloseButton = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGrid);
            panel1.Controls.Add(Game);
            panel1.Controls.Add(ThePlatform);
            panel1.Controls.Add(GameReferee);
            panel1.Controls.Add(PersonalMeeting);
            panel1.Controls.Add(Referee);
            panel1.Controls.Add(Team);
            panel1.Controls.Add(HoldContests);
            panel1.Controls.Add(TeamPlayers);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AppCloseButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 450);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.BackgroundColor = Color.FromArgb(51, 153, 225);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(0, 79);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.Size = new Size(967, 371);
            dataGrid.TabIndex = 14;
            // 
            // Game
            // 
            Game.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Game.Location = new Point(388, 42);
            Game.Name = "Game";
            Game.Size = new Size(169, 23);
            Game.TabIndex = 12;
            Game.Text = "Game";
            Game.UseVisualStyleBackColor = true;
            Game.Click += Open_Table;
            // 
            // ThePlatform
            // 
            ThePlatform.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThePlatform.Location = new Point(563, 42);
            ThePlatform.Name = "ThePlatform";
            ThePlatform.Size = new Size(169, 23);
            ThePlatform.TabIndex = 11;
            ThePlatform.Text = "Platform";
            ThePlatform.UseVisualStyleBackColor = true;
            ThePlatform.Click += Open_Table;
            // 
            // GameReferee
            // 
            GameReferee.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameReferee.Location = new Point(738, 42);
            GameReferee.Name = "GameReferee";
            GameReferee.Size = new Size(169, 23);
            GameReferee.TabIndex = 7;
            GameReferee.Text = "Game referee";
            GameReferee.UseVisualStyleBackColor = true;
            GameReferee.Click += Open_Table;
            // 
            // PersonalMeeting
            // 
            PersonalMeeting.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PersonalMeeting.Location = new Point(388, 12);
            PersonalMeeting.Name = "PersonalMeeting";
            PersonalMeeting.Size = new Size(169, 24);
            PersonalMeeting.TabIndex = 9;
            PersonalMeeting.Text = "Personal meeting";
            PersonalMeeting.UseVisualStyleBackColor = true;
            PersonalMeeting.Click += Open_Table;
            // 
            // Referee
            // 
            Referee.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Referee.Location = new Point(738, 12);
            Referee.Name = "Referee";
            Referee.Size = new Size(169, 23);
            Referee.TabIndex = 13;
            Referee.Text = "Referee";
            Referee.UseVisualStyleBackColor = true;
            Referee.Click += Open_Table;
            // 
            // Team
            // 
            Team.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Team.Location = new Point(213, 42);
            Team.Name = "Team";
            Team.Size = new Size(169, 23);
            Team.TabIndex = 8;
            Team.Text = "Team";
            Team.UseVisualStyleBackColor = true;
            Team.Click += Open_Table;
            // 
            // HoldContests
            // 
            HoldContests.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoldContests.Location = new Point(563, 12);
            HoldContests.Name = "HoldContests";
            HoldContests.Size = new Size(169, 23);
            HoldContests.TabIndex = 10;
            HoldContests.Text = "Tournament";
            HoldContests.UseVisualStyleBackColor = true;
            HoldContests.Click += Open_Table;
            // 
            // TeamPlayers
            // 
            TeamPlayers.Font = new Font("SimSun-ExtB", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamPlayers.Location = new Point(213, 12);
            TeamPlayers.Name = "TeamPlayers";
            TeamPlayers.Size = new Size(169, 24);
            TeamPlayers.TabIndex = 7;
            TeamPlayers.Text = "Team Players";
            TeamPlayers.UseVisualStyleBackColor = true;
            TeamPlayers.Click += Open_Table;
            // 
            // label2
            // 
            label2.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 27);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Tables";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AppCloseButton
            // 
            AppCloseButton.AutoSize = true;
            AppCloseButton.Cursor = Cursors.Hand;
            AppCloseButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AppCloseButton.Location = new Point(941, 0);
            AppCloseButton.Name = "AppCloseButton";
            AppCloseButton.Size = new Size(26, 26);
            AppCloseButton.TabIndex = 0;
            AppCloseButton.Text = "X";
            AppCloseButton.Click += AppCloseButton_Click;
            AppCloseButton.MouseEnter += AppCloseButton_MouseEnter;
            AppCloseButton.MouseLeave += AppCloseButton_MouseLeave;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "App";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AppCloseButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Button GameReferee;
        private Button Game;
        private Button ThePlatform;
        private Button HoldContests;
        private Button PersonalMeeting;
        private Button Team;
        private Button TeamPlayers;
        private Button Referee;
        private DataGridView dataGrid;
    }
}
