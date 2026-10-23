namespace Rock_paper_scissors_game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChoiceWiner = new System.Windows.Forms.Label();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.imgLIconsPlay = new System.Windows.Forms.ImageList(this.components);
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblChoiceWiner);
            this.panel1.Location = new System.Drawing.Point(90, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 72);
            this.panel1.TabIndex = 0;
            // 
            // lblChoiceWiner
            // 
            this.lblChoiceWiner.AutoSize = true;
            this.lblChoiceWiner.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoiceWiner.ForeColor = System.Drawing.Color.Green;
            this.lblChoiceWiner.Location = new System.Drawing.Point(148, 15);
            this.lblChoiceWiner.Name = "lblChoiceWiner";
            this.lblChoiceWiner.Size = new System.Drawing.Size(0, 34);
            this.lblChoiceWiner.TabIndex = 0;
            // 
            // pbComputer
            // 
            this.pbComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbComputer.Image = global::Rock_paper_scissors_game.Properties.Resources.question_mark;
            this.pbComputer.Location = new System.Drawing.Point(268, 12);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(159, 179);
            this.pbComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputer.TabIndex = 1;
            this.pbComputer.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer.Image = global::Rock_paper_scissors_game.Properties.Resources.question_mark;
            this.pbPlayer.Location = new System.Drawing.Point(266, 364);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(159, 179);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // imgLIconsPlay
            // 
            this.imgLIconsPlay.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLIconsPlay.ImageStream")));
            this.imgLIconsPlay.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLIconsPlay.Images.SetKeyName(0, "hand.png");
            this.imgLIconsPlay.Images.SetKeyName(1, "scisseor.png");
            this.imgLIconsPlay.Images.SetKeyName(2, "rock(1).png");
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaper.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaper.ImageIndex = 0;
            this.btnPaper.ImageList = this.imgLIconsPlay;
            this.btnPaper.Location = new System.Drawing.Point(95, 616);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(123, 139);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Tag = "paper";
            this.btnPaper.Text = "paper";
            this.btnPaper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnScissors.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnScissors.ImageIndex = 1;
            this.btnScissors.ImageList = this.imgLIconsPlay;
            this.btnScissors.Location = new System.Drawing.Point(277, 616);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(123, 139);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Tag = "scissor";
            this.btnScissors.Text = "scissor";
            this.btnScissors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScissors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRock.ImageIndex = 2;
            this.btnRock.ImageList = this.imgLIconsPlay;
            this.btnRock.Location = new System.Drawing.Point(463, 616);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(123, 139);
            this.btnRock.TabIndex = 2;
            this.btnRock.Tag = "rock";
            this.btnRock.Text = "rock";
            this.btnRock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Score = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(301, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(280, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Computer";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(421, 571);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(30, 34);
            this.lblScore.TabIndex = 5;
            this.lblScore.Tag = "0";
            this.lblScore.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnReset.Location = new System.Drawing.Point(61, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 66);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(685, 767);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Tag = "Form1";
            this.Text = "Game Paper-scissor-Rock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.ImageList imgLIconsPlay;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChoiceWiner;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
    }
}

