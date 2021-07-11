# API Project (Parks)

#### Given a choice between 3 types of projects (an animal shelter lookup, parks lookup, or local business lookup), and demonstration what was learned by the Build an API lessons.

#### By Juan Hasbun
#### Updated: 7/10/21

## Technologies Used

   * Github/bash
   * Virtual Studio Code
   * Markdown
   * C#
   * .Net v5.0
   * MySQl
   * AspNetCore5.0 MVC
   * Entity Framework Core
   * Identity
   * dotnet
   * Postman
   * Razor
   * Swagger

## Pre-requisites

Ideally, you should have a C# code editor, such as Visual Studio. Your editor should also include AspNetCore, Entity Framework, and Identity packages. You will also need MySql. Github is assumed (as you are viewing this hopefully on Github).
SwaggerUI is also recommended but not neccessary as links are provided to view this API with their UI.

## Description

For this program, the goal is to build an API, that will allow a user to create, view, update, or delete data (full CRUD) related to state and national level parks from a database provided by the API - a database that is empty currently, for users to fill out as desired for testing.  This page also uses Swagger documention, as such it can be launched through the SwaggerUI at `http://localhost:5000/swagger/v1/swagger.json`. Thanks to Swagger documentation, any user can test these API endpoints and have json text returned to the user, allowing an additional way of testing out the API.

The endpoints available for this API are the following:
* Get (http://localhost:5000/api/parks) - this is the basic Get route for the API, it'll return a json object with a list of all parks within the database, it can be further refined by appending with ?name= , ?location= , or ?type= .
* GetParks (http://localhost:5000/api/parks/{id}) - this is a Get route to access a specific park and will return a json object for the specified park.
* Post (http://localhost:5000/api/parks) - this will take a provided json object and add the new park into to database.
* Put (http://localhost:5000/api/parks/{id}) - this route will take the provided json object and replace the data for the current {id} park.
* Delete (http://localhost:5000/api/parks/{id}) - this route will delete all park data of the {id} from the database.

## Setup/Installation Requirements

   * Clone from repository (use: `$git clone https:github.com/JuanHasbunZem/ParksAPI.Solution`)
   * Once cloned on to your computer, access with GitBash / terminal
   * Before anything, you will need to create an appsettings.json file within the ParksAPI directory. This file must include the following within:   
    ```
      {
        "ConnectionStrings": 
        {
          "DefaultConnection": "Server=localhost;Port=3306;database=[firstname_lastname];uid=[user id];pwd=[password];"
        }
      }
    ```  
    Note: `[firstname_lastname]`, `[user id]`, and `[password]` should be replaced with your own information.

   * On your terminal (while within the ParksAPI folder) run: `$ dotnet restore` , this will download the neccessary additional packages.
   * Then enter `$ dotnet build` to make sure no errors occurred with updating the packages.
   * Next, you will need to rebuild the database. To do so, you will need to run the following command: `$ dotnet ef database update`
   * To execute the program, on your terminal type: `$ dotnet run`
   * For SwaggerUI users, you can find endpoint documention at `http://localhost:5000/swagger/index.html` (once the ParksAPI program is running).
  

## Known Bugs

* None currently

## License

Copyright 2021 Juan Hasbun

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
Contact Information

Email at: [zemenareq@hotmail.com](zemenareq@hotmail.com) 