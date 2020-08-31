## Name: Anthony Scholeno
## File: ASP.NET HW04


1. What are the .NET SDK command line tools used for? Is their use required? Why or why not?

creating, managing, building, and running projects. Depends, If you are using visual code then yes, Visual studio then no

2. What kind of applications do the following templates create? Run these commands and read the documentation. A brief summary of each template is sufficient.

dotnet new console --help - create a new project, configuration file, or solution file
dotnet new mvc --help - This template creates an ASP.NET Core project configured to use the MVC Framework
dotnet new web --help - This template creates a project that is set up with the minimum code and content required for ASP.NET Core development. 

3. What, specifically, do the following commands do?

dotnet new globaljson --sdk-version 3.1.101 --output MySolution/MyProject - creates a MySolution/MyProject folder that contains a global.json file, which specifies that the project will use .NET Core version 3.1.1. The top-level folder, named MySolution

dotnet new web --no-https --output MySolution/MyProject --framework netcoreapp3.1  - creates a project with the minimum content required for ASP.NET Core development. 
dotnet new sln -o MySolution - Creates a solutin file for MySolution - Create a solution file that reference the new project
dotnet sln MySolution add MySolution/MyProject

4. What is the purpose of the global.json file?

The global.json file allows you to define which .NET Core SDK version is used when you run .NET Core CLI commands.

5. What does the method app.UseStaticFiles() do?

adds support for responding to HTTP requests with static content in the wwwroot folder

6. What do the following two commands do?
dotnet build - Builds your file
dotnet run - runs your file

7. (not in book) You cah manage pacakges using the NuGet package manager and the command line tool
dotnet add package. What are packages and what are they used for.

Templates you can download

8. What are tool packages and what are they used for?

Tool packages install commands that can be used from the command line to perform operations on .NET Core projects.

9. What are tool packages and what are they used for?

Tool packages install commands that can be used from the command line to perform operations on .NET Core projects.

10. What are client side packages and what are they used for?

Client-side packages contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static
HTML.

11. List two ways that a developer can debug code.

Use the debugger option. Add system.console.writeline to your code to show what is being returned 
