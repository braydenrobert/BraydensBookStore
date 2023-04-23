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
Updated database with new migration for application database
Updated Readme.txt

05:51
Added ApplicationDbContext.cs with 'public DbSet<Category> Categories { get; set; }'
Created class file in BraydensBooks.Models
Added category table to DB
Added new class file with all information from Models Category
Ran test to make sure program worked
Updated Readme.txt

17:55
AddBookTable.cs Database added
AddCategoryToDb.cs Database added
Added Repository Folder
Added IRepository Folder into Repository folder
Added IRepository.cs file into IRepository folder
Added code to IRepository.cs File
Added Repository.cs file into Repository folder
Added code to Repository.cs File
Added CategoryRepository.cs file into Repository folder
Added code to ICategoryRepository.cs File
Added ICategoryRepository.cs file into IRepository folder
Added code to ICategoryRepository.cs
Updated Readme.txt

18:26
Added ISP_Call.cs file into IRepository folder
Added content to ISP_Call.cs file
Added SP_Call.cs file into Repository folder
Added content to SP_Call.cs file
Added IUnitOfWork.cs file into IRepository folder
Added content to IUnitOfWork.cs file
Added UnitOfWork.cs file into Repository folder
Added content to UnitOfWork.cs file
Updated Startup.cs with 'services.AddScoped<IUnitOfWork, UnitOfWork>();'
Updated Readme.txt


2023-03-31
04:20
Updated Repository.cs code with code displayed from course code
Added Controller for admin called CategoryController.cs (Uses IUnitofWork.cs to retrieve all categories)
Added folder named Category under Admin/Views
Added Index file to display categories with default layout
Deleted old index to display new index
Updated _Layout with Category display for dropdown menu
Updated Readme.txt

04:52
Added back Index.cshtml to Admin/Views/Home
Fixed _Layout.cshtml in Areas/Views/Shared by fixing location of _Layout.cshtml
Added '<a class="dropdown-item" asp-area="Admin" asp-controller="Category" asp-action="Index">Category</a>' to _Layout.cshtml dropdown menu in Customers/Views/Shared/_Layout.cshtml
Updated Readme.txt

16:13
Added Upsert.cshtml with online code from course
Added category.js file from course files
Updated CategoryController.cs with provided code
Added _CreateAndBackToList.cshtml with provided code
Added _EditAndBackToList.cshtml with provided code
Updated _Layout.cshtml with script code
Deleted CategoryRepository.cs code '_db.SaveChanges();'
Updated Readme.txt
20230330091405 - Migration of AddBookTable
20230330105213 - Migration of AddCategoryToDb.cs

------------
-- Part 3 --
____________

2023-04-13
21:43
Updated category.js with following delete code from provided website code.

22:28
Added CoverType.cs Model with ID and Name
Added Cover CoverTypeRepository Class
Added ICoverTypeRepository Interface
Added CoverType to UnitOfWork and IUnitofWork

22:41
Added code to CoverTypeRepository & ICoverTypeRepository
****** Need to fix migration error ******

2023-04-20
14:07
Updated ApplicationDbContext
Updated ICategoryRepository with shortened code
Updated CategoryRepository with shortened code  
Updated IUnitOfWork.cs and UnitOfWork.cs with updated Category & CoverType configuration
Updated CoverTypeRepository and ICoverTypeRepository to match CategoryRepositories code
Changed category.js
Updated ReadMe.txt

18:16
Updated CategoryController with code to fix errors not allowing create new category to work
Updated Category.cs with code wasn't allowing category to properly work
Changed all cshtml files in Shared to one directory for organization

2023-04-21
01:35
---FIXED COVERTYPE MIGRATION ERROR---
Opened Package Manager Console and selected BraydensBooks.Database as default project
Add-Migration AddCoverTypes
Update-Database

01:50
Added CoverType Controller duplicated from CategoryController
Added CoverType Index and Upsert duplicated from Category Index/Upsert - Updated with code in relation to CoverType
Updated _Layout.cshtml with Link to Cover Type link

02:51
Updated SP_CALL & ISP_Call.cs with working code (fixed errors)
UnitOfWork missing some extra code fix
SD.cs missing some code for procedures.

03:11
Added addValidationToProduct migration(20230421060059)
Added addProductToDb migration(20230421060009)
Updated IUnitOfWork & UnitOfWork with Product relation code
Added ProductRepository and IProductRepository.cs with copied code form CategoryRepository(Edited)
Added Product.cs with provided code from teacher
Updated ApplicationDbContext with Product.cs code to add to database

14:41
Added ProductVM.cs added with various code for ProductController.cs
Added ProductController.cs with copied code & changed from CategoryController.cs
Added Index.cshtml to Views/Product copied from Category index.cshtml
Added Upsert.cshtml to Views/Product from teachers online notes
Copied category.js and renamed it to product, changed URL(s) inside
_Layout.cshtml added Product to dropdown menu

2023-04-23
02:45
Added coverType.js to fix error for deletion and display when adding new Cover Type
Updated SP_Call Execute command to actually work for grabbing ProcsForCoverTypes
Added Migration AddStoredProcForCoverType(20230423063255)
Changed SD.cs to have procs for storing to db
Updated Index of Cover Type to include new coverType.js



*************************************************
**************   SDK VERSION IN   ***************
**************    global.json     ***************
************** NEEDS TO BE CHANGED **************
*************************************************



