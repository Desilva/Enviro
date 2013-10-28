﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Register TagPrefix="telerik" Assembly="Telerik.ReportViewer.WebForms" Namespace="Telerik.ReportViewer.WebForms" %>

<script runat="server">      
    public override void VerifyRenderingInServerForm(Control control)
    {
        // to avoid the server form (<form runat="server">) requirement
    }

    protected override void OnLoad(EventArgs e)
    {
        // bind the report viewer
        base.OnLoad(e);
        Telerik.Reporting.InstanceReportSource reportSource = new Telerik.Reporting.InstanceReportSource();
        reportSource.ReportDocument = new env.Report.Graphics();
        reportSource.Parameters.Add(new Telerik.Reporting.Parameter("TYPE", ViewBag.type));
        this.Graphics.ReportSource = reportSource;
    }

</script>
<html>
    <head id="Head1" runat="server">
    </head>
    <body>
        <form clientidmode="Static" id="frep" runat="server"><div>
            <telerik:ReportViewer ID="Graphics" runat="server" 
                width="100%" height="600px"
                ZoomMode="FullPage"/>
                </div>
        </form>
    </body>
</html>
<script type="text/javascript">
    $(document).ready(function () {
        //$("#ReportViewer1ReportFrame").load(function () {
        var int = self.setInterval(function () { clock() }, 200);
        $('#Graphics_ReportToolbar_NavGr_CurrentPage_CurrentPage').css('height', '20px');
        $('#Graphics_ReportToolbar_NavGr_CurrentPage_CurrentPage').css('line-height', '20px');
        $('#Graphics_ReportToolbar_NavGr_CurrentPage_CurrentPage').css('padding', '0 6px');
        $('#Graphics_ReportToolbar_NavGr_CurrentPage_CurrentPage').css('margin-bottom', '0px');
        $('#Graphics_ReportToolbar_NavGr_CurrentPage_CurrentPage').css('width', '34px');
        $('#Graphics_ReportToolbar_ExportGr_FormatList_DropDownList').css('height', '20px');
        $('#Graphics_ReportToolbar_ExportGr_FormatList_DropDownList').css('line-height', '20px');
        $('#Graphics_ReportToolbar_ExportGr_FormatList_DropDownList').css('padding', '0 6px');
        $('#Graphics_ReportToolbar_ExportGr_FormatList_DropDownList').css('margin-bottom', '0px');
        var clock = function () {
            var doc = document.getElementById("GraphicsReportFrame").contentWindow.document;
            //alert(doc.body.getElementsByClassName("panel3")[0]);
            if (doc.getElementById("page1") != null) {
                doc.getElementById("page1").style.margin = "0";
            }
        }



        //});

    });
</script>