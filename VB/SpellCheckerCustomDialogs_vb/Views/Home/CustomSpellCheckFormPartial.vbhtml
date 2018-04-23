<table id="dxMainSpellCheckFormTable" class="dxwscDlgMainSpellCheckFormTable">
    <tr>
        <td class="dxwscDlgContentSCFormContainer">
            <table id="dxSpellCheckForm" class="dxwscDlgSpellCheckForm">
                <tr>
                    <td colspan="2">
                        Not in Dictionary:
                    </td>
                </tr>
                <tr>
                    <td class="dxwscDlgCheckedDivContainer dx-valt">
                        <div class="dxwscCheckedTextContainer" id="@String.Format("{0}_SpellCheckForm_SCCheckedDiv", SpellCheckerHelper.SCSettings.Name)">
                        </div>
                    </td>
                    <td class="dxwscDlgButtonTableContainer dx-valt">
                        <table id="topButtonsTable" class="dxwscDlgButtonTable">
                            <tr>
                                <td>
                                    @Html.DevExpress().Button( _
                                        Sub(s)
                                                s.Name = "btnIgnore"
                                                s.Text = "Ignore Once"
                                                s.Styles.Style.CssClass = "dxwscDlgSpellCheckBtn"
                                                s.ClientSideEvents.Click = "function(s, e) {ASPx.SCIgnore();}"
                                        End Sub).GetHtml()
                                </td>
                            </tr>
                            <tr>
                                <td class="dxwscDlgVerticalSeparator dx-valt">
                                    @Html.DevExpress().Button( _
                                        Sub(s)
                                                s.Name = "btnIgnoreAll"
                                                s.Text = "Ignore All"
                                                s.Styles.Style.CssClass = "dxwscDlgSpellCheckBtn"
                                                s.ClientSideEvents.Click = "function(s, e) {ASPx.SCIgnoreAll();}"
                                        End Sub).GetHtml()
                                </td>
                            </tr>
                            <tr>
                                <td class="dxwscDlgVerticalSeparator dx-valt">
                                    @Html.DevExpress().Button( _
                                        Sub(s)
                                                s.Name = "btnAddToDictionary"
                                                s.Text = "Add to Dictionary"
                                                s.Enabled = SpellCheckerHelper.HasCustomDictionary
                                                s.Styles.Style.CssClass = "dxwscDlgSpellCheckBtn"
                                                s.ClientSideEvents.Click = "function(s, e) {ASPx.SCAddToDictionary();}"
                                        End Sub).GetHtml()
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="dxwscDlgChangeToText">
                        Change To:
                    </td>
                </tr>
                <tr>
                    <td class="dxwscDlgChangeToPanelContainer">
                        @Html.DevExpress().Panel( _
                            Sub(s)
                                    s.Name = "ChangeToPanel"
                                    s.Width = Unit.Percentage(100)
                                    s.DefaultButton = "btnChange"
                                    s.SetContent( _
                                        Sub()
                                                ViewContext.Writer.Write("<table style='width:100%'>")
                                                ViewContext.Writer.Write("<tr><td style='width:100%' class='dxwscDlgVerticalSeparator dx-valt'>")
                                                Html.DevExpress().TextBox( _
                                                    Sub(tb)
                                                    tb.Name = "_dxeSCTxtChangeTo"
                                                    tb.Width = Unit.Percentage(100)
                                                    tb.Properties.ClientSideEvents.KeyPress = "function(s, e) {ASPx.SCTextBoxKeyPress(s, e);}"
                                                    tb.Properties.ClientSideEvents.KeyDown = "function(s, e) {ASPx.SCTextBoxKeyDown(s,e);}"
                                            End Sub)
                                                ViewContext.Writer.Write("</td></tr>")
                                                ViewContext.Writer.Write("<tr><td class='dxwscDlgListBoxContainer dx-val'>")
                                                Html.DevExpress().ListBox( _
                                                    Sub(lb)
                                                    lb.Name = "_dxeSCSuggestionsListBox"
                                                    lb.Width = Unit.Percentage(100)
                                                    lb.Height = Unit.Pixel(100)
                                                    lb.Properties.ClientSideEvents.ItemDoubleClick = "function(s, e) {ASPx.SCListBoxItemDoubleClick(s, e);}"
                                                    lb.Properties.ClientSideEvents.SelectedIndexChanged = "function(s, e) {ASPx.SCListBoxItemChanged(s,e);}"
                                            End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr>")
                                                ViewContext.Writer.Write("</table>")
                                        End Sub)
                            End Sub).GetHtml()
                    </td>
                    <td class="dxwscDlgButtonTableContainer dx-valt">
                        <table id="bottomButtonsTable" class="dxwscDlgButtonTable">
                            <tr>
                                <td class="dx-valt">
                                    @Html.DevExpress().Button( _
                                        Sub(s)
                                                s.Name = "_dxeSCBtnChange"
                                                s.Text = "Change"
                                                s.Styles.Style.CssClass = "dxwscDlgSpellCheckBtn"
                                                s.ClientSideEvents.Click = "function(s, e) {ASPx.SCChange();}"
                                        End Sub).GetHtml()
                                </td>
                            </tr>
                            <tr>
                                <td class="dxwscDlgVerticalSeparator dx-valt">
                                    @Html.DevExpress().Button( _
                                        Sub(s)
                                                s.Name = "_dxeSCBtnChangeAll"
                                                s.Text = "Change All"
                                                s.Styles.Style.CssClass = "dxwscDlgSpellCheckBtn"
                                                s.ClientSideEvents.Click = "function(s, e) {ASPx.SCChangeAll();}"
                                        End Sub).GetHtml()
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxwscDlgFooter">
            @Html.DevExpress().Button( _
                Sub(s)
                        s.Name = "btnOptions"
                        s.Text = "Options..."
                        s.Styles.Style.CssClass = "dxwscDlgFooterBtn"
                        s.ClientSideEvents.Click = "function(s, e) {ASPx.SCShowOptionsForm(true);}"
                End Sub).GetHtml()
            @Html.DevExpress().Button( _
                Sub(s)
                        s.Name = "btnClose"
                        s.Text = "Close"
                        s.Styles.Style.CssClass = "dxwscDlgFooterBtn"
                        s.ClientSideEvents.Click = "function(s, e) {ASPx.SCDialogComplete(false);}"
                End Sub).GetHtml()
        </td>
    </tr>
</table>