------------
-- Part 1 --
____________

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

22:46
Test Run application to check for errors.
Added dropdown menu to _Layout.cshtml
Changed dropdown menu name to Content Management

23:12
Added EntityFrameworkCore.Relational

14:28
Added script runs to _Layout.cshtml from JQuery UI, DataTables, SweetAlert, FontAwesome and Toastr

15:12
Added three New Projects(.NET Core class library)
Copied the 'data' folder to .DataAccess
Deleted original 'data' folder
Deleted Migrations

15:50
Installed Identity.EntityFrameworkCore
Modified namespace in ApplicationDbContext - Data from BraydensBooks.DataAccess
Deleted all default Class1.cs files

16:56
Moved Models into BraydensBooks.Models
Modified Error.cshtml in Views
Renamed Models folder to ViewModels
Changed ErrorViewModels.cs namespace to .Models.ViewModels
Tested Project

17:01
Ran application to check for errors
Fixed all using errors/references
Corrected all Error references w/ ErrorViewModel to .Models.ViewModels
Tested for error check(No Errors)

17:09
Added a static class called SD.cs in Utility Project
Modified the properties of the class
Added a project reference to main project
Added project reference to Models and Utility from DataAccess

17:45
Added Customers area to Areas
Changed the routes in Startup.cs to new Area
Edited HomeController.cs to define controller in Customers Area
Moved Views to Customers Area

17:50
Changed _ViewStart to display new _Layout location in Customers Area
Copied ViewImport and ViewStart to Customers Area
Modified new _ViewStart to reflect new path

17:54
Added New area named Admin
Added necassary view files to Admin Area
Deleted Controller Folder
Deleted Data and Models folder from Admin Area
Updated _Layout.cshtml to make footer fixed to bottom of screen

2023-03-10
15:07
Bootstrap Picked was https://bootswatch.com/quartz/

------------
-- Part 2 --
____________

2023-03-30
05:15
Added Migration to BraydensBooks.DataAccess
Updated database with new migration
Updated ReadMe

05:51
Added ApplicationDbContext.cs with 'public DbSet<Category> Categories { get; set; }'
Created class file in BraydensBooks.Models
Added category table to DB
Added new class file with all information from Models Category
Ran test to make sure program worked

17:55
Added Repository Folder
Added IRepository Folder into Repository folder
Added IRepository.cs file into IRepository folder
Added code to IRepository.cs File
Added Repository.cs file into Repository folder
Added code to Repository.cs File
Added CategoryRepository.cs file into Repository folder
Added code to ICategoryRepository.cs File
Added ICategoryRepository.cs file into IRepository folder






