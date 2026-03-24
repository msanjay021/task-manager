1.Architectural Overview

React (Frontend)
   ↓ HTTP (Axios/Fetch)
ASP.NET Core Web API (Backend)
   ↓ Entity Framework Core
SQL Server (Database)

2.Create Project and Install Packages

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

3.Add Model then DbContext

4.Configure DB connection string in appsettings.json 

5.Configure required services and middleware.

6.Create Controller and run migrations

dotnet ef migrations add InitialCreate
dotnet ef database update

7.Create React App
npx create-react-app task-manager-ui
cd task-manager-ui
npm install axios

8.UI project structure:
src/
 ├── components/
 │    ├── TaskList.js
 │    ├── TaskForm.js
 ├── services/api.js
 ├── App.js

9.Run the app

dotnet run
npm start