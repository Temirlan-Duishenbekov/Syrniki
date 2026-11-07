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
        Random random = new Random();

        string resultsFile;
        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            resultsFile = Path.Combine(Application.StartupPath, "results.txt");
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
    }
}
