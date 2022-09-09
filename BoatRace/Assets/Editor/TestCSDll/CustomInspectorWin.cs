

using System.Reflection;
using UnityEditor;
using UnityEngine;

public class CustomInspectorWin
{
    [MenuItem("Tool/Test编辑器反射")]
    static void OnLock()
    {
        // var type = typeof(EditorWindow).Assembly.GetType("UnityEditor.InspectorWindow");
        //
        // var window = EditorWindow.GetWindow(type);
        //
        // // MethodInfo info = type.GetMethod("FlipLocked", BindingFlags.NonPublic | BindingFlags.Instance);
        //
        // // info.Invoke(window, null);
        //
        // PropertyInfo title = type.GetProperty("title");
        // title.SetValue(window, "AABBCC", null);
        //
        // MethodInfo isLock = type.GetMethod("RefreshTitle", BindingFlags.NonPublic | BindingFlags.Instance);
        // isLock.Invoke(window, null);
        //
        // PropertyInfo t2 = type.GetProperty("titleContent");
        // t2.SetValue(window, new GUIContent("宝宝巴士", "This is the 宝宝巴士"), null);
        
    }
    
}
