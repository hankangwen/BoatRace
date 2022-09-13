using System;
using System.Collections;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

public class TestEditorCoroutine : EditorWindow
{
    private EditorCoroutine curEditorCoroutine;
    private bool stopWaiting = false;
    
    [MenuItem("Tools/TestEditorCoroutine")]
    public static void ShowWindow()
    {
        GetWindow<TestEditorCoroutine>("TestEditorCoroutine").Show();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Start")) {
            curEditorCoroutine = EditorCoroutineUtility.StartCoroutineOwnerless(
                TranslateAsync("auto", "en", "你好", (str) =>
                {
                    Debug.LogFormat("翻译后{0}", str);
                }));
        }
        
        if (GUILayout.Button("Stop")) {
            EditorCoroutineUtility.StopCoroutine(curEditorCoroutine);
        }
        
        if (GUILayout.Button("Until")) {
            stopWaiting = true;
        }
    }
    
    const string k_Url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}";
    
    IEnumerator TranslateAsync(string sourceLang, string targetLang, string text, Action<string> cb)
    {
        var requestUrl = String.Format(k_Url, new object[] { sourceLang, targetLang, text });
        Debug.Log("url: " + requestUrl);
        UnityWebRequest req = UnityWebRequest.Get(requestUrl);
        yield return req.SendWebRequest();
        Debug.Log("url2: " + requestUrl);

        yield return new WaitUntil(CheckCanUntil);
        Debug.Log("url3: " + requestUrl);

        if (string.IsNullOrEmpty(req.error))
        {
            Debug.Log(req.downloadHandler.text);
            JSONArray jsonArray = JSONConvert.DeserializeArray(req.downloadHandler.text);
            jsonArray = (JSONArray)(jsonArray[0]);
            jsonArray = (JSONArray)(jsonArray[0]);
            cb((string)jsonArray[0]);
        }
        else
        {
            cb(req.error);
        }
    }

    private bool CheckCanUntil()
    {
        return stopWaiting;
    }
    
    IEnumerator TestCoroutine(string name, int age)
    {
        Debug.LogFormat("--- Test_Cor begin, name: {0}, age: {1}", name, age);
        for (int i = 0; i < 3; i++) {
            Debug.LogFormat("--- Test_Cor doing, cnt: {0}", i);
            yield return new EditorWaitForSeconds(1); // 这个是 editor 的 WaitForSeconds
        }
        Debug.LogFormat("--- Test_Cor begin, name: {0}, age: {1}", name, age);
    }
}
