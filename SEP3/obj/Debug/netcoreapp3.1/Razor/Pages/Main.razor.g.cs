#pragma checksum "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a555f0e23dc305d0bd478f9eb8eecac8d0cfbf05"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using SEP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using SEP3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
using SEP3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
using SEP3.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/main")]
    public partial class Main : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\r\n    h4 {\r\n        margin: auto;\r\n        left: 35%;\r\n        position: absolute;\r\n    }\r\n\r\n    table, td, th {\r\n        border: 2px solid black;\r\n    }\r\n\r\n    #catagory {\r\n        font-size: medium;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 38 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                          book

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 38 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                SaveBook

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((another_name) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n                ");
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "col-12");
                    __builder3.AddMarkupContent(11, "\r\n                    ");
                    __builder3.AddMarkupContent(12, "<label for=\"catagory\" style=\"font-size: 18px; text-align: center; color: #4267B2\" ;>Choose Catagory </label>\r\n                    <br>\r\n                    <br>\r\n                    ");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "col-12 row");
                    __builder3.AddMarkupContent(15, "\r\n                        ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "col-2");
                    __builder3.AddMarkupContent(18, "\r\n                            ");
                    __builder3.OpenElement(19, "select");
                    __builder3.AddAttribute(20, "name", "catagory");
                    __builder3.AddAttribute(21, "id", "catagory");
                    __builder3.AddMarkupContent(22, "\r\n                                ");
                    __builder3.OpenElement(23, "option");
                    __builder3.AddAttribute(24, "value", "math");
                    __builder3.AddContent(25, "Math");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n                                ");
                    __builder3.OpenElement(27, "option");
                    __builder3.AddAttribute(28, "value", "physics");
                    __builder3.AddContent(29, "Physics");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n                                ");
                    __builder3.OpenElement(31, "option");
                    __builder3.AddAttribute(32, "value", "chemistry");
                    __builder3.AddContent(33, "Chemistry");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                                ");
                    __builder3.OpenElement(35, "option");
                    __builder3.AddAttribute(36, "value", "geography");
                    __builder3.AddContent(37, "Geography");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                                ");
                    __builder3.OpenElement(39, "option");
                    __builder3.AddAttribute(40, "value", "literature");
                    __builder3.AddContent(41, "Literature");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                                ");
                    __builder3.OpenElement(43, "option");
                    __builder3.AddAttribute(44, "value", "construction");
                    __builder3.AddContent(45, "Construction");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n                                ");
                    __builder3.OpenElement(47, "option");
                    __builder3.AddAttribute(48, "value", "marketing");
                    __builder3.AddContent(49, "Marketing");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                    __builder3.AddAttribute(54, "class", "form-control col-8");
                    __builder3.AddAttribute(55, "placeholder", "Search for files");
                    __builder3.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                                           book.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => book.Name = __value, book.Name))));
                    __builder3.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => book.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n                        <input type=\"submit\" class=\"form-control col-1 btn btn-primary align-content-center\" style=\"margin-left:20px\" value=\"search\">\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                <br>\r\n                <br>\r\n                ");
                    __builder3.AddMarkupContent(62, "<div class=\"col-12\" style=\"text-align:center\">\r\n                    <label class=\"font-weight-bold\" style=\"color: #4267B2; font-size:35px; \">Viewable Content</label>\r\n                </div>\r\n                ");
                    __builder3.OpenElement(63, "table");
                    __builder3.AddAttribute(64, "class", "table");
                    __builder3.AddMarkupContent(65, "\r\n                    ");
                    __builder3.AddMarkupContent(66, @"<thead>
                        <tr>
                            <th>Filename</th>
                            <th>Upload Date</th>
                            <th>Owner</th>
                            <th>File Format</th>
                            <th>Rating</th>
                            
                        </tr>
                    </thead>
                    ");
                    __builder3.OpenElement(67, "tbody");
                    __builder3.AddMarkupContent(68, "\r\n");
#nullable restore
#line 77 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                         if (bookList != null)
                        {
                            foreach (var file in bookList)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(69, "                                ");
                    __builder3.OpenElement(70, "tr");
                    __builder3.AddMarkupContent(71, "\r\n                                    ");
                    __builder3.OpenElement(72, "td");
                    __builder3.OpenElement(73, "a");
                    __builder3.AddAttribute(74, "href", "/webviewer");
                    __builder3.AddContent(75, 
#nullable restore
#line 82 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                              file.filename

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, " ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n                                    ");
                    __builder3.OpenElement(78, "td");
                    __builder3.AddContent(79, 
#nullable restore
#line 83 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                         file.uploadDate

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n                                    ");
                    __builder3.OpenElement(81, "td");
                    __builder3.AddContent(82, 
#nullable restore
#line 84 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                         file.username

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n                                    ");
                    __builder3.OpenElement(84, "td");
                    __builder3.AddContent(85, 
#nullable restore
#line 85 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                         file.format

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                                    ");
                    __builder3.OpenElement(87, "td");
                    __builder3.AddContent(88, 
#nullable restore
#line 86 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                         file.rating

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n");
#nullable restore
#line 88 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(91, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\r\n                ");
                    __builder3.AddMarkupContent(94, @"<div class=""col-12 row"" style=""left:45%"">
                    <input type=""submit"" class=""form-control col-1 btn btn-primary align-content-center"" value=""View"">
                </div>
                <br>
                <br>
                
                ");
                    __builder3.OpenElement(95, "div");
                    __builder3.AddAttribute(96, "style", "border: 3px solid #4267B2");
                    __builder3.AddMarkupContent(97, "\r\n                    ");
                    __builder3.AddMarkupContent(98, "<label class=\"font-weight-bold\" style=\"color: #4267B2; font-size:15px; \">Choose a Catagory to Upload</label>\r\n\r\n\r\n                    ");
                    __builder3.OpenElement(99, "div");
                    __builder3.AddAttribute(100, "class", "col-2");
                    __builder3.AddMarkupContent(101, "\r\n                        ");
                    __Blazor.SEP3.Pages.Main.TypeInference.CreateRadzenListBox_0(__builder3, 102, 103, 
#nullable restore
#line 103 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                                   categoryList

#line default
#line hidden
#nullable disable
                    , 104, "CompanyName", 105, "CustomerID", 106, "margin-bottom: 20px;height:200px;", 107, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 103 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                                                                                                                                                           args => Change(args, "ListBox")

#line default
#line hidden
#nullable disable
                    ), 108, 
#nullable restore
#line 103 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                     value

#line default
#line hidden
#nullable disable
                    , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value)), 110, () => value);
                    __builder3.AddMarkupContent(111, "\r\n                        <br>\r\n\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(112, "\r\n\r\n                    ");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddMarkupContent(114, "\r\n                        ");
                    __builder3.OpenElement(115, "input");
                    __builder3.AddAttribute(116, "type", "button");
                    __builder3.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                                       UploadFile

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "class", "form-control col-1 btn btn-primary");
                    __builder3.AddAttribute(119, "style", "margin:10px");
                    __builder3.AddAttribute(120, "value", "Upload File");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\r\n                        ");
                    __builder3.OpenComponent<BlazorInputFile.InputFile>(122);
                    __builder3.AddAttribute(123, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 110 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
                                             HandleFileSelected

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, "\r\n\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(127, "\r\n    ");
            }
            ));
            __builder.AddAttribute(128, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(129, "\r\n");
#nullable restore
#line 118 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
         if (true)
        {
            navManager.NavigateTo("/");
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(130, "    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "C:\Users\mathi\OneDrive\Skrivebord\2020Collection\SEP3\Pages\Main.razor"
       

    public Book book { get; set; }
    public List<Files> bookList;
    IFileListEntry file;
    string value="ListBox";
    string categoryName;
    IEnumerable<string> categoryList;


    protected override async Task OnInitializedAsync()
    {

        categoryList = new string[] { "Math", "Biology","Physics","Chemistry","Geography","Literature","Costruction","Marketing" };
        book = new Book();


        bookList = new List<Files>();


        //TODO: google ServerCertificateCustomValidationCallback when you realise that it cannot accept self signed certificates
        HttpResponseMessage response = await httpClient.GetAsync("https://localhost:8443/OnlineLibrary/main");
        Console.WriteLine(response.IsSuccessStatusCode);
        string responseBody = await response.Content.ReadAsStringAsync();

        Files[] fileArray=JsonSerializer.Deserialize<Files []>(responseBody);
        Console.WriteLine("File list " + fileArray[0].filename);
        foreach (var files in fileArray)
        {
            bookList.Add(files);
        };
        var print = book.getJson(responseBody);
        //TODO Work on it tommorow: Display the file from the api
        //var plzwork = JsonSerializer.Deserialize<Object>(response.Content.);
        Console.WriteLine($"response body: {responseBody.ToString()}");

    }

    public void SaveBook()
    {
        //var title = book.Name;
        // Book temp = new Book();
        //temp.Name = title;
        //bookList.Add(temp);
        //book = new Book();

    }


    void HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
    }

    async void UploadFile()
    {
        Files temp = new Files();
        temp.filename = file.Name;
        temp.format = file.Type;
        temp.filesize = (int)file.Size;
        var ms = new MemoryStream();
        if (file != null)
        {
            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            await file.Data.CopyToAsync(ms);

        }
        string now = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");




        byte[] byteArray = ms.ToArray();
        String fileUsername = await sessionStorage.GetItemAsync<string>("username");
        Files file1 = new Files { filename = file.Name, username = fileUsername, uploadDate = now, format=file.Type,
            filesize= (int)file.Size,category=categoryName ,mybytearray = byteArray,};

        Console.WriteLine("FORMAT: " + file.Type);

        string fileJsonToSend = JsonSerializer.Serialize(file1);

        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "OnlineLibrary/add");
        request.Content = new StringContent(fileJsonToSend);

        Console.WriteLine("SendingFile " + file.Data);

        HttpResponseMessage response = await httpClient.SendAsync(request);

        string responseBody = await response.Content.ReadAsStringAsync();
        Files fileRecieved = JsonSerializer.Deserialize<Files>(responseBody);

        Console.WriteLine("Response status:" + response.StatusCode);
        Console.WriteLine("File back: " + fileRecieved.filename);
        bookList.Add(fileRecieved);
        navManager.NavigateTo("/main");
        
    }
    void Change(object value, string name)
    {
        var str = value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value;
        categoryName = str.ToString();
        Console.WriteLine(categoryName);
        StateHasChanged();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BookService bookServce { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
namespace __Blazor.SEP3.Pages.Main
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenListBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg4, int __seq5, global::System.Object __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenListBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Style", __arg3);
        __builder.AddAttribute(__seq4, "Change", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
