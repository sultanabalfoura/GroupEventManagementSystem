
Overview:
The Activity System is a comprehensive platform designed to streamline the organization and coordination of groups and events within a university setting. With a user-friendly interface and robust features, the system empowers administrators, group leaders, and members to efficiently manage and participate in various campus activities.

Get started:
The system develops by using n-tier architecture which contain BLL, DAL and PL. before starting we must install package from NuGet Package Manager in each Layer.

DAL  install Microsoft.EntityFrameworkCore.SqlServer 
PL  install Microsoft.EntityFrameworkCore.Tools

Make Reference in layers: (Right click on layer)
BLL  Reference to DAL
PL.  Reference to BLL

1-	DAL is connected with the database it has classes that is translated to tables in database in the SQL Server. It has 3 folders which are Models, Context, and Migration.
Models is the classes that translate to tables in database. Context, has one class which is ApplicationDbContext that to make dependency injection with the database and call all classes from Models Folder. The last folder is generating from the NuGet package Manager Console by using two commands
-	Add-migration “putting any names for migration”
-	Update-database

2-	BLL is has main logic for the system it contains to folders which are Interface and Repository. This Layer has GenericRepository and UnitOfWork and ClassRepository. The GeniricRepository has Main Logic Which each system has which are Create, Update, Delete, GetAll and Get by id. The UnitOfWork is contain all repositories that we can call it by using one Class only.  

3-	PL is having All works for the system. It contains controllers and views. Each controller must have folder in view has similar name of controller and each Action in controller has Razor Page has Similar name of Action. Also, we have Shared Folder in Views which has all shared files Like Navbar and Footer.

And we have Resources Folder which is for translate the system to Arabic, to achieve this gool we have use Recourses File and name it like: 
Views.FolderName.FileName.ar.resx (For Arabic)
Views.FolderName.FileName.en.resx (For English)

4-	In Program.cs, we have introduced that the connection with database 
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection")));

Defaultconnection is the name of connection we got it from appsettings.json file in PL 

Appsettings.json 
"ConnectionStrings": {
    "Defaultconnection": "Data Source = localhost; Initial Catalog = ActivitySystemSQU; User ID = SA; Password = Sss12345;"
  }

This connection will be deferent in each devices 
To get connection string go to Microsoft Sql Server Manager and get the connection.
