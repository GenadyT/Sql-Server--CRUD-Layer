## MS Sql Server CRUD Layer

This .Net C# project is a C# written mechanism for accessing Sql Server database resources.
This mechanism is light weight, easy to implement and helps minimize the need in changing existing code.

### Project Topic

The implementation of the mechanism is carried out in such a way that a data access manager class 
is added to the already existing “Model Classes”.

### Project Technical Details

1.. For each "Model Class" model manager DbEntityManager constructor takes 4 CRUD Stored Procedures names 
for Insert, Select, Update and Delete.
2.. The assumption is that there is a mapping between the properties of the "Model Class" and the parameters 
corresponding to the stored procedures.

### Additional Information

This project uses C# Generics for conciseness and code reuse.

** Open MS Sql Server Management Studio and create database by MyMusicMoods.bak file.


