using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;
using Unity.EditorCoroutines.Editor;

/* 参考文章：https://blog.csdn.net/linxinfa/article/details/115723747 */
namespace Editor.UILocalization
{
    public class GoogleTranslate : BaseTranslate
    {
        const string k_Url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}";
        
        public override void TranslateAsync(string sourceLang, string targetLang, string text, Action<string> cb)
        {
            EditorCoroutineUtility.StartCoroutineOwnerless(TranslateAsyncCoroutine(sourceLang, targetLang, text, cb));
        }

        IEnumerator TranslateAsyncCoroutine(string sourceLang, string targetLang, string text, Action<string> cb)
        {
            
            var requestUrl = String.Format(k_Url, new object[] { sourceLang, targetLang, text });
            Debug.Log("url: " + requestUrl);
            UnityWebRequest req = UnityWebRequest.Get(requestUrl);
            yield return req.SendWebRequest();


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

        public override string Translate(string q, string sl = "auto", string tl = "en")
        {
            Debug.Log("Translation function is called.");
            // https://translate.googleapis.com/translate_a/single?client=gtx&dt=t&sl=zh-CN&tl=en&q=你好
            var url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&dt=t&sl={0}&tl={1}&q={2}", sl, tl, WebUtility.UrlEncode(q));
            // var url = String.Format("http://translate.google.cn/translate_a/single?client=gtx&dt=t&sl={0}&tl={1}&q={2}", sl, tl, WebUtility.UrlEncode(q));
            UnityWebRequest www = UnityWebRequest.Get(url);
            www.SendWebRequest();
            while (!www.isDone)
            {
                 
            }
            var response = www.downloadHandler.text;
            Debug.Log("Get request completed!");
            JArray jsonArray = JArray.Parse(response);
            Debug.Log(jsonArray[0][0][0]);
            return jsonArray[0][0][0].ToString();
        }

        public override string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                List<string> responseText = new List<string>();
                Debug.Log(reader.ReadToEnd());
                return reader.ReadToEnd();
            }
        }
    }
}