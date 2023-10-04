namespace LojaGames.Security
{
    public class Settings
    {
        private static string secret = "VYPX89HUeAyMBkmlgZuT1I3wC7vOLKJi";

        public static string Secret { get => secret; set => secret = value; }
    }
}
