using System;
using System.Collections;
using System.Collections.Generic;
using BoatRace.Game;
using BoatRace.Net;
using LuaFramework;
using LuaInterface;
using Unity.VisualScripting;
using UnityEngine;

namespace BoatRace
{
    /// <summary>
    /// 启动脚本
    /// </summary>
    public class StartUp : MonoBehaviour
    {
        void Awake()
        {
            // 热更新之前初始化一些模块
            InitBeforeHotUpdate();
            
            // 启动luaState
            // luaState = GameManager.Instance.luaState;
            // luaState.Start();            
            // LuaBinder.Bind(luaState);    //将导出的Wrap包注册到lua虚拟机中

#if UNITY_EDITOR
            // 连接EmmyLua
            // string script =
            //     @"  function ConnectEmmyLua()                        
            //             pcall(function()
            //                     package.cpath = package.cpath .. ';' .. UnityEngine.Application.dataPath .. '/../../Tools/Emmylua/emmy_core.dll'
            //                     local dbg = require('emmy_core')
            //                     dbg.tcpConnect('localhost', 9968)
            //                   end)
            //         end
            //         EmmyLuaCon = {}
            //         EmmyLuaCon.luaFunc = ConnectEmmyLua
            //     ";
            // luaState.DoString(script, "GameMain.cs");
            // CallLuaFunc("EmmyLuaCon.luaFunc");
#endif
            
            // luaState.Require("Main");
            // CallLuaFunc("Main");
        }
        
        /// <summary>
        /// 热更新之前初始化一些模块
        /// </summary>
        private void InitBeforeHotUpdate()
        {
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
            
            
            // // 网络消息注册
            // m_networkMsgEventRegister.RegistNetworkMsgEvent();
            // // 界面管理器
            // PanelMgr.instance.Init();
            //
            // // 版本号
            // VersionMgr.instance.Init();
            //
            // // 预加载AssetBundle
            // AssetBundleMgr.instance.PreloadAssetBundles();
            // // TODO 加载必要的资源AssetBundle
            //
            //
            // TimerThread.instance.Init();
            // ClientNet.instance.Init();
            // ScreenCapture.Init();
        }

        void CallLuaFunc(string funcName)
        {
            // luaFunc = luaState.GetFunction(funcName);
            // if (luaFunc != null) {
            //     luaFunc.BeginPCall();
            //     luaFunc.PCall();
            //     luaFunc.EndPCall();
            //     luaFunc.Dispose();
            //     luaFunc = null;
            // }
        }

        void Start()
        {
            Debugger.Log("Boat Race Client Start.");
            // Connect();
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
            if (Input.GetKeyDown(KeyCode.A)) {
                
                Debugger.Log("Boat Race Client Staddddddddddddddddddddddddrt.");
            }
        //     NetManager.Update();
        //
        //     if (Input.GetMouseButtonDown(0)) {
        //         NetManager.Send(sendMessage);
        //     }
        //
        //     if (Input.GetMouseButtonDown(1)) {
        //         NetManager.Close();
        //     }
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
    }
}
