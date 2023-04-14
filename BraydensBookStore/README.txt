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


----------------------ADD CODE BELOW WHEN MIGRATION FIXED-------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BraydensBooks.Models; 

-----CoverTypeController.cs----------

public class CoverTypeController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    // GET: CoverType
    public ActionResult Index()
    {
        List<CoverType> coverTypes = db.CoverTypes.ToList();
        return View(coverTypes);
    }

    // GET: CoverType/Details/5
    public ActionResult Details(int id)
    {
        CoverType coverType = db.CoverTypes.Find(id);
        if (coverType == null)
        {
            return HttpNotFound();
        }
        return View(coverType);
    }

    // GET: CoverType/Upsert/5
    public ActionResult Upsert(int? id)
    {
        CoverType coverType = new CoverType();
        if (id.HasValue)
        {
            coverType = db.CoverTypes.Find(id);
            if (coverType == null)
            {
                return HttpNotFound();
            }
        }
        return View(coverType);
    }

    // POST: CoverType/Upsert
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Upsert(CoverType coverType)
    {
        if (ModelState.IsValid)
        {
            if (coverType.Id == 0)
            {
                db.CoverTypes.Add(coverType);
            }
            else
            {
                db.Entry(coverType).State = EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(coverType);
    }

    // POST: CoverType/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id)
    {
        CoverType coverType = db.CoverTypes.Find(id);
        if (coverType == null)
        {
            return HttpNotFound();
        }
        db.CoverTypes.Remove(coverType);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            db.Dispose();
        }
        base.Dispose(disposing);
    }
}

--IndexCoverType----------
@model List<BraydensBooks.Models.CoverTypes> 

@{
    ViewBag.Title = "Cover Types";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>Cover Types</h2>

<a href="@Url.Action("Upsert", "CoverType")" class="btn btn-success">Add New</a>

<table id="coverTypeTable" class="table table-striped table-bordered">
    <thead>
        <tr>
            <th>Name</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var coverType in Model)
        {
            <tr>
                <td>@coverType.Name</td>
                <td>
                    <a href="@Url.Action("Details", "CoverType", new { id = coverType.Id })" class="btn btn-info btn-sm">Details</a>
                    <a href="@Url.Action("Upsert", "CoverType", new { id = coverType.Id })" class="btn btn-primary btn-sm">Edit</a>
                    @using (Html.BeginForm("Delete", "CoverType", new { id = coverType.Id }, FormMethod.Post, new { onsubmit = "return confirm('Are you sure you want to delete this cover type?');" }))
                    {
                        <button type="submit" class="btn btn-danger btn-sm">Delete</button>
                    }
                </td>
            </tr>
        }
    </tbody>
</table>

@section scripts {
    <script>
        $(document).ready(function () {
            $('#coverTypeTable').DataTable();
        });
    </script>
}

----Upsert CoverType-------
@model YourApplication.Models.CoverType // Update with your actual model namespace

@{
    ViewBag.Title = "Cover Type";
    Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>@(Model.Id == 0 ? "Add New" : "Edit") Cover Type</h2>

@using (Html.BeginForm("Upsert", "CoverType", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    @Html.AntiForgeryToken()

    <div class="form-group">
        @Html.LabelFor(model => model.Name)
        @Html.TextBoxFor(model => model.Name, new { @class = "form-control" })
        @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" })
    </div>

    <button type="submit" class="btn btn-success">Save</button>
    <a href="@Url.Action("Index", "CoverType")" class="btn btn-default">Cancel</a>
}


--






