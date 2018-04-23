<table id="dxMainSpellCheckOptionsFormTable" class="dxwscDlgMainSpellCheckOptionsFormTable">
    <tr>
        <td class="dxwscDlgContentSCOptionsFormContainer">
            <table id="dxOptionsForm" class="dxwscDlgOptionsForm" style="width:100%">
                <tr>
                    <td>
                        @Html.DevExpress().RoundPanel( _
                            Sub(s)
                                    s.Name = "pnlOptions"
                                    s.HeaderText = "General options"
                                    s.Width = Unit.Percentage(100)

                                    s.SetContent( _
                                        Sub()
                                                ViewContext.Writer.Write("<table><tr><td>")
                                                Html.DevExpress().CheckBox( _
                                                    Sub(cb)
                                                            cb.Name = "chkbUpperCase"
                                                            cb.Text = "Ignore words in UPPERCASE"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr><tr><td>")
                                                Html.DevExpress().CheckBox( _
                                                    Sub(cb)
                                                            cb.Name = "chkbMixedCase"
                                                            cb.Text = "Ignore words in MiXeDcAsE"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr><tr><td>")
                                                Html.DevExpress().CheckBox( _
                                                    Sub(cb)
                                                            cb.Name = "chkbNumbers"
                                                            cb.Text = "Ignore words with numbers"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr><tr><td>")
                                                Html.DevExpress().CheckBox( _
                                                    Sub(cb)
                                                            cb.Name = "chkbEmails"
                                                            cb.Text = "Ignore e-mails"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr><tr><td>")
                                                Html.DevExpress().CheckBox( _
                                                    Sub(cb)
                                                            cb.Name = "chkbUrls"
                                                            cb.Text = "Ignore URLs"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr><tr><td>")
                                                Html.DevExpress().CheckBox( _
                                                    Sub(cb)
                                                            cb.Name = "chkbTags"
                                                            cb.Text = "Ignore markup tags"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr></table>")
                                        End Sub)
                            End Sub).GetHtml()
                    </td>
                </tr>
                <tr>
                    <td class="dxwscDlgLanguagePanel">
                        @Html.DevExpress().RoundPanel( _
                            Sub(s)
                                    s.Name = "pnlLanguageSelection"
                                    s.HeaderText = "International dictionaries"
                                    s.Width = Unit.Percentage(100)

                                    s.SetContent( _
                                        Sub()
                                                ViewContext.Writer.Write("<table style='width:100%;'><tr><td colspan='2'>")
                                                Html.DevExpress().Label( _
                                                    Sub(lb)
                                                            lb.Name = "lblChooseDictionary"
                                                            lb.Text = "Choose which dictionary to use when checking your spelling."
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr><tr><td class='dxwscDlgLanguageLabelCell'>")
                                                Html.DevExpress().Label( _
                                                    Sub(lb)
                                                            lb.Name = "lblLanguage"
                                                            lb.Text = "Language:"
                                                            lb.AssociatedControlName = "comboLanguage"
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td><td class='dxwscDlgLanguageComboCell'>")
                                                Html.DevExpress().ComboBox( _
                                                    Sub(cmb)
                                                            cmb.Name = "comboLanguage"
                                                            cmb.Width = Unit.Percentage(100)
                                                    End Sub).Render()
                                                ViewContext.Writer.Write("</td></tr></table/")
                                        End Sub)
                            End Sub).GetHtml()
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="dxwscDlgFooter">
            @Html.DevExpress().Button( _
                Sub(s)
                        s.Name = "btnOK"
                        s.Text = "OK"
                        s.Styles.Style.CssClass = "dxwscDlgFooterBtn"
                        s.ClientSideEvents.Click = "function(s, e) {ASPx.SCDialogComplete(true);}"
                End Sub).GetHtml()
            @Html.DevExpress().Button( _
                Sub(s)
                        s.Name = "btnCancel"
                        s.Text = "Cancel"
                        s.Styles.Style.CssClass = "dxwscDlgFooterBtn"
                        s.ClientSideEvents.Click = "function(s, e) {ASPx.SCDialogComplete(false);}"
                End Sub).GetHtml()
        </td>
    </tr>
</table>