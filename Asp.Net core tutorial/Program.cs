using System.ComponentModel.Design.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//when you reach the root please response "Hello World!"
//app.MapGet("/", () => "Hello World!");


//some information about our response save in a special type that we called "HttpContext"
app.Run(async(HttpContext context) => { 
    /*we change stutus manually to see it in network tab in inspect and also we can see "test"
    in in response part*/
    context.Response.StatusCode = 400;
    /*we can change data in response header(for example here i change the server and it changes
    in network tab but it works with kestrel as before)*/
    context.Response.Headers["server"] = "MyServer";
    await context.Response.WriteAsync("test");
});

app.Run();

