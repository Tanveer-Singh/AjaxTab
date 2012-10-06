<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<TabExample.Models.tabViewModel>" %>

<h3>Tab Text 1</h3>

<p>
    <%= Model.TabText1 %>
</p>

<p class ="ui-state-highlight"><%= TabExample.Helpers.jQueryUiHelper.InsertIcon("icon-lightbulb") %>Highlighted Text !</p>
