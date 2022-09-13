using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

namespace BoatRace.Game
{
    public class GameManager
    {
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameManager();
                return _instance;
            }
        }

        private static LuaState _luaState;

        public LuaState luaState
        {
            get
            {
                if (_luaState == null)
                    _luaState = new LuaState();
                return _luaState;
            }
        }
        
        private static Camera _mainCamera = null;

        public Camera mainCamera
        {
            get
            {
                if (_mainCamera == null)
                    _mainCamera = Camera.main;
                return _mainCamera;
            }
        }

        private static Canvas _uiCanvas = null;

        public Canvas uiCanvas
        {
            get
            {
                if (_uiCanvas == null)
                    _uiCanvas = GameObject.FindWithTag("UICanvas").GetComponent<Canvas>();
                return _uiCanvas;
            }
        }
    }
}