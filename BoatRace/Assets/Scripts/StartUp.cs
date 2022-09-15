using BoatRace.Game;
using BoatRace.Net;
using LuaFramework;
using UnityEngine;

namespace BoatRace
{
    /// <summary>
    /// 启动脚本
    /// </summary>
    public class StartUp : MonoBehaviour
    {
        private NetworkMsgEventRegister m_networkMsgEventRegister;
        
        void Awake()
        {
            // 热更新之前初始化一些模块
            InitBeforeHotUpdate();
            
            // 热更新
            HotUpdatePanel.Show(() =>
            {
                // 热更新后初始化一些模块
                InitAfterHotUpdate();
                // 启动游戏
                StartGame();
            });
        }

        private void StartGame()
        {
            //启动lua框架//
            LuaFramework.AppFacade.Instance.StartUp(() =>
            {
#if UNITY_EDITOR
                ConnectEmmyLua();
#endif
                LuaCall.CallFunc("Main.Init");
                LuaCall.CallFunc("Main.Start");

                // 监听关闭游戏事件
                AppQuitDefend.Init();
            });
        }
        
        /// <summary>
        /// 热更新之前初始化一些模块
        /// </summary>
        private void InitBeforeHotUpdate()
        {
            m_networkMsgEventRegister = new NetworkMsgEventRegister();
            // 限制游戏帧数
            Application.targetFrameRate = AppConst.GameFrameRate;
            // 手机常亮
            Screen.sleepTimeout = -1;
            // 后台运行
            Application.runInBackground = true;
            
            // 日志
            GameLogger.Init();
#if !UNITY_EDITOR
            if(Debug.isDebugBuild)
                LogCat.Init();
#endif
            
            // 网络消息注册
            m_networkMsgEventRegister.RegistNetworkMsgEvent();
            
            // 界面管理器
            PanelMgr.Instance.Init();
            // 版本号
            VersionMgr.Instance.Init();
            // 预加载AssetBundle
            AssetBundleMgr.Instance.PreloadAssetBundles();
            // TODO 加载必要的资源AssetBundle
            
            
            TimerThread.Instance.Init();
            ClientNet.instance.Init();
            ScreenCapture.Init();
        }
        
        
        /// <summary>
        /// 热更新后初始化一些模块
        /// </summary>
        private void InitAfterHotUpdate()
        {
            // 资源管理器
            ResourceManager.instance.Init();
            // 音效管理器
            AudioMgr.instance.Init();
            // 多语言
            LanguageMgr.instance.Init();
            I18N.instance.Init();
            // 图集管理器
            SpriteManager.instance.Init();
        }

        void Connect()
        {
            var setting = GameSetting.Instance.Setting;
            string serverIP = setting.serverIP;
            int port = setting.serverPort;
            NetManager.Connect(serverIP, port);
        }
        
        void Update()
        {
            AppFacade.Instance.UpdateEx();
            
            // NetManager.Update();
            //
            // if (Input.GetMouseButtonDown(0)) {
            //     NetManager.Send(sendMessage);
            // }
            //
            // if (Input.GetMouseButtonDown(1)) {
            //     NetManager.Close();
            // }
        }
        
        private void LateUpdate()
        {
            AppFacade.Instance.LateUpdateEx();
        }

        private void FixedUpdate()
        {
            AppFacade.Instance.FixedUpdateEx();
        }

        void OnDestroy()
        {
            // if (luaFunc != null)
            // {
            //     luaFunc.Dispose();
            //     luaFunc = null;
            // }
            //
            // luaState.Dispose();
            // luaState = null;
        }
        
        
#if UNITY_EDITOR
        private void ConnectEmmyLua()
        {
            // 连接EmmyLua
            string script =
                @"  function ConnectEmmyLua()                        
                    pcall(function()
                            print('Connect EmmyLua')
                            package.cpath = package.cpath .. ';' .. UnityEngine.Application.dataPath .. '/../Tools/Emmylua/emmy_core.dll'
                            local dbg = require('emmy_core')
                            dbg.tcpConnect('localhost', 9966)
                          end)
                end
                EmmyLuaCon = {}
                EmmyLuaCon.luaFunc = ConnectEmmyLua
            ";

            var luaState = LuaManager.instance.GetState();
            luaState.DoString(script, "StartUp.cs");
            LuaCall.CallFunc("EmmyLuaCon.luaFunc");
        }
#endif
    }
}
