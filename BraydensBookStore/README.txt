Date: 2023-03-02

Time: 15:05
Started Assignment 2 in-class on the lab computer
Setup the ASP.NET MVC w/ Core 3.1 (out-of-support)
HTTPS enabled, individual account authentication...no Razor
Reviewed the Areas Folder, Controller, Model, View...

Time: 15:06 - In Startup.cs on Line 33
removed the "options" for default identity: services.AddDefaultIdentity<IndentityUser>(options => options.SignIn.RequireConfirmedAccount = true) -> remove 'options => options.SignIn.RequireConfirmedAccount = true'

Time: 15:10
Cleaned code w/ right click on main project
Trial run on project to see if properly working
Action Items:
Modify Navigations
Update the copyright from 'static' to 'dynamic' (Needs to be done)

Time: 15:14
Updated Index.cshtml on line 6 with new title
Updated Index.cshtml on line 7 (deleted line)
Ran updated text to test if working

Time: 15:16
Startup.cs on line 65 added comment showing it's the default route pattern

Time: 15:17
Create repository 'BraydensBookStore'
options => options.SignIn.RequireConfirmedAccount = true

2023-03-03
13:25
Created the .md file and pulled file.

13:43
Replaced bootstrap.css file with different code from bootswatch to get current appearance


Changed 3 the following lines in the _Layout.cshtml:
Changed line 7 from 'bootstrap.min.css' to 'bootstrap.css'
changed line 39 from 'text-muted' to 'text-white-50 bg-primary'
Removed line 23 'text-dark'

13:08
Removed all 'text-dark' references in _Layout.cshtml

2023-03-07
22:41
Added new bootstrap.css from bootswatch.com
added new site.css config for different style from bootswatch.com

22:45
Added script runs to _Layout.cshtml from JQuery UI, DataTables, SweetAlert, FontAwesome and Toastr

22:46
Test Run application to check for errors.
Added dropdown menu to _Layout.cshtml
Changed dropdown menu name to Content Management


