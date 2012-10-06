<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<TabExample.Models.tabViewModel>" %>

<h3>Tab Text 2</h3>

<p>
    <%= Model.TabText2 %>
</p>

<p class ="ui-state-error">
    <%= TabExample.Helpers.jQueryUiHelper.InsertIcon("icon-alert") %>
    Error Text !
</p>
