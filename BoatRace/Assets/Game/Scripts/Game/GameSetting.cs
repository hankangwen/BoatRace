using BoatRace.Tools.Debugger;
using UnityEngine;

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
        
        private GameSettingConfig _setting = null;
        public GameSettingConfig Setting
        {
            get
            {
                if (_setting == null) {
                    GameSettingConfig setting = Resources.Load<GameSettingConfig>("GameSettingConfig");
                    if (setting != null)
                        _setting = UnityEngine.Object.Instantiate(setting);
                    else
                        Debugger.LogError("Load GameSettingConfig failed");
                }
                return _setting;
            }
        }
    }
}