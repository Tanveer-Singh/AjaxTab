<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TabExample.Models.tabViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	jQuery UI TabExample
</asp:Content>

<asp:Content ID="headerStuff" ContentPlaceHolderID="headerContent" runat="server">
    
    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();
            getContentTab (1);
        });

        function getContentTab(index) {
            var url='<%= Url.Content("~/Home/getAjaxTab") %>/' + index;
            var targetDiv = "#tabs-" + index;
            var ajaxLoading = "<img id='ajax-loader' src='<%= Url.Content("~/Content") %>/ajax-loader.gif' align='left' height='28' width='28'>";
                       
            $(targetDiv).html("<p>" + ajaxLoading + " Loading...</p>"); 
            
            $.get(url,null, function(result) {
                $(targetDiv).html(result);
            });
        }
        
	</script>
	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>jQuery Ajax Tabs Example</h2>
    
    <div id="tabs">
	    <ul>
		    <li><a href="#tabs-1" onclick="getContentTab(1);">Text 1</a></li>
		    <li><a href="#tabs-2" onclick="getContentTab(2);">Text 2</a></li>
		    <li><a href="#tabs-3" onclick="getContentTab(3);">Text 3</a></li>
	    </ul>
	    <div id="tabs-1">
            
	    </div>
	    <div id="tabs-2">
	        
	    </div>
	    <div id="tabs-3">
	        
	    </div>
    </div>    

</asp:Content>
