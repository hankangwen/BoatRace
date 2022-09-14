using System;
using System.Collections;
using System.Collections.Generic;
using BoatRace.Game;
using BoatRace.Net;
using LuaInterface;
using Unity.VisualScripting;
using UnityEngine;
// using Debugger = BoatRace.Tools.Debugger.Debugger;

namespace BoatRace
{
    public class StartUp : MonoBehaviour
    {
        // public string sendMessage = "123";

        // private LuaState luaState;
        // private LuaFunction luaFunc = null;
        
        void Awake()
        {
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
        
        // void Update()
        // {
        //     NetManager.Update();
        //
        //     if (Input.GetMouseButtonDown(0)) {
        //         NetManager.Send(sendMessage);
        //     }
        //
        //     if (Input.GetMouseButtonDown(1)) {
        //         NetManager.Close();
        //     }
        // }

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
