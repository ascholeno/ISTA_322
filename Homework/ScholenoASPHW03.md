## Anthony Scholeno
## .NET HW03


1. What is the most important part of an ASP.NET Core 3 application?

The data model. It is the representation of the real-world objects, processes, and rules that define the domain

2. What is the domain model?

Contains the C# objects that make up the universe of the application and the methods that manipulate them

3. Where are the model classes in an ASP.NET Core 3 application placed?

Models folder

4. How many action methods can a controller class define?

Multiple

5. What is a tag helper?

instruction for Razor that will be performed when the view is rendered

6. What does the asp-action attribute do?

instruction to add an href attribute to the a element that contains a URL for an action method

7. What is the difference between HTTP GET and HTTP POST? This is an important question, and you should understand the difference.

A GET request is what a browser issues normally each time someone clicks a link.
forms rendered using Html.BeginForm() are submitted by the browser as a POST request.

8. What is model binding?

ASP.NET Core feature whereby incoming data is parsed and the key/value pairs in the
HTTP request are used to populate properties of domain model types.

9. Why should we validate user data? How do we validate user data?

So that we get the data that we are expecting. validation rules are defined by applying attributes to model classes

10. What, specifically, is the ModelState.IsValid property?

It is a boolean property that validates the data input

11. What does the asp-validation-summary do?

attribute is applied to a div element, and it displays a list of validation errors when the view
is rendered.

12. Static content consists of content such as images, script files, style files, etc. In an ASP.NET Core application, what is the name of the folder that cotains static content?

wwwroot

13. What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary package? If not, what is it?

CSS framework originally developed by Twitter that has become a major open source project and a
mainstay of web application development.
