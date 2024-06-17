# GymMe
Project mata kuliah pattern software design semester 4, GymMe is a web-based online health and supplement selling application. Created using C# and ASP.NET framework with SQL Server database. Implementing Domain-Driven Design (DDD) approach, this project consisting of 6 layers: Views, Controller, Handler, Factory, Repository, and Model.
# Layers
![img](https://drive.google.com/uc?export=view&id=1GLwPOTp7C2ejX5FImnie66vCwSEIeR46)  
## 1. Views  
View layer is responsible for showing information to the user and interpreting the user's commands, this layer is the home for all user interfaces.  
## 2. Controller  
This layer is responsible to validate all input from the view layer. It also responsible for delegating requests from the user to the next layer for further processing.  
## 3. Web Service
Enabling communication with difference application (Web, Desktop, Mobile, etc.).  
## 4. Handler
This layer is responsible to handle all business logic required in the application.  
## 5. Factory
Encapsulate the  Complex object creation process in this layer, creating consistent object.  
## 6. Repository
Repository layer is responsible for giving access to the database and model layer via its public interfaces to acquiring references to preexisting domain objects. It provides methods to manipulate the object which will encapsulate the actual manipulation operation of data in the database.  
## 7. Model
Model layer is responsible for representing concepts in the business or information about the business situation. The model layer is handled using entity framework tool called ADO.NET.  
# Entity Relational Diagram (ERD)
![img](https://drive.google.com/uc?export=view&id=1-a9pl170b4oLJsRPQqiyFizcRMVGCpwI)  
# Page Interface 
## 1. Login 
![img](https://drive.google.com/uc?export=view&id=1Dr18HuEO7hN28UUO-a8zjqssZ4HRW9fL)  
Page for guest to login into an account.  
## 2. Register 
![img](https://drive.google.com/uc?export=view&id=1pZzkT-jMd15oKnho0wD1uy70-Q9cF6l_)  
Page for guest to register an account.  
## 3. Order
![img](https://drive.google.com/uc?export=view&id=15PcfsU5srzxttqvX7227bsUEOALk60to)  
![img](https://drive.google.com/uc?export=view&id=1zhcmG20rrzUCV13-AvI5oklI5-ChnG_c)  
User can order a supplement by selecting certain items and input amount to cart, which later the cart will be submitted to order.  
## 4. History 
![img](https://drive.google.com/uc?export=view&id=1-zJXo3Xs42qACfw3Bc5McjhJ4jQZnXZ1)  
Page for User and Admin to see the order history and can inspect further for detail information by clicking view button.  
## 5. Transaction Detail
![img](https://drive.google.com/uc?export=view&id=1RNkObEayPB1REKG8Oc_SMadpB6QaE_EO)  
Page for User and Admin to see the detail information of certain transaction
## 6. Profile
![img](https://drive.google.com/uc?export=view&id=1pGNcMdrhHngfCBJcN1MFtEdqOHtNg1V3)  
Page for User and Admin to update their profile information and change password.  
## 7. Home
![img](https://drive.google.com/uc?export=view&id=1IIOyR7XP7erEP0XjqmI80ZnlqhxGhkQ1)  
Page for admin to see all account.  
## 8. Manage
![img](https://drive.google.com/uc?export=view&id=1FxsnrWfF_LdeaknEYUfkYnL8GNVtLbhG) 
Page for Admin to manage item either by insert new item, edit the existing item or delet it.  
## 9. Insert Supplement
![img](https://drive.google.com/uc?export=view&id=1ae-_ynTVJYFHSPODxVTp9gKpCjq5_aim)  
Page for inserting new item.  
## 10. Update Supplement
![img](https://drive.google.com/uc?export=view&id=1bIyuLoucRMcgJr4aJs_IWUnjIiPjspz9)  
Page for updating item.  
## 11. Queue
![img](https://drive.google.com/uc?export=view&id=19IEdw9I2IisD7CigSxzNUIlXNQXvWvMU)  
Page for admin to see the order queue and do action such change status from unhandle to handle by clicking handle button.  
## 12. Report
![img](https://drive.google.com/uc?export=view&id=1FxsnrWfF_LdeaknEYUfkYnL8GNVtLbhG)  
Page for admin to display all sales data using SAP Crystal Report.  
