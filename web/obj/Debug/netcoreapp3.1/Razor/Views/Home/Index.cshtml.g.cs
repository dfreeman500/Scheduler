#pragma checksum "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755945fe426dcc411279450b43047cf380966a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\_ViewImports.cshtml"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\_ViewImports.cshtml"
using web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755945fe426dcc411279450b43047cf380966a97", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e2989be7935e1a8b5e6466c593fab35ffacecd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<web.Models.Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
  var numberOfDays = 14;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h3 >Welcome To the Event Scheduler</h3>\r\n    <h5> Currently showing ");
#nullable restore
#line 11 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                      Write(numberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days for at-a-glance scheduling.</h5>      <h6 style=\"color:red;\">Key: OW= Outside Window for Employee, DB = Double Booked</h6>\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
 if(ViewBag.Employees.Count==0) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                            
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span title=\"Add an Employee to create the the visual at-a-glance schedule\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755945fe426dcc411279450b43047cf380966a975821", async() => {
                WriteLiteral("Add an Employee to create the the visual at-a-glance schedule");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </span>\r\n");
#nullable restore
#line 20 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
    }
    else
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>Today is:</h5>\r\n    <div class=\"outerLoopForTables\">\r\n");
#nullable restore
#line 27 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
     for (int i = 0; i < @numberOfDays; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"loopOfTables\">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
          
            var calendarDate = DateTime.Today.AddDays(i);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>  ");
#nullable restore
#line 34 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
         Write(calendarDate.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h2>                        \r\n        \r\n");
            WriteLiteral("        <div>\r\n        <table class=\"table\" >\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Time \r\n                    </th>\r\n");
#nullable restore
#line 44 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                     foreach(var emp in ViewBag.Employees)  
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>\r\n                            <span");
            BeginWriteAttribute("title", " title=\"", 1498, "\"", 1541, 4);
            WriteAttributeValue("", 1506, "Edit", 1506, 4, true);
            WriteAttributeValue(" ", 1510, "information", 1511, 12, true);
            WriteAttributeValue(" ", 1522, "for:", 1523, 5, true);
#nullable restore
#line 47 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1527, emp.FullName, 1528, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755945fe426dcc411279450b43047cf380966a979562", async() => {
#nullable restore
#line 47 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                                                                Write(emp.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 47 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                                                                               Write(emp.StartTime.ToString("h:mm tt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 47 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                                                                                                                    Write(emp.EndTime.ToString("h:mm tt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                      WriteLiteral(emp.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </span>\r\n                        </th>      \r\n");
#nullable restore
#line 49 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 54 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
          
    
        var today = DateTime.Now;
        var timeSlots = new List<DateTime> {
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 0, 0, 0),
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 1, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 2, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 3, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 4, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 5, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 6, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 7, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 8, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 9, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 10, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 11, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 12, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 13, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 14, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 15, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 16, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 17, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 18, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 19, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 20, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 21, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 22, 0, 0), 
            new DateTime(calendarDate.Year,calendarDate.Month,calendarDate.Day, 23, 0, 0), 
            };
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                
            var tempListOfTodaysAppointments = new List<DateTime> {};
            foreach(var appointment in Model)
            {   
                if (appointment.RequestedTime.Date == calendarDate.Date) 
                    {
                        tempListOfTodaysAppointments.Add(appointment.RequestedTime);
                    }
            }
            foreach(var emp in ViewBag.Employees)
            {
                tempListOfTodaysAppointments.Add((calendarDate.Date+emp.StartTime.TimeOfDay));
                tempListOfTodaysAppointments.Add(calendarDate.Date+emp.EndTime.TimeOfDay);
            }
            var earliestTime = tempListOfTodaysAppointments.Min();
            tempListOfTodaysAppointments.Add(new DateTime(earliestTime.Year,earliestTime.Month,earliestTime.Day, earliestTime.Hour, 0, 0));
            

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                     
            var newTimeSlots = new List<DateTime>(timeSlots); 
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
             foreach(var time in timeSlots)
            {
                if(time<tempListOfTodaysAppointments.Min()||time>tempListOfTodaysAppointments.Max())
                    {
                        newTimeSlots.Remove(time);
                    }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
         foreach (var timeSlot in newTimeSlots) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"timeColumn\">\r\n                        ");
#nullable restore
#line 121 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                   Write(timeSlot.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    \r\n");
#nullable restore
#line 124 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                         foreach(var emp in ViewBag.Employees)
                        
                        {
                                var matchingAppointments = Model
                                .Where(st=> st.RequestedTime.ToString("D")==calendarDate.ToString("D"))
                                .Where(st => st.RequestedTime.ToString("hh tt") == timeSlot.ToString("hh tt"))
                                .Where(st=> st.EmployeeId == emp.Id)
                                .OrderBy(st=> st.RequestedTime);
                                


                                    var appointmentWindowClass="";
                                    if((timeSlot.TimeOfDay >= emp.StartTime.TimeOfDay) && (timeSlot.TimeOfDay <= emp.EndTime.TimeOfDay))
                                    {
                                        appointmentWindowClass="insideWindow";
                                    }
                                    else
                                    {
                                        appointmentWindowClass="outsideWindow";
                    
                                    }

                                    if(matchingAppointments.Count() == 0) 
                                    {
                                        if(appointmentWindowClass=="insideWindow")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td");
            BeginWriteAttribute("class", " class=\"", 7479, "\"", 7510, 1);
#nullable restore
#line 150 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue("", 7487, appointmentWindowClass, 7487, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">                                                \r\n                                            <span");
            BeginWriteAttribute("title", " title=\"", 7611, "\"", 7751, 5);
            WriteAttributeValue("", 7619, "Add", 7619, 3, true);
#nullable restore
#line 151 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7622, timeSlot.ToString("MM/dd/yyyy h:mm tt"), 7623, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("\r\n                                                        ", 7663, "appointment", 7721, 69, true);
            WriteAttributeValue(" ", 7732, "with", 7733, 5, true);
#nullable restore
#line 152 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7737, emp.FullName, 7738, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755945fe426dcc411279450b43047cf380966a9721607", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                         WriteLiteral(emp.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(timeSlot);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["time"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-time", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["time"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                                            </span> \r\n                                        </td>\r\n");
#nullable restore
#line 156 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                        }
                                        else 
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td");
            BeginWriteAttribute("class", " class=\"", 8196, "\"", 8227, 1);
#nullable restore
#line 159 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8204, appointmentWindowClass, 8204, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n");
#nullable restore
#line 160 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                        }
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"isappointment\">\r\n                                            \r\n");
#nullable restore
#line 166 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                             foreach(var appointment in @matchingAppointments)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                 if((appointment.RequestedTime.TimeOfDay < emp.StartTime.TimeOfDay) || (appointment.RequestedTime.TimeOfDay > emp.EndTime.TimeOfDay))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a><text style=\"color:red;\">OW</text></a>                                 \r\n");
#nullable restore
#line 171 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                             
                                                var doubleBooked = matchingAppointments
                                                .Where(st=> st.RequestedTime==appointment.RequestedTime);
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                 if(@doubleBooked.Count()>1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a><text style=\"color:red;\">DB</text></a>     \r\n");
#nullable restore
#line 177 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span");
            BeginWriteAttribute("title", " title=\"", 9599, "\"", 9792, 11);
            WriteAttributeValue("", 9607, "Name:", 9607, 5, true);
#nullable restore
#line 182 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 9612, appointment.Name, 9613, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("    ", 9630, "|", 9634, 5, true);
            WriteAttributeValue("    ", 9635, "Appointment:", 9639, 16, true);
#nullable restore
#line 182 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 9651, appointment.RequestedTime.ToString("MM/dd/yyyy h:mm tt"), 9652, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 9709, "|", 9711, 3, true);
            WriteAttributeValue("    ", 9712, "Notes:", 9716, 10, true);
#nullable restore
#line 182 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 9722, appointment.AppointmentNotes, 9723, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("    ", 9752, "|", 9756, 5, true);
            WriteAttributeValue("    ", 9757, "Phone:", 9761, 10, true);
#nullable restore
#line 182 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 9767, appointment.PhoneNumber, 9768, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755945fe426dcc411279450b43047cf380966a9730105", async() => {
#nullable restore
#line 183 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                                                 Write(appointment.RequestedTime.ToString("h:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 183 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                                                                                               Write(appointment.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 183 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                            WriteLiteral(appointment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                                                </span>\r\n                                                <br/>\r\n");
#nullable restore
#line 186 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <br/>\r\n");
#nullable restore
#line 188 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                             if((timeSlot.TimeOfDay >= emp.StartTime.TimeOfDay) && (timeSlot.TimeOfDay <= emp.EndTime.TimeOfDay))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span");
            BeginWriteAttribute("title", " title=\"", 10466, "\"", 10549, 5);
            WriteAttributeValue("", 10474, "Add", 10474, 3, true);
#nullable restore
#line 190 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 10477, timeSlot.ToString("MM/dd/yyyy h:mm tt"), 10478, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10518, "appointment", 10519, 12, true);
            WriteAttributeValue(" ", 10530, "with", 10531, 5, true);
#nullable restore
#line 190 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 10535, emp.FullName, 10536, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755945fe426dcc411279450b43047cf380966a9735021", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 191 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                 WriteLiteral(emp.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 191 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                                                                                          WriteLiteral(timeSlot);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["time"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-time", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["time"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                                                    </span>                                   \r\n");
#nullable restore
#line 193 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 196 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
                                    } 
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </tr>\r\n");
#nullable restore
#line 200 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n        </table>\r\n        <br/>\r\n        </div>\r\n        </div>\r\n");
#nullable restore
#line 205 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 207 "C:\Users\DF\Desktop\Code Louisville\C sharp\Scheduler\web\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<web.Models.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
