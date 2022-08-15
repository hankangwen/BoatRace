using Unity.VisualScripting.Dependencies.NCalc;

namespace BoatRace.Game
{
    public class GameSetting
    {
        private static GameSetting _instance;
        public static GameSetting Instance
        {
            get 
            {
                if (_instance == null)
                    _instance = new GameSetting();
                return _instance;
            }
        }
        
        public string serverIP = "127.0.0.1";
        public bool debugMode = true;
        
    }
}