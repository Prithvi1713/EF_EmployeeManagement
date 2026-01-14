# EF_EmployeeManagement

# Steps to Create Employee Management System Project

    # Create ASP.NET Core Web App (Model-View-Controller) project 
    
    # Define the 3 model class 
            DepartmentMaster.cs
            DesignationMaster.cs
            EmployeeMaster.cs
            Add the properties in each model class with Data Annotation validations 
            
    # install the EntityFramework packages through NuGet package manager
            Microsoft.EntityFrameworkCore
            Microsoft.EntityFrameworkCore.SqlServer
            Microsoft.EntityFrameworkCore.Tools
            Microsoft.VisualStudio.Web.CodeGeneration.Design (8.0.2 version)
            
    # Create the folder for DatabaseContext that contain the database with its table
    
    # add the connection string in appSetting.json
            "ConnectionStrings": {
                      "ProjectConnectionString": "Server=LAPTOP-FQQBVLIE;Database=EmployeeMgmtSystem;Trusted_Connection=True;TrustServerCertificate=True;"
            },
    # add the services in Program.cs file for Database connection 
            builder.Services.AddDbContext<DatabaseContext>(options => 
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    # perform the migration 
            Add-Migration "InitialCreate"
            Update-Database
            
    # Create the Controller for each model class 
            It is mendetory to add Suffix of each controller as a Controller.cs (ex- EmployeeMasterController.cs)
                EmployeeMasterController.cs
		        DepartmentMasterController.cs
		        DepartmentMasterController.cs
            add the code in each controller for action method (Index, Create,Details, Edit, Delete)

    # Create the View folder for each model class in View Folder 
                EmployeeMaster
		        DepartmentMaster
		        DesignationMaster
            inside the folder create the views for actions (Index,Create, Edit, Delete, Details)
                Index.cshtml
		        Create.cshtml
		        Details.cshtml
		        Edit.cshtml
		        Delete.cshtml

    # In Layout.cshtml file add the controller and action method name in navbar 
            asp-controller= "DepartmentMaster"		asp-action= "Index"
		    asp-controller= "DesignationMaster"		asp-action= "Index"
		    asp-controller= "EmployeeMaster"		asp-action= "Index"

    # in program.cs file change default MapRouting controller and action  
		    asp-controller= "DepartmentMaster"		asp-action= "Index"
        
    # Build Solution 

    # Run project 
    
