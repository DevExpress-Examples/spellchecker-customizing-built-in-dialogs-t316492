Imports System.Globalization
Imports DevExpress.Web.ASPxSpellChecker
Imports DevExpress.Web.Mvc

Namespace SpellCheckerCustomDialogs_vb.Helpers
	Public Class SpellCheckerHelper
		Private Shared settings As SpellCheckerSettings
        Public Shared ReadOnly Property SCSettings() As SpellCheckerSettings
            Get
                If settings Is Nothing Then
                    settings = CreateSettings()
                End If
                Return settings
            End Get
        End Property
        Public Shared ReadOnly Property HasCustomDictionary() As Boolean
            Get
                For Each dictionary As WebDictionary In SCSettings.Dictionaries
                    If TypeOf dictionary Is ASPxSpellCheckerCustomDictionary AndAlso (CultureInfo.Equals(If(settings.Culture, CultureInfo.InvariantCulture), dictionary.GetCulture()) OrElse CultureInfo.InvariantCulture.Equals(dictionary.GetCulture())) Then
                        Return True
                    End If
                Next dictionary
                Return False
			End Get
		End Property
		Private Shared Function CreateSettings() As SpellCheckerSettings
			Dim settings As New SpellCheckerSettings()
			settings.Name = "SpellChecker"
			settings.CallbackRouteValues = New With {Key .Action = "IndexPartial", Key .Controller = "Home"}

			settings.CheckedElementID = "textBox"
			settings.Culture = New System.Globalization.CultureInfo("en-US")
			settings.Dictionaries.AddISpellDictionary(Sub(d)
				d.AlphabetPath = "~/Dictionaries/EnglishAlphabet.txt"
				d.GrammarPath = "~/Dictionaries/english.aff"
				d.DictionaryPath = "~/Dictionaries/american.xlg"
				d.CacheKey = "ispellDic"
				d.Culture = New System.Globalization.CultureInfo("en-US")
				d.EncodingName = "Western European (Windows)"
			End Sub)
			settings.Dictionaries.AddCustomDictionary(Sub(d)
				d.AlphabetPath = "~/Dictionaries/EnglishAlphabet.txt"
				d.DictionaryPath = "~/Dictionaries/CustomEnglish.dic"
				d.CacheKey = "customDic"
				d.Culture = New CultureInfo("en-US")
				d.EncodingName = "Western European (Windows)"
			End Sub)
			settings.ClientSideEvents.BeforeCheck = "function(){ $('#checkSpellingButton').attr('disabled','disabled');; }"
            settings.ClientSideEvents.AfterCheck = "function(){ $('#checkSpellingButton').removeAttr('disabled'); }"

			settings.SettingsForms.SpellCheckFormAction = "CustomSpellCheckFormPartial"
			settings.SettingsForms.SpellCheckOptionsFormAction = "CustomSpellCheckOptionsFormPartial"
			Return settings
		End Function
	End Class
End Namespace