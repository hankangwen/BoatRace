using System;

namespace BoatRaceEditor.UILocalization
{
    public abstract class BaseTranslate
    {
        public abstract void TranslateAsync(string sourceLang, string targetLang, string text, Action<string> cb);
        public abstract string Translate(string q, string sl = "auto", string tl = "en");
        public abstract string Get(string uri);
    }
}