##Anthony Scholeno
#ISTA322 HW02


1. What is the diference between Visual Studio and Visual Studio Code?

visual studio code is a light-weight version that doesnt have "all of the bells and whistles" so it takes up less resources.

2. What is LocalDB?

Part of SQL server. LocalDB installation copies a minimal set of files necessary to start the SQL Server Database Engine.

3. What do these commands do? 
dotnet new globaljson --sdk-version 3.1.101 --output FirstProject

Creates a folder named FirstProject and adds a file name global.json. which specifies the version of .net core that the project will use
 
dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1

Creates a new asp.net core project

4. What command do you use to build an ASP.NET project from the command line? What command do you use to run the project?

dotnet build / dotnet run

5. What is the purpose of an endpoint?

To handle incoming requests

6. What is a controller?

Tells the app what to send back to the user. 
C# class that is derived from the Microsoft.AspNetCore.Mvc.Controller class, the built-in controller base class.

7. Where are actions defined?

Public method defined by the controller

8. What is the purpose of the routing system?

responsible for selecting the endpoint that will handle an HTTP request

9. Assume that your ASP.NET application runs in a browser with a URL like http://localhost:5000. List the three default routes configured by the ASP.NET Core routing system.

/ /Home /Home/Index

10. What does the ViewResult object instruct ASP.NET Core to do?

Instructs asp.netcore to render a view

11. How does ASP.NET Core know what View is to be called from an action method?

Looks for a view with the same name as the method

12. What is the job of an action method?

Calls the view

13. What is a view model?


 Action methods provide data to views by passing arguments to the View method The data provided to the view is known as the view model.