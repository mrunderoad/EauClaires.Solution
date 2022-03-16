# _Eau Claires Salon_

### _By: Isaac Overstreet_

#### _This application lets users add stylists and clients specific to each stylist using a one to many database relationship._

## Technologies Used

* _C#_
* _MySQL_
* _cshtml_
* _css_
* _Bootstrap_
* _Entity Framework_

## Description

_This project is made to show correct knowledge on a one to many relationship using MySQL. The application allows users to add Stylists to the database and also lets the user add Clients to each stylist keeping the stylist as the One and the clients as the many in the relationship.

## Setup/Installation Requirements

* _Make sure you have MySQL Workbench installed._
* _Clone this repository to your desktop from https://github.com/mrunderoad/EauClaires.Solution._
* _Navigate to the HairSalon directory in your terminal using `cd HairSalon`._
* _Inside the `HairSalon` directory, add a new file named `appsettings.json`._
* _Inside the `appsettings.json` file, add this code with your database, username and password in the specified places in the code._ 
```c#
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=DATABASE HERE;uid=USERNAME;pwd=PASSWORD;"
  }
}
```
* _**How to Import Database**_
* _Open MySQL Workbench_
* _Select the `Administration` tab in the `Navigation` panel._
* _Click `Data Import/Restore`._
* _Select `Import from self-contained file`, navigate to the `HairSalon` directory and select `isaac_overstreet.sql`._
* _In `Default Schema to be Imported to` click new and name the schema._
* _**MAKE SURE YOU ENTER DATABASE NAME INTO** `appsettings.json`!!_
* _Next, click `Start Import`._
* _You're now all set, refresh MySQL workbench and check that the schema is there._
* _**NEXT STEPS**_
* _Run `dotnet restore` to restore the bin and obj folders._
* _Run `dotnet build` to build the project._
* _Run `dotnet run` to open a localhost._
* _CTRL click on the first localhost option in your terminal after running `dotnet run`._

## Known Bugs

* No known bugs at this time.

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022  Isaac Overstreet