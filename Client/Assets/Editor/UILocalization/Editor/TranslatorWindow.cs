using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.Plastic.Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Editor.UILocalization
{
    public class TranslatorWindow : EditorWindow
    {
        private GoogleTranslate googleTranslate;
        private YoudaoTranslate youdaoTranslate;
        private string curLang = "English";
        private Dictionary<string, string> langDict;
        private string[] options;
        private int index;
        
        [MenuItem("Window/UI Translator")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow<TranslatorWindow>("UI Translator");
        }
        
        private void OnEnable()
        {
            // var _langs = File.ReadAllText("Assets/Editor/UILocalization/Languages.json");
            var _langs = File.ReadAllText("Assets/Editor/UILocalization/Languages2.json");
            langDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(_langs);
            List<string> keys = new List<string>(langDict.Count);
            foreach (var entry in langDict) {
                keys.Add(entry.Key);
            }
            options = keys.ToArray();
        }

        private void OnGUI()
        {
            index = EditorGUILayout.Popup("Language", index, options);
            curLang = options[index];

            if (GUILayout.Button("Google Translate")) {
                if (googleTranslate == null) googleTranslate = new GoogleTranslate();
                Translate(googleTranslate);
            }
            
            // if (GUILayout.Button("Baidu Translate")) {
            //     if (youdaoTranslate == null) youdaoTranslate = new YoudaoTranslate();
            //     Translate(youdaoTranslate);
            // }
        }

        private void Translate(BaseTranslate translate)
        {
            Debug.Log("Translating");
            var langCode = langDict[curLang];
            Debug.Log("Language: " + curLang + "(" + langCode + ")");
            foreach (GameObject obj in Selection.gameObjects)
            {
                var texts = obj.GetComponentsInChildren<Text>();
                var TMPtexts = obj.GetComponentsInChildren<TextMeshProUGUI>();
                foreach (var text in texts)
                {
                    SerializedObject serializedObject = new SerializedObject(text);
                    SerializedProperty serializedPropertyText = serializedObject.FindProperty("m_Text");
                    if (serializedPropertyText != null)
                    {
                        var oldText = serializedPropertyText.stringValue;
                        Debug.Log("String value is: " + oldText);

                        translate.TranslateAsync("auto", langCode, oldText, (translated_str) =>
                        {
                            serializedPropertyText.stringValue = translated_str;
                            serializedObject.ApplyModifiedProperties();
                        });
                    }
                }
                foreach (var TMPtext in TMPtexts)
                {
                    SerializedObject serializedObject = new SerializedObject(TMPtext);
                    SerializedProperty serializedPropertyText = serializedObject.FindProperty("m_text");
                    if (serializedPropertyText != null)
                    {
                        var oldText = serializedPropertyText.stringValue;
                        Debug.Log("String value is: " + oldText);

                        translate.TranslateAsync("auto", langCode, oldText, (translated_str) =>
                        {
                            serializedPropertyText.stringValue = translated_str;
                            serializedObject.ApplyModifiedProperties();
                        });
                    }
                }
            }
            Debug.Log("翻译结束");
        }
    }
}