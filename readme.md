# _Eau Claires Salon_

### _By: Isaac Overstreet_

#### _This application lets users add stylists and clients specific to each stylist._

## Technologies Used

* _C#_
* _MySQL_
* _cshtml_
* _css_
* _Bootstrap_

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
* _Run `dotnet restore` to restore the bin and obj folders._
* _Run `dotnet build` to build the project._
* _Run `dotnet run` to open a localhost._
* _CTRL click on the first localhost option in your terminal after running `dotnet run`._

## Known Bugs

* No known bugs at this time.

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2022  Isaac Overstreet