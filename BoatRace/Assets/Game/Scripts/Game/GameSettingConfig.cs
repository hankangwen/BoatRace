using UnityEngine;

namespace BoatRace.Game
{
    [CreateAssetMenu(fileName ="GameSettingConfig", menuName ="ScriptableObject/GameSettingConfig", order = 1)]
    public class GameSettingConfig : ScriptableObject
    {
        public string serverIP = "127.0.0.1";
        public int serverPort = 8888;
        public bool DEBUG_MODE = true;
        public bool ENABLE_DEBUG_LOG = true;
        
    }
}