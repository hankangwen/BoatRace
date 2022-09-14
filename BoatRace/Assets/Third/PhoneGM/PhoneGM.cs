using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoatRace.Game;

namespace BoatRace.PhoneGM
{
    public class PhoneGM : MonoBehaviour
    {
        public GameObject gmPanel;
        public bool enable = false;
        
        private Canvas _uiCanvas;

#if !UNITY_EDITOR
        void Awake()
        {
            // development build默认开启
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