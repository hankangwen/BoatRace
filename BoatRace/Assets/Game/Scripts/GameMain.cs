using System.Collections;
using System.Collections.Generic;
using BoatRace.Game;
using BoatRace.Net;
using BoatRace.Tools.Debugger;
using Unity.VisualScripting;
using UnityEngine;

namespace BoatRace
{
    public class GameMain : MonoBehaviour
    {
        public string sendMessage = "123";
        
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
    }
}
