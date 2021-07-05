# API Project (Parks)

#### Given a choice between 3 types of projects (an animal shelter lookup, parks lookup, or local business lookup), and demonstration what was learned by the Build an API lessons.

#### By Juan Hasbun

## Technologies Used

   * HTML
   * Github/bash
   * Virtual Studio Code
   * CSS
   * Bootstrap
   * Javascript
   * Jquery
   * Markdown
   * Node.js
   * Web Pack
   * APIs
   * C#
   * MSTest
   * MySQl
   * MySQL Workbench
   * AspNetCore5.0
   * Entity Framework Core
   * Identity
   * dotnet
   * Postman

## Description

For this program, the goal is to build an API, that will allow a user to create, view, update, or delete data (full CRUD) related to state and national level parks from a database provided by the API - a database that is empty currently, for users to fill out as desired for testing.

## Setup/Installation Requirements

   * Clone from repository (use: `$git clone https:github.com/JuanHasbunZem/ParksAPI.Solution`)
   * Once cloned on to your computer, access with GitBash / terminal
   * Before anything, you will need to build the database. To do so, you will need to run the following command: `dotnet ef database update`
  * Additionally, you will need to create an appsettings.json file and include the following within it:
  ```
  {
    "ConnectionStrings": 
    {
      "DefaultConnection": "Server=localhost;Port=3306;database=[firstname_lastname];uid=[user id];pwd=[password];"
    }
  }
```  
Note: `[firstname_lastname]`, `[user id]`, and `[password]` should be replaced with your own information.

   * On your terminal (while within the Pierre folder) run: `$ dotnet restore`
   * To compile the program, first on your terminal run: `$ dotnet build`
   * To execute the program, on your terminal type: `$ dotnet run`
  

## Known Bugs

* None currently

## License

Copyright 2021 Juan Hasbun

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
Contact Information

Email at: [zemenareq@hotmail.com](zemenareq@hotmail.com) 