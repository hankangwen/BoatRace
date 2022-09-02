using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Editor.UILocalization
{
    public class YoudaoTranslate : BaseTranslate
    {
        public override void TranslateAsync(string sourceLang, string targetLang, string text, Action<string> cb)
        {
            
        }

        public override string Translate(string q, string sl = "auto", string tl = "en")
        {
            Debug.Log("Translation function is called.");
            var url = string.Format("https://fanyi.youdao.com/translate?&doctype=json&type=AUTO&i=english");
            //https://fanyi.youdao.com/translate?&doctype=json&type=ZH_CN2EN&i=%E4%BD%A0%E5%A5%BD
            // https://fanyi.youdao.com/translate?&doctype=json&type=EN2ZH_CN&i=english
            UnityWebRequest www = UnityWebRequest.Get(url);
            www.SendWebRequest();
            while (!www.isDone)
            {
                 
            }
            var response = www.downloadHandler.text;
            JObject jObject = JObject.Parse(response);
            JArray jsonArray = JArray.Parse(jObject["translateResult"].ToString());
            var result = jsonArray[0][0]["tgt"].ToString();
            Debug.Log(result);
            return result;
        }

        public override string Get(string uri)
        {
            throw new System.NotImplementedException();
        }
    }
}