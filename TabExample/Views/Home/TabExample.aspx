<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<TabExample.Models.tabViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	jQuery UI TabExample
</asp:Content>

<asp:Content ID="headerStuff" ContentPlaceHolderID="headerContent" runat="server">
    
    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();               
        });    
	</script>
	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>jQuery Tabs Example</h2>
    
    <div id="tabs">
	    <ul>
		    <li><a href="#tabs-1">Text 1</a></li>
		    <li><a href="#tabs-2">Text 2</a></li>
		    <li><a href="#tabs-3">Text 3</a></li>
	    </ul>
	    <div id="tabs-1">
            <% Html.RenderPartial("_tab1", Model);  %>		    
	    </div>
	    <div id="tabs-2">
	        <% Html.RenderPartial("_tab2", Model);  %>		    
	    </div>
	    <div id="tabs-3">
	        <% Html.RenderPartial("_tab3", Model);  %>		    
	    </div>
    </div>    

</asp:Content>
