Imports System.Web.Mvc
Imports Microsoft.VisualBasic

Namespace SpellCheckerCustomDialogs_vb.Controllers
    Public Class HomeController
        Inherits Controller

        Private Const SampleText As String = "To enable spell checking you need a dictiopnary file, an affix grammar file and an alphabet file. A dictionary fuile is generally a variation of correctly spelled words and the grammar rules that  are written asx a form of regular expressions. Affix means to attach or append. Affix rules are appended to words in the dicionary to recognize different word forms. A dictionary can be created with a text editor." & ControlChars.CrLf & "The LevenshteinDistance is a value used to measure the proximity of words. This value is used to indicate the maximum number od steps requirecd to convert a messpelled word into a a suggested word."
        Public Function Index() As ActionResult
            Return View(DirectCast(SampleText, Object))
        End Function
        Public Function IndexPartial() As ActionResult
            Return PartialView()
        End Function
        Public Function CustomSpellCheckFormPartial() As ActionResult
            Return PartialView("CustomSpellCheckFormPartial")
        End Function
        Public Function CustomSpellCheckOptionsFormPartial() As ActionResult
            Return PartialView("CustomSpellCheckOptionsFormPartial")
        End Function
    End Class
End Namespace