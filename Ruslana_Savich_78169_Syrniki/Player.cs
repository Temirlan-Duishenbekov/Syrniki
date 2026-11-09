namespace Ruslana_Savich_78169_Syrniki
{
    internal class Player
    {
        public string Name = "";
        public int Points = 0;
        public int AvatarIndex = 0;
        public string AvatarPath = "";

        public Player()
        {
        }

        public Player(string name, int avatarIndex, string avatarPath)
        {
            Name = name;
            AvatarIndex = avatarIndex;
            AvatarPath = avatarPath;
            Points = 0;
        }

        public void AddPoint()
        {
            Points = Points + 1;
        }

        public void ResetPoints()
        {
            Points = 0;
        }
    }
}