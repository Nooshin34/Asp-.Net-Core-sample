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
   Middleware is software that's assembled into an app pipeline to handle requests and responses. Each component:
      -Chooses whether to pass the request to the next component in the pipeline.
      -Can perform work before and after the next component in the pipeline.

   Each middleware have just one task.
   Middleware can be a request delegate(anonymous method or lambda expression) or a class.
