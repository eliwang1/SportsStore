# SportsStore
To integrate AngularJS with ASP.NET WepApi and NInject.
At the end of SportsStore, an email is generated, which is a part of ASP.NET WebApi.
To start SportsStore, run app.html under SportsStore.Frontend.
Save cart data from memory to SQL database.
Fix couple bugs: change description to Description in ProductList.html and add <br /> in email
Add Login for security check. Use admin / secret to get into administration function.
Contributors for Sports Store: 1. Adam Feeman, Pro AngularJS Apress
     2. Jason Watmore, BasicAuthHttpModule, http://jasonwatmore.com/post/2014/12/01/Web-API-2-Basic-HTTP-Authentication-Example.aspx
     3. Rob Beattie, Software Architecture by layers.
Add invoice.html and convert it to pdf through wkhtmltopdf.
I split SportsStore solution into two layers (or projects): SportsStore.FrontEnd and SportsStore.WebApi (Backend/Asp.net WebApi). Please see SportsStore.png.
I further split SportsStore.WebApi into two layers (or projects): SportsStore.WebApi and SportsStore.Domain. Please see SportsStore.png.
Move sendMail and creatPdf from OrdersController.cs to OrderRepository.cs
