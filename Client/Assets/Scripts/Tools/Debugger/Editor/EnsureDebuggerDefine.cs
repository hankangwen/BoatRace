using System;
using System.Linq;
using BoatRace.Game;
using UnityEditor;
using UnityEngine;

namespace BoatRace.Tools.Debugger
{
    /// <summary>
    /// Defines the Debugger symbol.
    /// </summary>
    internal static class EnsureDebuggerDefine
    {
        private const string DEFINE = "ENABLE_DEBUG_LOG";

        [InitializeOnLoadMethod]
        private static void EnsureDebuggerDefineSymbol()
        {
            EnableOrDisableDebugger(GameSetting.Instance.Setting.ENABLE_DEBUG_LOG);
        }
        
        [MenuItem("Tools/Debugger/Enable Debugger")]
        public static void EnableDebugger()
        {
            EnableOrDisableDebugger(true);
        }
        
        [MenuItem("Tools/Debugger/Disable Debugger")]
        public static void DisableDebugger()
        {
            EnableOrDisableDebugger(false);
        }

        private static void SetGameSettingConfigEnableDebug(bool enable)
        {
            if (enable == GameSetting.Instance.Setting.ENABLE_DEBUG_LOG)
                return;
            
            GameSettingConfig setting = AssetDatabase.LoadAssetAtPath<GameSettingConfig>
                ("Assets/Scripts/Game/Resources/GameSettingConfig.asset");
            setting.ENABLE_DEBUG_LOG = enable;
            EditorUtility.SetDirty(setting);
        }

        private static void EnableOrDisableDebugger(bool enable)
        {
            var currentTarget = EditorUserBuildSettings.selectedBuildTargetGroup;
            if (currentTarget == BuildTargetGroup.Unknown)
            {
                return;
            }
            
            SetGameSettingConfigEnableDebug(enable);
            
            var definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(currentTarget).Trim();
            var defines = definesString.Split(';');
            
            if (enable)
            {
                if (defines.Contains(DEFINE) == false)
                {
                    if (definesString.EndsWith(";", StringComparison.InvariantCulture) == false)
                    {
                        definesString += ";";
                    }

                    definesString += DEFINE;
                    PlayerSettings.SetScriptingDefineSymbolsForGroup(currentTarget, definesString);
                }
            }
            else
            {
                if (defines.Contains(DEFINE))
                {
                    definesString = defines.Where(x => x != DEFINE).Aggregate("", (current, x) => current + x + ";");
                    PlayerSettings.SetScriptingDefineSymbolsForGroup(currentTarget, definesString);
                }
            }
        }
    }
}

    