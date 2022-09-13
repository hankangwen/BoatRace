using System.Collections;
using System.Collections.Generic;
using BoatRace.Game;
using UnityEngine;

namespace BoatRace.PhoneGM
{
    public class PhoneGM : MonoBehaviour
    {
        public GameObject gmPanel;
        public bool enable = false;
        
        private Canvas _uiCanvas;
        
#if !UNITY_EDITOR
        void Start()
        {
            // development build默认开启RemoteDebugger
            if (!enable && Debug.isDebugBuild) {
                enable = true;
            }
        }
#endif

        void OnEnable() {
            if(enable) {
                _uiCanvas = GameManager.Instance.uiCanvas;
                Instantiate(gmPanel, _uiCanvas.transform);
            }
        }
    }
}