# Cafe-Management-System
It is a simple POS System that can fit in any industry such as
 Resturant, Cafe, Saloon etc

anyone can download, can make changes and can use this system free of cost.


This system is developed with .Net Version 4.6 and SQL Server 2014.
Please understand the classes before further development. The Solution has two projects, 
1 - DAL - FL_DL
2 - Front Later - Cafe_Management_System

Cafe Management System accessing / manupluting data from DAL
You just need to set the form properties and the default buttons will start working without writting any code

Steps to create a new form 

1- Create Tables in the db

2- Create two procedures 
   a- Procedure to save the data
   b- Procedure to Recall the data

3- Add a new form and set the form properties, you can check frmDeals as a sample of master detail form.

4- Controls that are saving and recalling data from database should have set the tag with database column name.

5- the name of save, reset, find and exit buttons should be same as frmDeals.


It is strongly recomended to follow the sample form(frmDeals) for CRUD 
