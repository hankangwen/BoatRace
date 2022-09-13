using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UsingTheirs.RemoteInspector;

public class RemoteInspector : MonoBehaviour
{
    public GameObject RemoteInspectorServer;
    public bool enable = false;
    public short ListenPort = 8080;
    
#if !UNITY_EDITOR
    void Start()
    {
        // development build默认开启RemoteDebugger
        if (!enable && Debug.isDebugBuild) {
            enable = true;
        }

        if (enable) {
            var go = Instantiate(RemoteInspectorServer, this.transform);
            var cmp = go.GetComponent<ServerHttpJsonPost>();
            if (cmp && cmp.listenPort != ListenPort)
                cmp.listenPort = ListenPort;
        }
    }
#endif
    
}
