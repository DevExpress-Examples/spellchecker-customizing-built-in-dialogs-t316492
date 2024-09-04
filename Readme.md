<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608226/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T316492)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/SpellCheckerCustomDialogs/Controllers/HomeController.cs)
* [SpellCheckerHelper.cs](./CS/SpellCheckerCustomDialogs/Helpers/SpellCheckerHelper.cs)
* [CustomSpellCheckFormPartial.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/CustomSpellCheckFormPartial.cshtml)
* [CustomSpellCheckOptionsFormPartial.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/CustomSpellCheckOptionsFormPartial.cshtml)
* [Index.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/Index.cshtml)
* [IndexPartial.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/IndexPartial.cshtml)
<!-- default file list end -->
# SpellChecker - Customizing built-in dialogs


In this example you can learn how to customize spell checking dialogs of ASP.NET  MVC Spell Checker.<br>ASP.NET  MVC Spell Checker provides two built-in forms - one form allows the end-user to accept or reject spelling suggestion and update a custom dictionary with a new word (SpellCheckForm), the other enables changing spell checking options (SpellCheckOptionsForm). <br><br>To render a custom SpellCheckForm,  use the <strong>SpellCheckerSettings.SettingsForms.SpellCheckFormAction</strong> property to specify a custom controller action <strong>CustomSpellCheckFormPartial</strong>. The action <strong>CustomSpellCheckFormPartial</strong> renders a partial view which contains a custom dialog. In this example the custom dialog is the same as the default built-in dialog, to illustrate the method.  Subsequently you can modify it as your needs dictate.<br><br>When modifying the <strong>CustomSpellCheckFormPartial</strong> view, you should follow the guidelines below.<br>1. Use the private client-side Javascript event handlers to interact with the SpellChecker object. Their names are shown in the following picture.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/spellchecker-customizing-built-in-dialogs-t316492/15.1.9+/media/52d44da6-a266-11e5-80bf-00155d62480c.png"><br><br>2. Do not change ID of any element on the form (editors, buttons, the <div> element). They should be the same as the names in this example.<br>3. The <div> element in the dialog (the element that displays the original text with misspelled words underlined) should have the ID conforming to the pattern <em><SpellCheckerExtensionName>_SpellCheckForm_SCCheckedDiv</em><br>4. Themed <div> element is of the <em>dxwscCheckedTextContainer </em>class to use the <em>Default</em> theme. The <em>dxwscCheckedTextContainer_<themename> </em>class specifies the theme <em>themename.</em><br><br>To render a custom SpellCheckOptionsForm,  use the <strong>SpellCheckerSettings.SettingsForms.SpellCheckOptionsFormAction</strong> property to specify a custom controller action <strong>CustomSpellCheckOptionsFormPartial</strong>. The action <strong>CustomSpellCheckOptionsFormPartial</strong> renders a partial view which contains a custom dialog. In this example the custom dialog is the same as the default built-in dialog.  Subsequently you can modify it as your needs dictate.<br>When modifying the <strong>CustomSpellCheckOptionsFormPartial</strong> view, use the private client-side Javascript event handlers as shown in the following picture.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/spellchecker-customizing-built-in-dialogs-t316492/15.1.9+/media/402c62f7-a266-11e5-80bf-00155d62480c.png"><br><br><br>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=spellchecker-customizing-built-in-dialogs-t316492&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=spellchecker-customizing-built-in-dialogs-t316492&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
