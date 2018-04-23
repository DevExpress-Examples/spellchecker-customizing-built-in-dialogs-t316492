@ModelType String

<script type="text/javascript">
$(document).ready(function(){
    $("#checkSpellingButton").click(function(){
        SpellChecker.Check();
    });
});
</script>

@Html.Partial("IndexPartial")

<input id="checkSpellingButton" type="button" value = "Check Spelling ..." />
<br />
<br />
@Html.TextArea("textBox", Model, New With {.style = "width: 300px; height: 150px;"})