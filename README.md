# BUILD Status 
[![.NET](https://github.com/dubeyyogesh10/ContactApp.Api/actions/workflows/dotnet.yml/badge.svg)](https://github.com/dubeyyogesh10/ContactApp.Api/actions/workflows/dotnet.yml)

## Design pattern are for reference only DO NOT OVER ENGINEER YOUR PROJECT until required

# TO RUN in Local Environment
## Database setup for EF Core
### 1. Open the "ContactApp.Api.sln" file in visual studio
### 2. Open "appsettings.json" and replace "*< yourServerName >*" in connectionString with your own sql server.
### 3. Open package Manager console. Switch the "ContactApp.Infra" project (option available in console package Manager itself, at the top).
### 4. Run follwing Commands
  #### 1. add-migration newMigration
  #### 2. database-update  Microsoft Doc-https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs

## Web API (.Net Core 3.1)
### 1. Run Contacts.Api in visual studio OR Go to ContactApp.Api folder where "ContactApp.Api.csproj" is located and open CMD/bash to run following commands.
  #### 1. Run "dotnet restore"
  #### 2. Run "dotnet build"
  #### 3.Run "dotnet watch run" in CMD/bash. It will run the api on 5001 port and will open swagger in browser.

## Front End (Angular 11)
### Go to "FrontEnd" present in the root directory of the folder.
### Run Following sterps
   #### npm install
   #### ng serve

#### Tech stack and patterns - .Net Core WebAPI, Code First EF CORE,Angular 11, Swagger, MediatR CQRS Pattern, Respository, Async calls, Notification using toastr service.

####  Basic Contact App functionality with ADD, DELETE, EDIT, VIEW option.
  
##### Requirement : Net 3.1 core SDK, Angular CLI 11, MS SQL Server Express


