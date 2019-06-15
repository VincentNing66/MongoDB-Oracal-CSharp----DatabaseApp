namespace WindowsFormsApp1
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
            this.leftPan = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SearchPlayer = new System.Windows.Forms.Button();
            this.SearchTeam = new System.Windows.Forms.Button();
            this.SearchGame = new System.Windows.Forms.Button();
            this.logoPan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.showPanGame = new System.Windows.Forms.Panel();
            this.text4 = new System.Windows.Forms.Label();
            this.text4_r = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text1_r = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.text3_r = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text2_r = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HeadText = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.leftPan.SuspendLayout();
            this.logoPan.SuspendLayout();
            this.showPanGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPan
            // 
            this.leftPan.Controls.Add(this.QuitBtn);
            this.leftPan.Controls.Add(this.SearchPlayer);
            this.leftPan.Controls.Add(this.SearchTeam);
            this.leftPan.Controls.Add(this.SearchGame);
            this.leftPan.Controls.Add(this.logoPan);
            this.leftPan.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPan.Location = new System.Drawing.Point(0, 0);
            this.leftPan.Name = "leftPan";
            this.leftPan.Size = new System.Drawing.Size(200, 450);
            this.leftPan.TabIndex = 0;
            // 
            // QuitBtn
            // 
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.Location = new System.Drawing.Point(0, 337);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(200, 71);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // SearchPlayer
            // 
            this.SearchPlayer.FlatAppearance.BorderSize = 0;
            this.SearchPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPlayer.Location = new System.Drawing.Point(0, 260);
            this.SearchPlayer.Name = "SearchPlayer";
            this.SearchPlayer.Size = new System.Drawing.Size(200, 71);
            this.SearchPlayer.TabIndex = 3;
            this.SearchPlayer.Text = "Search Player";
            this.SearchPlayer.UseVisualStyleBackColor = true;
            this.SearchPlayer.Click += new System.EventHandler(this.SearchPlayer_Click);
            // 
            // SearchTeam
            // 
            this.SearchTeam.FlatAppearance.BorderSize = 0;
            this.SearchTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchTeam.Location = new System.Drawing.Point(0, 183);
            this.SearchTeam.Name = "SearchTeam";
            this.SearchTeam.Size = new System.Drawing.Size(200, 71);
            this.SearchTeam.TabIndex = 2;
            this.SearchTeam.Text = "Search Team";
            this.SearchTeam.UseVisualStyleBackColor = true;
            this.SearchTeam.Click += new System.EventHandler(this.SearchTeam_Click);
            // 
            // SearchGame
            // 
            this.SearchGame.FlatAppearance.BorderSize = 0;
            this.SearchGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchGame.Location = new System.Drawing.Point(0, 106);
            this.SearchGame.Name = "SearchGame";
            this.SearchGame.Size = new System.Drawing.Size(200, 71);
            this.SearchGame.TabIndex = 1;
            this.SearchGame.Text = "Search Game";
            this.SearchGame.UseVisualStyleBackColor = true;
            this.SearchGame.Click += new System.EventHandler(this.SearchGame_Click);
            // 
            // logoPan
            // 
            this.logoPan.BackColor = System.Drawing.Color.Turquoise;
            this.logoPan.Controls.Add(this.label1);
            this.logoPan.Controls.Add(this.logo);
            this.logoPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPan.Location = new System.Drawing.Point(0, 0);
            this.logoPan.Name = "logoPan";
            this.logoPan.Size = new System.Drawing.Size(200, 100);
            this.logoPan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(160, 77);
            this.logo.TabIndex = 0;
            this.logo.Text = "VAL";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPanGame
            // 
            this.showPanGame.Controls.Add(this.text4);
            this.showPanGame.Controls.Add(this.text4_r);
            this.showPanGame.Controls.Add(this.text1);
            this.showPanGame.Controls.Add(this.text1_r);
            this.showPanGame.Controls.Add(this.text3);
            this.showPanGame.Controls.Add(this.text3_r);
            this.showPanGame.Controls.Add(this.text2);
            this.showPanGame.Controls.Add(this.text2_r);
            this.showPanGame.Location = new System.Drawing.Point(200, 242);
            this.showPanGame.Name = "showPanGame";
            this.showPanGame.Size = new System.Drawing.Size(600, 208);
            this.showPanGame.TabIndex = 3;
            this.showPanGame.Paint += new System.Windows.Forms.PaintEventHandler(this.showPanGame_Paint);
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Location = new System.Drawing.Point(130, 119);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(0, 22);
            this.text4.TabIndex = 5;
            this.text4.Visible = false;
            this.text4.Click += new System.EventHandler(this.gamePlatform_Click);
            // 
            // text4_r
            // 
            this.text4_r.AutoSize = true;
            this.text4_r.Location = new System.Drawing.Point(314, 119);
            this.text4_r.Name = "text4_r";
            this.text4_r.Size = new System.Drawing.Size(0, 22);
            this.text4_r.TabIndex = 8;
            this.text4_r.Visible = false;
            this.text4_r.Click += new System.EventHandler(this.gamePlatform_r_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(130, 18);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(0, 22);
            this.text1.TabIndex = 4;
            this.text1.Visible = false;
            this.text1.Click += new System.EventHandler(this.gameDeveloper_Click);
            // 
            // text1_r
            // 
            this.text1_r.AutoSize = true;
            this.text1_r.Location = new System.Drawing.Point(314, 18);
            this.text1_r.Name = "text1_r";
            this.text1_r.Size = new System.Drawing.Size(0, 22);
            this.text1_r.TabIndex = 9;
            this.text1_r.Visible = false;
            this.text1_r.Click += new System.EventHandler(this.gameDeveloper_r_Click);
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Location = new System.Drawing.Point(130, 84);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(0, 22);
            this.text3.TabIndex = 2;
            this.text3.Visible = false;
            this.text3.Click += new System.EventHandler(this.gameId_Click);
            // 
            // text3_r
            // 
            this.text3_r.AutoSize = true;
            this.text3_r.Location = new System.Drawing.Point(314, 84);
            this.text3_r.Name = "text3_r";
            this.text3_r.Size = new System.Drawing.Size(0, 22);
            this.text3_r.TabIndex = 7;
            this.text3_r.Visible = false;
            this.text3_r.Click += new System.EventHandler(this.gameId_r_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(130, 52);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(0, 22);
            this.text2.TabIndex = 1;
            this.text2.Visible = false;
            this.text2.Click += new System.EventHandler(this.gameName_Click);
            // 
            // text2_r
            // 
            this.text2_r.AutoSize = true;
            this.text2_r.Location = new System.Drawing.Point(314, 52);
            this.text2_r.Name = "text2_r";
            this.text2_r.Size = new System.Drawing.Size(0, 22);
            this.text2_r.TabIndex = 6;
            this.text2_r.Visible = false;
            this.text2_r.Click += new System.EventHandler(this.gameName_r_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HeadText
            // 
            this.HeadText.AutoSize = true;
            this.HeadText.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.Location = new System.Drawing.Point(230, 44);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(0, 34);
            this.HeadText.TabIndex = 3;
            this.HeadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadText.Click += new System.EventHandler(this.HeadText_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(454, 172);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(108, 41);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Visible = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.HeadText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showPanGame);
            this.Controls.Add(this.leftPan);
            this.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPan.ResumeLayout(false);
            this.logoPan.ResumeLayout(false);
            this.logoPan.PerformLayout();
            this.showPanGame.ResumeLayout(false);
            this.showPanGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPan;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button SearchPlayer;
        private System.Windows.Forms.Button SearchTeam;
        private System.Windows.Forms.Button SearchGame;
        private System.Windows.Forms.Panel logoPan;
        private System.Windows.Forms.Panel showPanGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text1_r;
        private System.Windows.Forms.Label text4_r;
        private System.Windows.Forms.Label text3_r;
        private System.Windows.Forms.Label text2_r;
    }
}

