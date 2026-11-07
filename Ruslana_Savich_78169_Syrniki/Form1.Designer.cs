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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lblpoint1 = new Label();
            point = new Label();
            groupBox2 = new GroupBox();
            lblpoint2 = new Label();
            point2 = new Label();
            pictureBox2 = new PictureBox();
            start = new Button();
            label1 = new Label();
            grpInit = new GroupBox();
            txtName2 = new TextBox();
            lblName2 = new Label();
            txtName1 = new TextBox();
            lblName1 = new Label();
            numericUpDown1 = new NumericUpDown();
            lblRounds = new Label();
            groupBox3 = new GroupBox();
            pictureBox3 = new PictureBox();
            btnRoll = new Button();
            lblTurn = new Label();
            label2 = new Label();
            lblRound = new Label();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblpoint1);
            groupBox1.Controls.Add(point);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(573, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 212);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "First player";
            // 
            // lblpoint1
            // 
            lblpoint1.AutoSize = true;
            lblpoint1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblpoint1.Location = new Point(229, 103);
            lblpoint1.Name = "lblpoint1";
            lblpoint1.Size = new Size(40, 46);
            lblpoint1.TabIndex = 2;
            lblpoint1.Text = "0";
            lblpoint1.Click += lblpoint1_Click;
            // 
            // point
            // 
            point.AutoSize = true;
            point.Location = new Point(229, 49);
            point.Name = "point";
            point.Size = new Size(42, 20);
            point.TabIndex = 1;
            point.Text = "Point";
            point.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblpoint2);
            groupBox2.Controls.Add(point2);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(573, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 212);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Second player";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblpoint2
            // 
            lblpoint2.AutoSize = true;
            lblpoint2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblpoint2.Location = new Point(229, 103);
            lblpoint2.Name = "lblpoint2";
            lblpoint2.Size = new Size(40, 46);
            lblpoint2.TabIndex = 2;
            lblpoint2.Text = "0";
            lblpoint2.Click += lblpoint2_Click;
            // 
            // point2
            // 
            point2.AutoSize = true;
            point2.Location = new Point(229, 49);
            point2.Name = "point2";
            point2.Size = new Size(42, 20);
            point2.TabIndex = 1;
            point2.Text = "Point";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(22, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 133);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // start
            // 
            start.ForeColor = SystemColors.ButtonShadow;
            start.Location = new Point(573, 522);
            start.Name = "start";
            start.Size = new Size(365, 109);
            start.TabIndex = 3;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
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
            grpInit.Controls.Add(numericUpDown1);
            grpInit.Controls.Add(lblRounds);
            grpInit.Location = new Point(14, 47);
            grpInit.Name = "grpInit";
            grpInit.Size = new Size(315, 232);
            grpInit.TabIndex = 5;
            grpInit.TabStop = false;
            grpInit.Text = "Initializations";
            // 
            // txtName2
            // 
            txtName2.Location = new Point(17, 176);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(209, 27);
            txtName2.TabIndex = 6;
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
            txtName1.TabIndex = 6;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(145, 38);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 27);
            numericUpDown1.TabIndex = 6;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(btnRoll);
            groupBox3.Controls.Add(lblTurn);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lblRound);
            groupBox3.Location = new Point(14, 304);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 327);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(89, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 127);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(17, 119);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(278, 41);
            btnRoll.TabIndex = 7;
            btnRoll.Text = "ROLL";
            btnRoll.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            groupBox4.Location = new Point(345, 49);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(212, 582);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Avatars";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 680);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(grpInit);
            Controls.Add(label1);
            Controls.Add(start);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpInit.ResumeLayout(false);
            grpInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label point;
        private GroupBox groupBox2;
        private Label lblpoint2;
        private Label point2;
        private PictureBox pictureBox2;
        private Label lblpoint1;
        private Button start;
        private Label label1;
        private GroupBox grpInit;
        private NumericUpDown numericUpDown1;
        private Label lblRounds;
        private TextBox txtName2;
        private Label lblName2;
        private TextBox txtName1;
        private Label lblName1;
        private GroupBox groupBox3;
        private PictureBox pictureBox3;
        private Button btnRoll;
        private Label lblTurn;
        private Label label2;
        private Label lblRound;
        private GroupBox groupBox4;
    }
}
