using System;
using System.Reflection;
using UnityEditor;
using CSDll;
using UnityEngine;

public class TestCSDll
{
    [MenuItem("Tools/Test反射")]
    static void TestDll()
    {
        // 获取类型
        var type = typeof(TestDll).Assembly.GetType("CSDll.TestDll");
        // 创建实例对象
        object testDll = Activator.CreateInstance(type) as TestDll;
        
        // 获取方法
        MethodInfo m1 = type.GetMethod("PrivateGet", BindingFlags.NonPublic | BindingFlags.Instance);
        var value1 = m1.Invoke(testDll, new object[] { 1 });
        Debug.Log(value1);
        
        MethodInfo m2 = type.GetMethod("ProtectedGet", BindingFlags.NonPublic | BindingFlags.Instance);
        var value2 = m2.Invoke(testDll, new object[] { 1 });
        Debug.Log(value2);
        
        MethodInfo m3 = type.GetMethod("PublicGet", BindingFlags.Public | BindingFlags.Instance);
        var value3 = m3.Invoke(testDll, new object[] { 1 });
        Debug.Log(value3);
        
        
        // 获取属性
        FieldInfo fieldInfo = type.GetField("a", BindingFlags.NonPublic | BindingFlags.Instance);
        if (fieldInfo != null) {
            Debug.Log(fieldInfo.GetValue(testDll));
        }
        
        fieldInfo = type.GetField("b", BindingFlags.NonPublic | BindingFlags.Instance);
        if (fieldInfo != null) {
            Debug.Log(fieldInfo.GetValue(testDll));
        }
        
        fieldInfo = type.GetField("c", BindingFlags.Public | BindingFlags.Instance);
        if (fieldInfo != null) {
            Debug.Log(fieldInfo.GetValue(testDll));
        }
    }
}
