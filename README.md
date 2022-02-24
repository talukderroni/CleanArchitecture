# CleanArchitecture
Clean CleanArchitecture Desinger Pattern For .Net MVC.
It is also known as Onion Architecture. In this Diagram dependencies flow go to the Innner circle. The Application Core has no dependencies on the other layer. And you can see on the diagram that the Application Core has no dependencies on other application layers.The Domain and Appliction is the Core the solution.Outside of the application core the The UI Interface and InFrastecture  depends on the core but not depend one another.
![image](https://user-images.githubusercontent.com/28187435/155486463-eeee6287-4619-4963-80ca-eece08579192.png)
 # Goal
The Goal of this Repository is to provide basic Solution Architecture for Domain Driven Design.
This Solution provides Independent of Database and Frameworks. 
The Independence of UI helps to change easily, without changing the rest of the system and business rules.
The Separation Layer Provides Maintanable Application.

# Domain
The Domain layer consists of all Model or Entities Class of the entire Application.It Sperate the Application From Other layers.It Does not depend on other Layer

# Application Layer
This Layer mainly consists of the Business Logic and Services and All other Interfaces. Service like  Email Can be Included Here.

![OnionMainLayer](https://user-images.githubusercontent.com/28187435/155490988-aa19c512-bb37-49ad-a61c-d966a866080e.png)

# Infrastructure Layer
The Database Context Class is InCluded Here.And Other Dependecy Injection like Invertion of Controll is also Applied in this layer.
Since this Layer is Dependent on Domain That's why You have to Add Referece to this Class Library.For DbContext class You have to add EntityFrameWork references.

# UI Layer
This is the entry Point of your Application.It Currently use The MVC architecture. The Area , Controller ,Content ,View and Config file is Included Here.Since this Layer is Dependent on Domain That's why You have to Add Referece to this
You can also Add another layer like Api and Test For optimize the Application.

![allLayer](https://user-images.githubusercontent.com/28187435/155491043-c4826502-6b41-42da-a5e1-40b426f8033e.png)
