using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using Core;

namespace BoatRace.Editor
{
    public static class UIEditor
    {
        private static GameObject Create<T>() where T:Graphic
        {
            var go = new GameObject(typeof(T).Name);
            go.AddComponent<T>().raycastTarget = false;
            if (Selection.activeTransform != null && Selection.activeTransform.GetComponentInParent<Canvas>())
            {
                go.transform.SetParent(Selection.activeTransform);
            }
            go.transform.localScale = Vector3.one;
            go.transform.localPosition = Vector3.zero;
            go.SetLayerRecursively(LayerMask.NameToLayer("UI"));
            return go;
        }
        
        [MenuItem("GameObject/UI/Image")]
        private static void CreateImage()
        {
            Create<Image>();        
        }
        
    }
}
