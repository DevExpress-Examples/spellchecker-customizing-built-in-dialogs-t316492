using System.Web.Mvc;

namespace SpellCheckerCustomDialogs.Controllers {
    public class HomeController : Controller {
        const string SampleText = "To enable spell checking you need a dictiopnary file, an affix grammar file and an alphabet file. A dictionary fuile is generally a variation of correctly spelled words and the grammar rules that  are written asx a form of regular expressions. Affix means to attach or append. Affix rules are appended to words in the dicionary to recognize different word forms. A dictionary can be created with a text editor.\r\nThe LevenshteinDistance is a value used to measure the proximity of words. This value is used to indicate the maximum number od steps requirecd to convert a messpelled word into a a suggested word.";
        public ActionResult Index() {
            return View((object)SampleText);
        }
        public ActionResult IndexPartial() {
            return PartialView();
        }
        public ActionResult CustomSpellCheckFormPartial() {
            return PartialView("CustomSpellCheckFormPartial");
        }
        public ActionResult CustomSpellCheckOptionsFormPartial() {
            return PartialView("CustomSpellCheckOptionsFormPartial");
        }
    }
}