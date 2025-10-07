# Asp-.Net-Core-sample
ASP.NET Core is a new open-source and cross-platform framework for building modern cloud based internet connected applications, such as web apps, IoT apps and mobile backends. ASP.NET Core apps can run on .NET Core or on the full .NET Framework. It was architected to provide an optimized development framework for apps that are deployed to the cloud or run on-premises. It consists of modular components with minimal overhead, so you retain flexibility while constructing your solutions. You can develop and run your ASP.NET Core apps cross-platform on Windows, Mac and Linux. ASP.NET Core is open source at GitHub.https://aspnetcore.readthedocs.io/en/stable/intro.html

<img width="725" height="279" alt="http" src="https://github.com/user-attachments/assets/5626edb7-b287-4559-bff8-2625f41c7243" />


<h3>***Response header:</h3>
   We can access to it in network tab in inspect and it shows us some key-value that I explain in picture(1).
   <img width="800" height="400" alt="ChatGPT Image Sep 15, 2025, 03_59_00 PM" src="https://github.com/user-attachments/assets/fd15d709-a41d-4761-a6bf-1a06d6b96e8e" />

<h3>***HTTP request:</h3>
   consist of: start line - request headers- empty line and request body.<br>
   You can read about all http headers in https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Headers.<br><br>
   <img width="513" height="236" alt="Screenshot 2025-10-01 091237" src="https://github.com/user-attachments/assets/cd2186bd-07da-47b2-89f9-47c4de57a9f0" />
   
<h3>***Query string:</h3>
   Everything after "?" in owr url is query string.<br>
   And we use it to transfer data between different pages.<br>
   We can have more than one date (key1=value1) and we use "&" between parameters(without any space).<br>
   As its name shows , all the data that we get from query string have string type and when we use it we should remember that.<br>
   This type of sending data is not secure and we can't send important data because user can see it and also can change it and it is not a good idea.<br>
   <img width="500" height="220" alt="image" src="https://github.com/user-attachments/assets/bbe62c59-d612-426c-8282-cb410a109182" />
   
<h3>***HTTP Request methods:</h3>
   HTTP request methods, also known as HTTP verbs, define the actions that can be performed on resources in a web application.<br><br>

![HTTP-Reuest-Method-by-testkarts](https://github.com/user-attachments/assets/651c0e23-285c-4ade-b3ed-6504dedb3623)

<img width="729" height="324" alt="Screenshot 2025-10-01 143937" src="https://github.com/user-attachments/assets/de674a09-20e6-473e-b05a-97387429d921" />

<img width="721" height="308" alt="Screenshot 2025-10-01 144146" src="https://github.com/user-attachments/assets/fffd101b-4c2d-48bb-9af6-22b9243022a2" />

<img width="579" height="341" alt="Screenshot 2025-10-01 145228" src="https://github.com/user-attachments/assets/c2a73427-0d9f-496b-b3dd-31bb1282ef83" />


<h3>***MiddleWares:</h3>
   Middleware is software that's assembled into an app pipeline to handle requests and responses. Each component:<br>
      -Chooses whether to pass the request to the next component in the pipeline.<br>
      -Can perform work before and after the next component in the pipeline.<br><br>

   *Each middleware have just one task.<br>
   *Middleware can be a request delegate(anonymous method or lambda expression) or a class.<br>

   *In ASP.NET Core, middleware components are arranged in a pipeline, and each middleware can either:<br>
     Pass the request to the next middleware (non-terminal middleware), or<br>
     Handle the request completely and stop the pipeline (terminal middleware).<br>

   *Examples of Non-Terminal Middleware (Use):<br>
      These typically inspect or modify the request/response and then call next():<br>
      app.UseRouting() → sets up endpoint routing but passes control forward. <br>     
      app.UseAuthentication() → checks authentication, continues to next. <br>     
      app.UseAuthorization() → enforces authorization, then continues.<br>      
      app.UseCors() → applies CORS policies, then forwards the request.<br>      
      app.Use(async (context, next) => { ... await next(); }) → custom logging, exception handling, timing, etc.<br><br>

   *Examples of Terminal Middleware (Run / endpoint-handling):<br>
      These end the pipeline because they generate a response without calling next():<br>      
      app.Run(...) → any delegate you define that writes the final response. <br>    
      app.MapGet("/hello", () => "Hello World") → endpoint mapping (terminal by design).<br>      
      app.MapControllers() → MVC/Web API controllers (they handle the request fully).<br>     
      app.MapRazorPages() → Razor Pages (terminal).<br>      
      app.MapBlazorHub() → Blazor Server (terminal).<br>      
      app.UseEndpoints(endpoints => { endpoints.MapControllers(); }) → terminal since endpoints generate responses.<br>     
      Static file middleware (if a matching file is found, it stops the pipeline)<br>
      <img width="539" height="251" alt="middle" src="https://github.com/user-attachments/assets/b2630b43-716b-46a5-8bbf-e91740496f41" /><br><br>
      <h3>***How to have my special middleware?(I do it in middleware class)</h3><br>
      <img width="518" height="239" alt="middle2" src="https://github.com/user-attachments/assets/27e08410-c542-4113-b625-62d560fa13ae" /><br>
      <h3>***How to write middleware like an extension method?</h3><br>
      <img width="511" height="185" alt="asp1" src="https://github.com/user-attachments/assets/44c3d4c4-d862-41df-bd7e-8298a8b5ad7d" /><br><br>
      <h3>***Middleware order:</h3><br>
      <img width="760" height="440" alt="asp2" src="https://github.com/user-attachments/assets/afe8179b-2bb3-41c7-8b9a-7d92503c424e" /><br><br>
      <h3>***UseWhen for middlewares:</h3><br>
      <img width="611" height="275" alt="asp3" src="https://github.com/user-attachments/assets/7891813d-5702-4fa3-918e-799b61410430" /><br><br>
      UseWhen is an ASP.NET Core middleware branching method that allows you to conditionally add middleware to the request pipeline based on a predicate.<br>
      <h3>***ROUTING:</h3><br>
      In ASP.NET Core, routing is the system that maps incoming HTTP requests (like URLs) to the corresponding code that should handle them — usually a controller action, a Razor Page, a middleware delegate, or an endpoint.<br>
      <img width="632" height="152" alt="asp4" src="https://github.com/user-attachments/assets/2d67e807-68de-4aff-91d0-30792bcdc881" /><br><br>
      <img width="700" height="365" alt="asp5" src="https://github.com/user-attachments/assets/ce274601-a6c2-4fa9-b0be-939a61561003" /><br><br>
      <h3>***How to use useEndpoint:</h3><br>
      <img width="529" height="158" alt="asp1" src="https://github.com/user-attachments/assets/2b01c162-7b89-4b50-86c6-a1c567cf5149" /><br><br>
      <h3>***Differences between map, mapGet, mapPost, ...:</h3><br>
      <img width="743" height="287" alt="asp3" src="https://github.com/user-attachments/assets/fe88500c-74c3-4fd2-b48c-491c67bea623" /><br><br>
      <h3>***GetEndpoint():</h3><br>
      If we use it before UseRouting(), it returns null but if we use it after that it returns endpoint object.(UseRouting() check if the current URL matches any item in a predefined list (e.g., aboutUs), and find out that this request belongs to which endpoint)<br>
      <img width="544" height="153" alt="asp4" src="https://github.com/user-attachments/assets/b9d791a3-c73e-446c-9064-b5ac1e6a1fa7" /><br><br>
      <h3>***Route parameters:</h3><br>
      Routing parameters are placeholders in a URL that let you pass values to your code (like an action method).<br>
      for example:<br>
      pattern: "products/{productName}"<br>
      /products/noteBooks<br>
      <h3>***Default parameters:</h3><br>
      If the URL doesn’t give a value for that part, ASP.NET Core will use a default value instead.<br>
      pattern: "products/{productName = book}"<br>
      <h3>***Route constraints:</h3><br>
      For example for productName i want to it's always be int not string or ... and we cant use all data types for route constraints<br>
      pattern: "products/{productName: int}"<br.
      <img width="518" height="463" alt="asp1" src="https://github.com/user-attachments/assets/ee300e9f-dfed-4c3a-b2cf-e941b6ada1a9" /><br><br>
      <h3>***How to define my customized route constraint:</h3><br>
      <img width="491" height="275" alt="asp2" src="https://github.com/user-attachments/assets/4b482f8b-1bde-454a-9428-9f4685500652" /><br><br>
      pattern: "products/{productName}"<br>
      productName is rout key.
      productName is route value.



      
