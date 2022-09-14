using UnityEngine;

namespace Core
{
    public static class GameObjectExtension
    {
        public static T MakeSureComponent<T>(this GameObject go) where T : Component
        {
            var component = go.GetComponent<T>();
            if (component == null)
                component = go.AddComponent<T>();
            return component;
        }

        public static GameObject GlobalGameObject(string name = "_global")
        {
#if UNITY_EDITOR
            if (!Application.isPlaying) {
                Debug.LogError("GlobalGameObject should not call in editor mode.");
            }
#endif

            var global = GameObject.Find(name);
            if (global == null) {
                global = new GameObject(name);
                UnityEngine.Object.DontDestroyOnLoad(global);
            }

            return global;
        }
        
        public static void SetLayerRecursively(this GameObject gameObject, int layer)
        {
            var transforms = gameObject.GetComponentsInChildren<Transform>(true);
            var len = transforms.Length;
            for (var i = 0; i < len; ++i)
            {
                transforms[i].gameObject.layer = layer;
            }
            
            // var property = gameObject.GetComponent<GameObjectBase>();
            // if (property != null)
            //     property.OnLayerChanged();
        }
    }
}