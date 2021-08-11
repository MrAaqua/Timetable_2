#pragma checksum "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98eca9662f0eb7b355f392acecf69651a839907"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Informer_TimetableFinal), @"mvc.1.0.view", @"/Views/Informer/TimetableFinal.cshtml")]
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
#line 1 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\_ViewImports.cshtml"
using Timetable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\_ViewImports.cshtml"
using Timetable.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98eca9662f0eb7b355f392acecf69651a839907", @"/Views/Informer/TimetableFinal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba68457b86b005f8540fae06e38dfd94cc060e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Informer_TimetableFinal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Timetable.Domains.Headteacher.TimetableHead>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Расписание уроков</h1>\r\n<h4 align=\"center\">");
#nullable restore
#line 4 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
              Write(ViewData["className"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4 align=\"center\">");
#nullable restore
#line 5 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
              Write(ViewData["dayName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<table class=""table"">
    <thead>
    <tr>
        <th>
            Время звонков
        </th>
        <th>
            Предмет
        </th>
        <th>
            Преподаватель
        </th>
        <th>
            Кабинет
        </th>
    </tr>
    </thead>
    <tbody>
        
");
#nullable restore
#line 25 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>Нет уроков в этот день</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
             foreach (var time in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
                   Write(time.timeStart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 38 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
                                     Write(time.timeEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
                   Write(time.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
                   Write(time.Teacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
                   Write(time.Cabinet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\mraaq\Desktop\Timetable2\Timetable\Views\Informer\TimetableFinal.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Timetable.Domains.Headteacher.TimetableHead>> Html { get; private set; }
    }
}
#pragma warning restore 1591
