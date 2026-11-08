namespace Ruslana_Savich_78169_Syrniki
{
    internal class Player
    {
        internal int AvatarIndex;

        public Player()
        {
        }

        public Player(string name, int avatarIndex, string path)
        {
            AvatarIndex = avatarIndex;
        }

        public object point { get; internal set; }
        public string Name { get; internal set; }
        public object points { get; internal set; }

        internal void AddPoint()
        {
            throw new NotImplementedException();
        }

        internal void ResetPoints()
        {
            throw new NotImplementedException();
        }
    }
}