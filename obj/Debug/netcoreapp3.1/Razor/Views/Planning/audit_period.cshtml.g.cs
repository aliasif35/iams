#pragma checksum "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4faef85c9346a5839342249390f02a747a28ff5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planning_audit_period), @"mvc.1.0.view", @"/Views/Planning/audit_period.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\_ViewImports.cshtml"
using IAMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\_ViewImports.cshtml"
using IAMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4faef85c9346a5839342249390f02a747a28ff5f", @"/Views/Planning/audit_period.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310c24deff44d439f8f90e7415d1dd6041f42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Planning_audit_period : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
  
    ViewData["Title"] = "Audit Period";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">
    .planDetails:hover {
        font-size: 100%;
        font-weight: 600;
        cursor: pointer;
    }
</style>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#sidebar_policy').hide();
        $('#listOfAuditPeriodsContainer').hide();
    });
    function ShowDepartmentAuditPeriods() {
        if ($('#deptSelectionBox option:selected').val() == 0)
            $('#listOfAuditPeriodsContainer').hide();
        else {
            $('#listOfAuditPeriodsContainer').show();

            $.ajax({
                url: ""/Planning/audit_periods"",
                type: ""POST"",
                data: {
                    'dept_code': $('#deptSelectionBox option:selected').val()
                },
                cache: false,
                success: function (data) {
                    $('#listOfAuditPeriods tbody').empty();
                    console.log(data);
                    var srNo = 1;
                    $.each(data, fu");
            WriteLiteral(@"nction (index, period) {
                        var status = 'Approved';
                        period.starT_DATE = period.starT_DATE.split('T')[0];
                        period.enD_DATE = period.enD_DATE.split('T')[0];
                        $('#listOfAuditPeriods tbody').append('<tr id=teamcode_' + period.id + '><td class=""searchable""><p class=""fw-normal mb-1"">' + srNo + '</p></td><td class=""searchable""><p class=""fw-normal mb-1"">' + period.description + ' </p></td><td class=""searchable""><p class=""empName fw-normal mb-1"">' + period.starT_DATE + ' </p></td><td class=""searchable""><p class=""empName fw-normal mb-1"">' + period.enD_DATE + ' </p></td><td class=""searchable""><p class=""empName fw-normal mb-1"">' + status + ' </p></td><td><small onclick=""getAuditPlan(' + period.id+')"" class=""text-danger planDetails"">Details</small></td></tr>');
                        srNo++;
                    });

                },
                dataType: ""json"",
            });
        }
    }
    function setup");
            WriteLiteral(@"NewAuditPeriod() {
        $('#setupAuditPeriod').modal('show');
        $('#periodDescriptionModalField').val('');
        $('#periodStartModalField').val('');
        $('#periodEndModalField').val('');
        $.each($('.deptCheckBoxes'), function (index, chkbox) {
            if ($(chkbox).is(':checked')) {
                $(chkbox).click();
            }
        });

    }
    function publishNewAuditPeriodChanges() {
        var desc=$('#periodDescriptionModalField').val();
        var stDate=$('#periodStartModalField').val();
        var edDate = $('#periodEndModalField').val();
        var deptIds = [];
        $.each($('.deptCheckBoxes'), function (index, chkbox) {
            if ($(chkbox).is(':checked')) {
                deptIds.push($(chkbox).attr('dept-id'));
            }
        });
        if (desc == """" || stDate == """" || edDate == """" || deptIds.length == 0) {
            alert(""Missing Mandatory fields"");
            return;
        }

        //var date = '21/01/2");
            WriteLiteral(@"015';
        var ds = new Date(stDate.split(""/"").reverse().join(""-""));
        var dd = ds.getDate();
        var mm = ds.getMonth() + 1;
        var yy = ds.getFullYear();
        var startDate = (""0"" + mm).slice(-2) + ""/"" + (""0"" + dd).slice(-2) + ""/"" + yy;

        var de = new Date(edDate.split(""/"").reverse().join(""-""));
        var dd = de.getDate();
        var mm = de.getMonth() + 1;
        var yy = de.getFullYear();
        var endDate = (""0"" + mm).slice(-2) + ""/"" + (""0"" + dd).slice(-2) + ""/"" + yy;
         $.ajax({
            url: ""/Planning/add_audit_period"",
            type: ""POST"",
            data: {
                'DESCRIPTION': desc,
                'STARTDATE': startDate,
                'ENDDATE': endDate,
                'DEPARTMENT_IDS': deptIds
            },
            cache: false,
            success: function (data) {
                location.reload();
            },
            dataType: ""json"",
        });
    }
    function getAuditPlan(periodId) {
");
            WriteLiteral(@"        window.location.href = ""/Planning/audit_plan?dept="" + $('#deptSelectionBox option:selected').val()+""&periodId="" + periodId;
    }

</script>
<div class=""row mt-3"">
    <div class=""row col-md-12"">
        <div class=""col-md-6"" style=""padding-left:0px;"">
            <h2 style=""color: #45c545;"">AUDIT PERIOD</h2>
        </div>
        <div class=""col-md-6"">
            <button onclick=""setupNewAuditPeriod();"" class=""btn btn-danger"" style=""float:right;"">Add New Period</button>
        </div>
    </div>
    <h5>Select Department</h5>
    <select id=""deptSelectionBox"" onchange=""ShowDepartmentAuditPeriods();"" class=""form-select form-control"" aria-label=""Default select example"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4faef85c9346a5839342249390f02a747a28ff5f8878", async() => {
                WriteLiteral("Select Your Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 119 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
          
            if (ViewData["AuditDepartments"] != null)
            {
                foreach (var item in (dynamic)(ViewData["AuditDepartments"]))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4faef85c9346a5839342249390f02a747a28ff5f10748", async() => {
#nullable restore
#line 124 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
                                                          Write(item.NAME);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
                       WriteLiteral(item.CODE);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 124 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
AddHtmlAttributeValue("", 5171, item.CODE, 5171, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 125 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </select>
</div>
<div id=""listOfAuditPeriodsContainer"" class=""row mt-3 hide"">
    
    <br />
    <table id=""listOfAuditPeriods"" class=""table align-middle mb-0 mt-2 bg-white table-hover table-striped"">
        <thead class=""bg-light"">
            <tr>
                <th class=""col-md-1"">Sr No.</th>
                <th class=""col-md-3"">Description</th>
                <th class=""col-md-2"">Start Date</th>
                <th class=""col-md-2"">End Date</th>
                <th class=""col-md-2"">Status</th>
                <th class=""col-md-2""></th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>

<div id=""setupAuditPeriod"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger text-white"">
                <h5 class=""modal-title"">New Audit Period</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria");
            WriteLiteral("-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4faef85c9346a5839342249390f02a747a28ff5f14513", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""periodDescriptionModalField"">Description<span class=""text-danger"">*</span></label>
                        <input required type=""text"" class=""form-control"" id=""periodDescriptionModalField"" aria-describedby=""brcode"" placeholder=""Description"">
                    </div>
                    <div class=""form-group"">
                        <label for=""periodStartModalField"">Start Date<span class=""text-danger"">*</span></label>
                        <input required type=""date"" class=""form-control"" id=""periodStartModalField"" aria-describedby=""brcode"" placeholder=""Start Date"">
                    </div>
                    <div class=""form-group"">
                        <label for=""periodEndModalField"">End Date<span class=""text-danger"">*</span></label>
                        <input required type=""date"" class=""form-control"" id=""periodEndModalField"" aria-describedby=""brcode"" placeholder=""End Date"">
                    </di");
                WriteLiteral("v>\r\n");
                WriteLiteral("                        <h5 for=\"periodEndModalField\">Audit Conducted By<span class=\"text-danger\">*</span></h5>\r\n");
#nullable restore
#line 175 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
                        if (ViewData["AuditDepartments"] != null)
                        {
                            foreach (var item in (dynamic)(ViewData["AuditDepartments"]))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"form-group\">\r\n                                    <div class=\"row w-100 col-md-12\">\r\n                                        <div class=\"col-md-10\">\r\n                                            <small");
                BeginWriteAttribute("for", " for=\"", 8083, "\"", 8108, 2);
                WriteAttributeValue("", 8089, "checkbox_", 8089, 9, true);
#nullable restore
#line 182 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
WriteAttributeValue("", 8098, item.CODE, 8098, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 182 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
                                                                        Write(item.NAME);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                        </div>\r\n                                        <div class=\"col-md-2\">\r\n                                            <input type=\"checkbox\" class=\"deptCheckBoxes\"");
                BeginWriteAttribute("dept-id", " dept-id=\"", 8331, "\"", 8351, 1);
#nullable restore
#line 185 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
WriteAttributeValue("", 8341, item.CODE, 8341, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8352, "\"", 8376, 2);
                WriteAttributeValue("", 8357, "checkbox_", 8357, 9, true);
#nullable restore
#line 185 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
WriteAttributeValue("", 8366, item.CODE, 8366, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"float:right;\"");
                BeginWriteAttribute("value", " value=\"", 8398, "\"", 8416, 1);
#nullable restore
#line 185 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
WriteAttributeValue("", 8406, item.CODE, 8406, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"...\">\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 189 "E:\ISAD Official\IAMS New\IAMS\IAMS\Views\Planning\audit_period.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button onclick=""publishNewAuditPeriodChanges();"" type=""button"" class=""btn btn-danger"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
