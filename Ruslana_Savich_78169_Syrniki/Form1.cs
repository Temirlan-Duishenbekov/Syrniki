using System.Media;
using System.Windows.Forms;

namespace Ruslana_Savich_78169_Syrniki
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;

        string name1Original = "";
        string name2Original = "";

        bool player1Ready = false;
        bool player2Ready = false;

        bool gameStarted = false;
        int remainingRounds = 0;
        int whoseTurn = 1; // 1 = first player, 2 = second player
        int diceValue1 = 0;
        int diceValue2 = 0;
        Random rnd = new Random();

        string resultsFile;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            resultsFile = Path.Combine(Application.StartupPath, "results.txt");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAvatarOptions();
            ShowDefaultAvatars();
            ResetAll();
        }

        // load avatar pictures next to radio buttons
        private void LoadAvatarOptions()
        {
            try
            {
                string folder = Path.Combine(Application.StartupPath, "Images", "avatars");
                picAvatarOpt1.Image = Image.FromFile(Path.Combine(folder, "avatar1.png"));
                picAvatarOpt2.Image = Image.FromFile(Path.Combine(folder, "avatar2.png"));
                picAvatarOpt3.Image = Image.FromFile(Path.Combine(folder, "avatar3.png"));
                picAvatarOpt4.Image = Image.FromFile(Path.Combine(folder, "avatar4.png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load avatar images: " + ex.Message);
            }
        }

        private void ShowDefaultAvatars()
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Images", "avatars", "default.png");
                picPlayer1.Image = Image.FromFile(path);
                picPlayer2.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't load default avatar: " + ex.Message);
            }
        }
        // enable setup buttons only when BOTH names are typed
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (gameStarted == true)
            {
                return;
            }

            if (txtName1.Text.Trim() != "" && txtName2.Text.Trim() != "")
            {
                if (player1Ready == false)
                {
                    btnSetup1.Enabled = true;
                }
                if (player2Ready == false)
                {
                    btnSetup2.Enabled = true;
                }
            }
            else
            {
                if (player1Ready == false)
                {
                    btnSetup1.Enabled = false;
                }
                if (player2Ready == false)
                {
                    btnSetup2.Enabled = false;
                }
            }
        }

        private int GetSelectedAvatarIndex()
        {
            if (rbAvatar1.Checked == true)
            {
                return 1;
            }
            else if (rbAvatar2.Checked == true)
            {
                return 2;
            }
            else if (rbAvatar3.Checked == true)
            {
                return 3;
            }
            else if (rbAvatar4.Checked == true)
            {
                return 4;
            }
            else
            {
                return 1;
            }
        }

        private string GetAvatarPath(int index)
        {
            string folder = Path.Combine(Application.StartupPath, "Images", "avatars");
            return Path.Combine(folder, "avatar" + index + ".png");
        }

        private void BtnSetup1_Click(object sender, EventArgs e)
        {
            if (txtName1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter first player name!");
                return;
            }
            int avatarIndex = GetSelectedAvatarIndex();
            if (player2Ready == true && player2.AvatarIndex == avatarIndex)
            {
                MessageBox.Show("Players cannot choose the same avatar!");
                return;
            }

            name1Original = txtName1.Text.Trim();
            string name = name1Original.ToUpper();
            string path = GetAvatarPath(avatarIndex);

            player1 = new Player(name, avatarIndex, path);
            player1Ready = true;

            grpPlayer1.Text = name;
            try
            {
                picPlayer1.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading avatar: " + ex.Message);
            }

            txtName1.Enabled = false;
            btnSetup1.Enabled = false;

            CheckBothReady();
        }
        private void BtnSetup2_Click(object sender, EventArgs e)
        {
            if (txtName2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter second player name!");
                return;
            }

            int avatarIndex = GetSelectedAvatarIndex();

            // can't choose same avatar
            if (player1Ready == true && player1.AvatarIndex == avatarIndex)
            {
                MessageBox.Show("Players cannot choose the same avatar!");
                return;
            }

            name2Original = txtName2.Text.Trim();
            string name = name2Original.ToUpper();
            string path = GetAvatarPath(avatarIndex);

            player2 = new Player(name, avatarIndex, path);
            player2Ready = true;

            grpPlayer2.Text = name;
            try
            {
                picPlayer2.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading avatar: " + ex.Message);
            }

            txtName2.Enabled = false;
            btnSetup2.Enabled = false;

            CheckBothReady();
        }
        private void btnSetup2_Click(object sender, EventArgs e)
        {
            if (txtName2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter second player name!");
                return;
            }

            int avatarIndex = GetSelectedAvatarIndex();

            // cannot choose same avatar
            if (player1Ready == true && player1.AvatarIndex == avatarIndex)
            {
                MessageBox.Show("Players cannot choose the same avatar!");
                return;
            }

            name2Original = txtName2.Text.Trim();
            string name = name2Original.ToUpper();
            string path = GetAvatarPath(avatarIndex);

            player2 = new Player(name, avatarIndex, path);
            player2Ready = true;

            grpPlayer2.Text = name;
            try
            {
                picPlayer2.Image = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading avatar: " + ex.Message);
            }

            txtName2.Enabled = false;
            btnSetup2.Enabled = false;

            CheckBothReady();
        }
        private void CheckBothReady()
        {
            if (player1Ready == true && player2Ready == true)
            {
                btnStart.Enabled = true;
            }
        }
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (player1Ready == false || player2Ready == false)
            {
                MessageBox.Show("Please set up both players first!");
                return;
            }

            gameStarted = true;
            remainingRounds = (int)nudRounds.Value;
            whoseTurn = 1;
            diceValue1 = 0;
            diceValue2 = 0;

            player1.ResetPoints();
            player2.ResetPoints();
            lblPoints1.Text = "0";
            lblPoints2.Text = "0";

            lblRound.Text = "Round " + remainingRounds;
            lblTurn.Text = name1Original + "'s turn";

            btnStart.Enabled = false;
            btnRoll.Enabled = true;
            btnSetup1.Enabled = false;
            btnSetup2.Enabled = false;
            txtName1.Enabled = false;
            txtName2.Enabled = false;
            nudRounds.Enabled = false;
            rbAvatar1.Enabled = false;
            rbAvatar2.Enabled = false;
            rbAvatar3.Enabled = false;
            rbAvatar4.Enabled = false;

            picDice.Image = null;
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            // random number from 1 to 6
            int value = rnd.Next(1, 7);

            // show dice image
            try
            {
                string dicePath = Path.Combine(Application.StartupPath, "images", "Dice", "Dice" + value + ".jpg");
                picDice.Image = Image.FromFile(dicePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dice image: " + ex.Message);
            }

            if (whoseTurn == 1)
            {
                diceValue1 = value;
                whoseTurn = 2;
                lblTurn.Text = name2Original + "'s turn";
            }
            else
            {
                diceValue2 = value;

                // both players rolled, give point(s)
                if (diceValue1 == diceValue2)
                {
                    player1.AddPoint();
                    player2.AddPoint();
                }
                else if (diceValue1 > diceValue2)
                {
                    player1.AddPoint();
                }
                else
                {
                    player2.AddPoint();
                }

                lblPoints1.Text = player1.Points.ToString();
                lblPoints2.Text = player2.Points.ToString();

                remainingRounds = remainingRounds - 1;

                if (remainingRounds == 0)
                {
                    // game over
                    btnRoll.Enabled = false;
                    lblRound.Text = "Round 0";
                    lblTurn.Text = "";
                    EndGame();
                }
                else
                {
                    // next round - player 1 again
                    whoseTurn = 1;
                    diceValue1 = 0;
                    diceValue2 = 0;
                    lblRound.Text = "Round " + remainingRounds;
                    lblTurn.Text = name1Original + "'s turn";
                }
            }
        }

        private void EndGame()
        {
            string resultText;
            string message;

            if (player1.Points > player2.Points)
            {
                resultText = "The winner is " + player1.Name;
                message = "The winner is " + player1.Name;
            }
            else if (player2.Points > player1.Points)
            {
                resultText = "The winner is " + player2.Name;
                message = "The winner is " + player2.Name;
            }
            else
            {
                resultText = "No winner";
                message = "No winner";
            }
            // save result to txt
            string line = player1.Name + ":" + player1.Points + "," + player2.Name + ":" + resultText;
            SaveResult(line);

            MessageBox.Show(message, "GAME OVER");

            // after OK reset all
            ResetAll();
        }

        private void SaveResult(string line)
        {
            try
            {
                // append new result to file
                StreamWriter sw = new StreamWriter(resultsFile, true);
                sw.WriteLine(line);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving result: " + ex.Message);
            }
        }
        private void BtnShowResult_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();

            try
            {
                if (File.Exists(resultsFile) == false)
                {
                    MessageBox.Show("No results file yet.");
                    return;
                }

                StreamReader sr = new StreamReader(resultsFile);
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line.Trim() != "")
                    {
                        lstReport.Items.Add(line);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading results: " + ex.Message);
            }
        }
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {
            player1 = new Player();
            player2 = new Player();
            name1Original = "";
            name2Original = "";
            player1Ready = false;
            player2Ready = false;
            gameStarted = false;
            remainingRounds = 0;
            whoseTurn = 1;
            diceValue1 = 0;
            diceValue2 = 0;

            nudRounds.Value = 5;
            nudRounds.Enabled = true;

            txtName1.Text = "";
            txtName2.Text = "";
            txtName1.Enabled = true;
            txtName2.Enabled = true;

            btnSetup1.Enabled = false;
            btnSetup2.Enabled = false;
            btnStart.Enabled = false;
            btnRoll.Enabled = false;

            btnReset.Enabled = true;
            btnShowResult.Enabled = true;

            rbAvatar1.Enabled = true;
            rbAvatar2.Enabled = true;
            rbAvatar3.Enabled = true;
            rbAvatar4.Enabled = true;
            rbAvatar1.Checked = true;

            grpPlayer1.Text = "First player";
            grpPlayer2.Text = "Second player";
            lblPoints1.Text = "0";
            lblPoints2.Text = "0";

            lblRound.Text = "Round 0";
            lblTurn.Text = "";
            picDice.Image = null;

            ShowDefaultAvatars();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblpoint2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblpoint1_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void report_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picAvatarOpt1_Click(object sender, EventArgs e)
        {

        }

        private void nudRounds_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
