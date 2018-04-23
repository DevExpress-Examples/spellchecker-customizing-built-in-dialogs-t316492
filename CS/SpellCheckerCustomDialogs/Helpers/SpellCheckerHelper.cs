using System.Globalization;
using DevExpress.Web.ASPxSpellChecker;
using DevExpress.Web.Mvc;

namespace SpellCheckerCustomDialogs.Helpers {
    public class SpellCheckerHelper {
        static SpellCheckerSettings settings;
        public static SpellCheckerSettings SCSettings {
            get {
                if(settings == null)
                    settings = CreateSettings();
                return settings;
            }
        }
        public static bool HasCustomDictionary { 
            get {
                foreach(WebDictionary dictionary in SCSettings.Dictionaries) {
                    if(dictionary is ASPxSpellCheckerCustomDictionary && (CultureInfo.Equals(settings.Culture ?? CultureInfo.InvariantCulture, dictionary.GetCulture()) || CultureInfo.InvariantCulture.Equals(dictionary.GetCulture())))
                        return true;
                }
                return false;
            }
        }
        static SpellCheckerSettings CreateSettings() {
            SpellCheckerSettings settings = new SpellCheckerSettings();
            settings.Name = "SpellChecker";
            settings.CallbackRouteValues = new { Action = "IndexPartial", Controller = "Home" };

            settings.CheckedElementID = "textBox";
            settings.Culture = new System.Globalization.CultureInfo("en-US");
            settings.Dictionaries.AddISpellDictionary(d => {
                d.AlphabetPath = "~/Dictionaries/EnglishAlphabet.txt";
                d.GrammarPath = "~/Dictionaries/english.aff";
                d.DictionaryPath = "~/Dictionaries/american.xlg";
                d.CacheKey = "ispellDic";
                d.Culture = new System.Globalization.CultureInfo("en-US");
                d.EncodingName = "Western European (Windows)";
            });
            settings.Dictionaries.AddCustomDictionary(d => {
                d.AlphabetPath = "~/Dictionaries/EnglishAlphabet.txt";
                d.DictionaryPath = "~/Dictionaries/CustomEnglish.dic";
                d.CacheKey = "customDic";
                d.Culture = new CultureInfo("en-US");
                d.EncodingName = "Western European (Windows)";
            });
            settings.ClientSideEvents.BeforeCheck = "function(){ $('#checkSpellingButton').attr('disabled','disabled');; }";
            settings.ClientSideEvents.AfterCheck = "function(){ $('#checkSpellingButton').removeAttr('disabled'); }";

            settings.SettingsForms.SpellCheckFormAction = "CustomSpellCheckFormPartial";
            settings.SettingsForms.SpellCheckOptionsFormAction = "CustomSpellCheckOptionsFormPartial";
            return settings;
        }
    }
}