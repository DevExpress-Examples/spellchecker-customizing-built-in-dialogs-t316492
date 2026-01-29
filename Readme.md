<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608226/25.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T316492)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# ASP.NET MVC SpellChecker - Customize built-in dialogs

This example customizes built-in spell check dialogs in the [ASP.NET MVC Spell Checker](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.MVCxSpellChecker).


## Implementation Details

The DevExpress ASP.NET MVC Spell Checker ships with two built-in forms:

1. **SpellCheckForm** allows users to accept/reject spelling suggestions and update the dictionary with new words.

2. **SpellCheckOptionsForm** allows users to configure spell check options.

To render custom **SpellCheckForm** and **SpellCheckOptionsForm**, use [SpellCheckerSettings.SettingsForms.SpellCheckFormAction](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.MVCxSpellCheckerFormsSettings.SpellCheckFormAction) and [SpellCheckerSettings.SettingsForms.SpellCheckOptionsFormAction](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.MVCxSpellCheckerFormsSettings.SpellCheckOptionsFormAction) properties:

```csharp
settings.SettingsForms.SpellCheckFormAction = "CustomSpellCheckFormPartial";
settings.SettingsForms.SpellCheckOptionsFormAction = "CustomSpellCheckOptionsFormPartial";
```

`CustomSpellCheckFormPartial` and `CustomSpellCheckOptionsFormPartial` actions render partial views that contain custom dialogs. These dialogs are identical to built-in ones. You can modify them as needs dictate using private client-side Javascript event handlers (see images below):

* `CustomSpellCheckFormPartial` view:  
    ![Check Spelling](./media/check-spelling.png)
* `CustomSpellCheckOptionsFormPartial` view:  
    ![Spelling Options](./media/spelling-options.png)

## Files to Review

* [HomeController.cs](./CS/SpellCheckerCustomDialogs/Controllers/HomeController.cs)
* [SpellCheckerHelper.cs](./CS/SpellCheckerCustomDialogs/Helpers/SpellCheckerHelper.cs)
* [CustomSpellCheckFormPartial.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/CustomSpellCheckFormPartial.cshtml)
* [CustomSpellCheckOptionsFormPartial.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/CustomSpellCheckOptionsFormPartial.cshtml)
* [Index.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/Index.cshtml)
* [IndexPartial.cshtml](./CS/SpellCheckerCustomDialogs/Views/Home/IndexPartial.cshtml)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-spell-checker-customize-built-in-dialogs&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-spell-checker-customize-built-in-dialogs&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

