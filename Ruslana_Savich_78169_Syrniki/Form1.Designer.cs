namespace Ruslana_Savich_78169_Syrniki
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
            picPlayer1 = new PictureBox();
            grpPlayer1 = new GroupBox();
            lblPoints1 = new Label();
            point1 = new Label();
            grpPlayer2 = new GroupBox();
            lblPoints2 = new Label();
            point2 = new Label();
            picPlayer2 = new PictureBox();
            btnStart = new Button();
            label1 = new Label();
            grpInit = new GroupBox();
            txtName2 = new TextBox();
            lblName2 = new Label();
            txtName1 = new TextBox();
            lblName1 = new Label();
            nudRounds = new NumericUpDown();
            lblRounds = new Label();
            grpAction = new GroupBox();
            picDice = new PictureBox();
            btnRoll = new Button();
            lblTurn = new Label();
            label2 = new Label();
            lblRound = new Label();
            grpAvatars = new GroupBox();
            btnReset = new Button();
            btnSetup2 = new Button();
            btnSetup1 = new Button();
            rbAvatar4 = new RadioButton();
            picAvatarOpt4 = new PictureBox();
            rbAvatar3 = new RadioButton();
            picAvatarOpt3 = new PictureBox();
            rbAvatar2 = new RadioButton();
            picAvatarOpt2 = new PictureBox();
            rbAvatar1 = new RadioButton();
            picAvatarOpt1 = new PictureBox();
            grpReport = new GroupBox();
            lstReport = new ListBox();
            btnShowResult = new Button();
            ((System.ComponentModel.ISupportInitialize)picPlayer1).BeginInit();
            grpPlayer1.SuspendLayout();
            grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer2).BeginInit();
            grpInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRounds).BeginInit();
            grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDice).BeginInit();
            grpAvatars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt1).BeginInit();
            grpReport.SuspendLayout();
            SuspendLayout();
            // 
            // picPlayer1
            // 
            picPlayer1.Image = (Image)resources.GetObject("picPlayer1.Image");
            picPlayer1.Location = new Point(22, 49);
            picPlayer1.Name = "picPlayer1";
            picPlayer1.Size = new Size(129, 133);
            picPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer1.TabIndex = 0;
            picPlayer1.TabStop = false;
            picPlayer1.Click += pictureBox1_Click;
            // 
            // grpPlayer1
            // 
            grpPlayer1.Controls.Add(lblPoints1);
            grpPlayer1.Controls.Add(point1);
            grpPlayer1.Controls.Add(picPlayer1);
            grpPlayer1.Location = new Point(573, 47);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Size = new Size(365, 212);
            grpPlayer1.TabIndex = 3;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "First player";
            // 
            // lblPoints1
            // 
            lblPoints1.AutoSize = true;
            lblPoints1.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPoints1.Location = new Point(233, 91);
            lblPoints1.Name = "lblPoints1";
            lblPoints1.Size = new Size(59, 67);
            lblPoints1.TabIndex = 2;
            lblPoints1.Text = "0";
            lblPoints1.Click += lblpoint1_Click;
            // 
            // point1
            // 
            point1.AutoSize = true;
            point1.Location = new Point(240, 49);
            point1.Name = "point1";
            point1.Size = new Size(42, 20);
            point1.TabIndex = 1;
            point1.Text = "Point";
            point1.Click += label1_Click;
            // 
            // grpPlayer2
            // 
            grpPlayer2.Controls.Add(lblPoints2);
            grpPlayer2.Controls.Add(point2);
            grpPlayer2.Controls.Add(picPlayer2);
            grpPlayer2.Location = new Point(573, 282);
            grpPlayer2.Name = "grpPlayer2";
            grpPlayer2.Size = new Size(365, 212);
            grpPlayer2.TabIndex = 4;
            grpPlayer2.TabStop = false;
            grpPlayer2.Text = "Second player";
            grpPlayer2.Enter += groupBox2_Enter;
            // 
            // lblPoints2
            // 
            lblPoints2.AutoSize = true;
            lblPoints2.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPoints2.Location = new Point(233, 90);
            lblPoints2.Name = "lblPoints2";
            lblPoints2.Size = new Size(59, 67);
            lblPoints2.TabIndex = 2;
            lblPoints2.Text = "0";
            lblPoints2.Click += lblpoint2_Click;
            // 
            // point2
            // 
            point2.AutoSize = true;
            point2.Location = new Point(240, 49);
            point2.Name = "point2";
            point2.Size = new Size(42, 20);
            point2.TabIndex = 1;
            point2.Text = "Point";
            // 
            // picPlayer2
            // 
            picPlayer2.Image = (Image)resources.GetObject("picPlayer2.Image");
            picPlayer2.InitialImage = null;
            picPlayer2.Location = new Point(22, 49);
            picPlayer2.Name = "picPlayer2";
            picPlayer2.Size = new Size(129, 133);
            picPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer2.TabIndex = 0;
            picPlayer2.TabStop = false;
            picPlayer2.WaitOnLoad = true;
            // 
            // btnStart
            // 
            btnStart.ForeColor = SystemColors.ActiveCaptionText;
            btnStart.Location = new Point(573, 522);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(365, 109);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(391, 49);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            label1.Click += label1_Click_1;
            // 
            // grpInit
            // 
            grpInit.Controls.Add(txtName2);
            grpInit.Controls.Add(lblName2);
            grpInit.Controls.Add(txtName1);
            grpInit.Controls.Add(lblName1);
            grpInit.Controls.Add(nudRounds);
            grpInit.Controls.Add(lblRounds);
            grpInit.Location = new Point(14, 47);
            grpInit.Name = "grpInit";
            grpInit.Size = new Size(315, 232);
            grpInit.TabIndex = 0;
            grpInit.TabStop = false;
            grpInit.Text = "Initializations";
            // 
            // txtName2
            // 
            txtName2.Location = new Point(17, 176);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(209, 27);
            txtName2.TabIndex = 5;
            txtName2.TextChanged += TxtName_TextChanged;
            // 
            // lblName2
            // 
            lblName2.AutoSize = true;
            lblName2.Location = new Point(17, 153);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(144, 20);
            lblName2.TabIndex = 6;
            lblName2.Text = "Second player name";
            // 
            // txtName1
            // 
            txtName1.Location = new Point(17, 111);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(209, 27);
            txtName1.TabIndex = 3;
            txtName1.TextChanged += TxtName_TextChanged;
            // 
            // lblName1
            // 
            lblName1.AutoSize = true;
            lblName1.Location = new Point(17, 87);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(122, 20);
            lblName1.TabIndex = 6;
            lblName1.Text = "First player name";
            // 
            // nudRounds
            // 
            nudRounds.Location = new Point(145, 38);
            nudRounds.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudRounds.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRounds.Name = "nudRounds";
            nudRounds.Size = new Size(69, 27);
            nudRounds.TabIndex = 6;
            nudRounds.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudRounds.ValueChanged += nudRounds_ValueChanged;
            // 
            // lblRounds
            // 
            lblRounds.AutoSize = true;
            lblRounds.Location = new Point(17, 40);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new Size(58, 20);
            lblRounds.TabIndex = 6;
            lblRounds.Text = "Rounds";
            // 
            // grpAction
            // 
            grpAction.Controls.Add(picDice);
            grpAction.Controls.Add(btnRoll);
            grpAction.Controls.Add(lblTurn);
            grpAction.Controls.Add(label2);
            grpAction.Controls.Add(lblRound);
            grpAction.Location = new Point(14, 304);
            grpAction.Name = "grpAction";
            grpAction.Size = new Size(315, 327);
            grpAction.TabIndex = 6;
            grpAction.TabStop = false;
            grpAction.Text = "Action";
            // 
            // picDice
            // 
            picDice.Image = Properties.Resources.Dice1;
            picDice.Location = new Point(89, 176);
            picDice.Name = "picDice";
            picDice.Size = new Size(125, 127);
            picDice.SizeMode = PictureBoxSizeMode.StretchImage;
            picDice.TabIndex = 7;
            picDice.TabStop = false;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(17, 119);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(278, 41);
            btnRoll.TabIndex = 7;
            btnRoll.Text = "ROLL";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += BtnRoll_Click;
            // 
            // lblTurn
            // 
            lblTurn.BackColor = SystemColors.ActiveCaptionText;
            lblTurn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTurn.ForeColor = SystemColors.ControlLightLight;
            lblTurn.Location = new Point(17, 67);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(278, 41);
            lblTurn.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.ForeColor = SystemColors.ActiveCaptionText;
            lblRound.Location = new Point(17, 33);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(64, 20);
            lblRound.TabIndex = 7;
            lblRound.Text = "Round 0";
            // 
            // grpAvatars
            // 
            grpAvatars.Controls.Add(btnReset);
            grpAvatars.Controls.Add(btnSetup2);
            grpAvatars.Controls.Add(btnSetup1);
            grpAvatars.Controls.Add(rbAvatar4);
            grpAvatars.Controls.Add(picAvatarOpt4);
            grpAvatars.Controls.Add(rbAvatar3);
            grpAvatars.Controls.Add(picAvatarOpt3);
            grpAvatars.Controls.Add(rbAvatar2);
            grpAvatars.Controls.Add(picAvatarOpt2);
            grpAvatars.Controls.Add(rbAvatar1);
            grpAvatars.Controls.Add(picAvatarOpt1);
            grpAvatars.Location = new Point(345, 49);
            grpAvatars.Name = "grpAvatars";
            grpAvatars.Size = new Size(212, 582);
            grpAvatars.TabIndex = 7;
            grpAvatars.TabStop = false;
            grpAvatars.Text = "Avatars";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(18, 506);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(174, 43);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET ALL";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // btnSetup2
            // 
            btnSetup2.Enabled = false;
            btnSetup2.Location = new Point(18, 447);
            btnSetup2.Name = "btnSetup2";
            btnSetup2.Size = new Size(174, 43);
            btnSetup2.TabIndex = 9;
            btnSetup2.Text = "Set Up Second Player";
            btnSetup2.UseVisualStyleBackColor = true;
            btnSetup2.Click += BtnSetup2_Click;
            // 
            // btnSetup1
            // 
            btnSetup1.Enabled = false;
            btnSetup1.Location = new Point(18, 389);
            btnSetup1.Name = "btnSetup1";
            btnSetup1.Size = new Size(174, 43);
            btnSetup1.TabIndex = 8;
            btnSetup1.Text = "Set Up First Player";
            btnSetup1.UseVisualStyleBackColor = true;
            btnSetup1.Click += BtnSetup1_Click;
            // 
            // rbAvatar4
            // 
            rbAvatar4.AutoSize = true;
            rbAvatar4.Location = new Point(18, 313);
            rbAvatar4.Name = "rbAvatar4";
            rbAvatar4.Size = new Size(17, 16);
            rbAvatar4.TabIndex = 6;
            rbAvatar4.UseVisualStyleBackColor = true;
            // 
            // picAvatarOpt4
            // 
            picAvatarOpt4.Image = Properties.Resources.Icon04;
            picAvatarOpt4.Location = new Point(71, 293);
            picAvatarOpt4.Name = "picAvatarOpt4";
            picAvatarOpt4.Size = new Size(76, 70);
            picAvatarOpt4.SizeMode = PictureBoxSizeMode.CenterImage;
            picAvatarOpt4.TabIndex = 9;
            picAvatarOpt4.TabStop = false;
            // 
            // rbAvatar3
            // 
            rbAvatar3.AutoSize = true;
            rbAvatar3.Location = new Point(18, 224);
            rbAvatar3.Name = "rbAvatar3";
            rbAvatar3.Size = new Size(17, 16);
            rbAvatar3.TabIndex = 4;
            rbAvatar3.UseVisualStyleBackColor = true;
            // 
            // picAvatarOpt3
            // 
            picAvatarOpt3.Image = Properties.Resources.Icon03;
            picAvatarOpt3.Location = new Point(71, 205);
            picAvatarOpt3.Name = "picAvatarOpt3";
            picAvatarOpt3.Size = new Size(76, 70);
            picAvatarOpt3.SizeMode = PictureBoxSizeMode.CenterImage;
            picAvatarOpt3.TabIndex = 7;
            picAvatarOpt3.TabStop = false;
            // 
            // rbAvatar2
            // 
            rbAvatar2.AutoSize = true;
            rbAvatar2.Location = new Point(18, 140);
            rbAvatar2.Name = "rbAvatar2";
            rbAvatar2.Size = new Size(17, 16);
            rbAvatar2.TabIndex = 2;
            rbAvatar2.UseVisualStyleBackColor = true;
            // 
            // picAvatarOpt2
            // 
            picAvatarOpt2.Image = Properties.Resources.Icon02;
            picAvatarOpt2.Location = new Point(71, 120);
            picAvatarOpt2.Name = "picAvatarOpt2";
            picAvatarOpt2.Size = new Size(76, 70);
            picAvatarOpt2.SizeMode = PictureBoxSizeMode.CenterImage;
            picAvatarOpt2.TabIndex = 5;
            picAvatarOpt2.TabStop = false;
            // 
            // rbAvatar1
            // 
            rbAvatar1.AutoSize = true;
            rbAvatar1.Checked = true;
            rbAvatar1.Location = new Point(18, 60);
            rbAvatar1.Name = "rbAvatar1";
            rbAvatar1.Size = new Size(17, 16);
            rbAvatar1.TabIndex = 0;
            rbAvatar1.TabStop = true;
            rbAvatar1.UseVisualStyleBackColor = true;
            rbAvatar1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // picAvatarOpt1
            // 
            picAvatarOpt1.Image = Properties.Resources.Icon01;
            picAvatarOpt1.Location = new Point(71, 35);
            picAvatarOpt1.Name = "picAvatarOpt1";
            picAvatarOpt1.Size = new Size(76, 70);
            picAvatarOpt1.SizeMode = PictureBoxSizeMode.CenterImage;
            picAvatarOpt1.TabIndex = 0;
            picAvatarOpt1.TabStop = false;
            // 
            // grpReport
            // 
            grpReport.Controls.Add(lstReport);
            grpReport.Location = new Point(968, 47);
            grpReport.Name = "grpReport";
            grpReport.Size = new Size(266, 456);
            grpReport.TabIndex = 8;
            grpReport.TabStop = false;
            grpReport.Text = "Report";
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.Location = new Point(19, 37);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(230, 404);
            lstReport.TabIndex = 0;
            lstReport.SelectedIndexChanged += report_SelectedIndexChanged;
            // 
            // btnShowResult
            // 
            btnShowResult.Location = new Point(968, 522);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Size = new Size(266, 109);
            btnShowResult.TabIndex = 9;
            btnShowResult.Text = "SHOW RESULT";
            btnShowResult.UseVisualStyleBackColor = true;
            btnShowResult.Click += BtnShowResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 680);
            Controls.Add(btnShowResult);
            Controls.Add(grpReport);
            Controls.Add(grpAvatars);
            Controls.Add(grpAction);
            Controls.Add(grpInit);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(grpPlayer2);
            Controls.Add(grpPlayer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPlayer1).EndInit();
            grpPlayer1.ResumeLayout(false);
            grpPlayer1.PerformLayout();
            grpPlayer2.ResumeLayout(false);
            grpPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer2).EndInit();
            grpInit.ResumeLayout(false);
            grpInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRounds).EndInit();
            grpAction.ResumeLayout(false);
            grpAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDice).EndInit();
            grpAvatars.ResumeLayout(false);
            grpAvatars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatarOpt1).EndInit();
            grpReport.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPlayer1;
        private GroupBox grpPlayer1;
        private Label point1;
        private GroupBox grpPlayer2;
        private Label lblPoints2;
        private Label point2;
        private PictureBox picPlayer2;
        private Label lblPoints1;
        private Button btnStart;
        private Label label1;
        private GroupBox grpInit;
        private NumericUpDown nudRounds;
        private Label lblRounds;
        private TextBox txtName2;
        private Label lblName2;
        private TextBox txtName1;
        private Label lblName1;
        private GroupBox grpAction;
        private PictureBox picDice;
        private Button btnRoll;
        private Label lblTurn;
        private Label label2;
        private Label lblRound;
        private GroupBox grpAvatars;
        private PictureBox picAvatarOpt1;
        private RadioButton rbAvatar1;
        private RadioButton rbAvatar4;
        private PictureBox picAvatarOpt4;
        private RadioButton rbAvatar3;
        private PictureBox picAvatarOpt3;
        private RadioButton rbAvatar2;
        private PictureBox picAvatarOpt2;
        private Button btnReset;
        private Button btnSetup2;
        private Button btnSetup1;
        private GroupBox grpReport;
        private ListBox lstReport;
        private Button btnShowResult;
    }
}
