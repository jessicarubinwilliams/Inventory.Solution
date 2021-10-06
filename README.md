# To Do List

#### _A web-based application to track a user's collections._

#### By **Alex Goldberg, Shane Graff, Sisi Vieira, and Jessica Williams**

#### Table of Contents

1. [Technologies Used](#technologies)
2. [Description](#description)
3. [Setup/Installation Requirements](#setup)
4. [Known Bugs](#bugs)
5. [License](#license)
6. [Contact Information](#contact)

## Technologies Used <a id="technologies"></a>

* _C#_
* _.NET 5.0.100_
* _ASP.NET Core MVC_
* _Microsoft.NET.Sdk.Web_
* _Microsoft.NET.Test.Sdk 15.0.0_
* _MSTest.TestAdapter 1.3.2_
* _MSTest.TestFramework 1.3.2_
* _Microsoft.EntityFrameworkCore 5.0.0_
* _Pomelo.EntityFrameworkCore.MySql 5.0.0-alpha.2_

## Description <a id="description"></a>

This web-based application allows a user to track their collections and the collectables that make up those collections. Users may create multiple collections and associate specific collectables with a collection.

## Setup/Installation Requirements <a id="setup"></a>

* Open the terminal on your local machine
* If [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)
* If [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql)
* Navigate to the directory inside of which you wish to house this project
* Clone this project with the following git command `$ git clone <https://github.com/jessicarubinwilliams/Inventory.Solution>`
* Navigate to the production project directory with the command `$ cd Inventory.Solution/Inventory`
* Create a file to store your connection string for connecting the project to the database with the git command `touch appsettings.json`
* In your text editor add the following code to the newly created appsettings.json file. *Note that uid and pwd may vary depending on MySql configurations.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=jessicawilliams.sql;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

-> IMPORT DATABASE
* First, we need to ensure the MySQL server is running by opening __Terminal__ or __Windows PowerShell__ and entering the command `mysql -uroot -p[YOUR-PASSWORD-HERE]`
* In MySQL Workbench, select the __Navigator>Administration__ tab. Under the Navigator>Administration window, select __Data Import/Restore__ and you'll open a Data Import view. In the __Import Options__ section, select __Import from Self-Contained File__. Press the three dots for windows (two dots for Mac) icon at the end of the __Import from Self-Contained__ file field and navigate to the jessicawilliams.sql file in the root directory (Inventory/). In the __Default Schema to be Imported To__ section, there is a __Default Target Schema__ with a drop box. To the right of the drop box, select the New button and a pop up box will appear. In the pop up box, name the database `inventory`. Click ok. Click __Start Import__ at the bottom right corner of the window (If on a Mac the __Start Import__ button will be in the same view. If on a Windows machine change to the __Import Progress__ tab to access the __Start Import__ button). Re-open the __Navigator>Schemas__ tab, right click and select __Refresh All__; the new database will appear. 
* Recreate project environment and install required dependencies with terminal command `$ dotnet restore`
* Run the program in the console with the command `$ dotnet run`

## Known Bugs <a id="bugs"></a>

* No known bugs.

## License <a id="license"></a>
*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) **2021 Jessica Williams**

## Contact Information <a id="contact"></a>
**[Alex Goldberg](mailto:alexdominguezwebdev@gmail.com), [Shane Graff](mailto:copellius@gmail.com), [Sisi Vieira](mailto:cicy886@gmail.com),[Jessica R. Williams](mailto:jessicarubinwilliams@gmail.com)**