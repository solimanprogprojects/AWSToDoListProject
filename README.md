# AWSToDoListProject
To Do List for AWS.

This repository is called AWSToDoListProject and contains all the requirements analysis, design and code for the first Project of AWS which is a To Do List Project for a user.

The Requirements analysis files were originally under their own directory in my machine but were committed straight to the main branch here in this repository. They are: 1. ToDoListUseCaseDiagram.vsxd and 2. ToDoListUseCaseDiagram.pdf and each contain essentially the same information in different formats, which is the Use Case Diagram of the project.

The Entity Relationship Diagram files which are part of the Design stage of Software Development were originally under the same directory on my machine but here they are the next commit after requirements analysis. They are : 1. ToDoListDataDesign.vsxd and 2. ToDoListDataDesign.pdf and they contain essentially the same entity relationship diagram but only in different formats, one being visio format and the other pdf. They show the main database entities and application classes that will be used in this application.

The following step is the coding. I began with creating the database schema or just simply put the database for this applicaion. I did this using MySQL workbench which I had already installed on my laptop. For this application to work properly on the local host do the following steps to create the database in MS SQL Workbench:
1. Create a new Database connection in MySQL Workbench with the following credentials:
create a user called Soliman ie Soliman for the username and a password of data$admin12 
connection name = ToDoList
Host = 127.0.0.1
Port = 3306
User = Soliman
SSL = enabled with TLS_AES_256_GCM_SHA384

2. Next step is to actually create the database to be used for this application using the above mentioned connection called ToDoList.
So first Login to the newly created connection with the credentials : username or user = Soliman, password = data$admin12.
Next to create the new database you must execute the following SQL command: CREATE SCHEMA 'todolistdatabase'; 
This should create a new database under this database connection called 'todolistdatabase' which will eventually contain all the required database tables for this application.

3. The next step is to run the sqlScript.sql file in MySQL workbench which should automatically build the 3 required tables shown in the ERD files in this newly created database called 'todolistdatabase'. This script creates a user which will be able to access the application to perform their to do lists. Please note down the credentials of this user to be used in the application: username = soli1234 , password = pass1234.

4. Now that all the database tables are ready, it is time to build the application.
