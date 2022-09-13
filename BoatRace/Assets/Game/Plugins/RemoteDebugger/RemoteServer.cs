using UnityEngine;
using System.Collections;
using System;
using Unity.VisualScripting;

namespace RemoteDebugger {
    public class RemoteServer : MonoBehaviour {
        public bool enable = false;
        public int port = 4996;
        
#if !UNITY_EDITOR
        void Awake()
        {
            // development build默认开启
            if (!enable && Debug.isDebugBuild) {
                enable = true;
            }
        }

        void OnEnable() {
            if(enable) MainServer.Instance.Init(port);
        }

        void Update() {
            if(enable) MainServer.Instance.Update();
        }

        void OnDisable() {
            if(enable) MainServer.Instance.UnInit();
        }
#endif
        
    }
}