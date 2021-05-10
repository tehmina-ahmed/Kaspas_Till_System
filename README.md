# Kaspas Self-Service Till System - SFIA 1 

Project Contributor: Tehmina Ahmed 
Copyright (c) 2021 KaspasTill

## Abstract
The KaspasTill App was planned, designed and has been documented in this ReadMe.MD to show the process of the project. Agile Methodology was used throughout the project to ensure efficiency where possible. It's a Responsive till system App using CRUD functionality. Allowing users to Create an item, View the item, update it and delete it if need be. 
Kaspas LTD is an ice cream parlour that provides the user with the ability to create a dessert of choice and enter it into the MySQL database. The option for the user is to be able to Create a Dessert and a Topping (as their product of choice), to view it, update it and/ delete it based on their liking of the product. The idea behind this App is to give the user control of their products - essentially replicating the purpose of a self service till. This idea stems from a theory of customer journey where it is beleived that in modern times, the customer should be given more control of their product journey in order to ensure higher rates of satisfaction. This theory has been applied to the Till app to assess this hypothesis. 



## Aims & Objectives 
  Aims                                                    | Objectives                                                                     |
| :----------------------------------------------------:  | :------------------------------------------------------------------------------:
| 1) Create a solution to a real business problem         | a) Curate an idea that solves an issue                                          |
| 2) Design a Full Stack App                              | b) Create a High Fidelity ProtoType/Wireframe with Lucid                        |
| 3) Setup Agile Methodology software                     | c) Create Trello board, Jira, GitHub and set time goals                         |
| 4) Implement App using CRUD Functionality               | d) Use Technologies listed below to implement App                               |
| 5) Test App using BlackBox, WhiteBox, UNIT & X testing  | e) Use Automation testing and test each feature of the App against requirements |
| 6) Use CI & CD to ensure efficient version control      | f) Use GitHub and Visual Studio to continously integrate and deploy App edits   |
| 7) Deploy App                                           | g) Deploy App using Azure DevOps or Pipelines                                   |



## Technologies & Methodologies Used
* Project Management: Agile methodology, Kanban - Trello, Jira, GitHub 
* MySQL Databases
* C#
* HTML
* CSS
* ASP.NET
* Git
* Continous Integration
* Azure Portal
* MySQL WorkBench 
* LucidSpark
* Jira

## Essential Features 
### Agile Methodology 
<p align="center">
  <img width="600" height="350" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Trello%20Board.png">
</p>
Here is the Trello Kanban Board used to track tasks against time and the priority order of them. The Board displays tasks that were ordered into...
To-Do,
 In Progress, and, 
 Done 
This was helpful and was used as an online diary for me to keep track of my tasks. 

## Requirements - using Moscow Prioritisation
<p align="center">
  <img width="600" height="350" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/MoSCoW%20prioritization.png">
</p>
This technique allowed me to see which requirements would be essential to implement VS. requirements which would be a stretch goal. 

## Initial Documentation (before idea modification)

### Jira Backlog 
<p align="center">
  <img width="600" height="350" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Jira%20Board.png">
</p>
Above is the Backlog for the previously intended MVP (minimum viable product) which was the initial plan. The App was initially designed to allows customers to create an order by appending one or more products to their order. However due to time constraints, this idea had to be modified to realistically meet the deadline. And so, the idea and database tables was simplified so that the user creates their own idea of a dessert with a topping. 

### Database ER Diagram (inc. stretch goal tables) 

<p align="center">
  <img width="550" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/KaspasTill%20Database%20ER%20Diagram%20-%20Database%20ER%20diagram%20(crow's%20foot).png">
</p>
This ER Diagram included four tables that were to be appended to the KaspasDB Database using C# to implement them and MySQL WorkBench to modify and view them. The MySQL WorkBench was utilising an Azure single server to satisfy its connection string with. The updated Diagram below shows how in actuality, the minimum requirements of only two databases were implemented due to some programming bugs and a lack of time to display them on the front end successfully. Due to this, the Products and Toppings tables were chosen to be implemented. 


### Design - Wireframes 



Home Page                                                                                                           |  Order Page
:-----------------------------------------------------------------------------------------------------------------: |:-------------------------:
![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Kaspas%20App%20HF%20ProtoType.png)  | ![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/HF%20ProtoType%20Order%20page.png) |

These ProtoTypes were designed on paper first as initial designs and were then digitally created using LucidSpark. This was done to create a visual guide as to how the App should look - however it was understood that this would be a stretch goal and the aesthetics of the app were to only be focused on once the CRUD functionality and other requirements had been implemented successfully

### User Stories 

Place Order                                                                                                         |  Delete Order
:-----------------------------------------------------------------------------------------------------------------: |:-------------------------:
![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/User%20Story%20Delete%20Order.png)  | ![](https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/User%20Story%20Place%20Order.png) |

The user stories display scenarios of how the App interacts with user actions. The user could place an order by appending products, and could also delete an order. 


## Updated Documentation (After idea modification)

### Updated Database ER Diagram 
<p align="center">
  <img width="550" height="520" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Updated%20ER%20Database%20Diagram%20Kaspas%20App.png">
</p>

The updated Diagram shows the relationship between the two MVP tables which are that one product can have ONE OR MANY toppings (or that one or many toppings can be applied to one product). This is a simple real life concept which was more realistic to implement alongside the  time constraints. The context was also more logical as creating a products and orders tables as MVP would have been complicated without creating a customers' table also. 

### Risk Assessment 
<p align="center">
  <img width="750" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/RA%201.png">
</p>
<p align="center">
  <img width="750" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/ra%202.png">
</p>
<p align="center">
  <img width="750" height="550" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/ra%203.png">
</p>
<p align="center">
  <img width="750" height="475" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/RA%204.png">
</p>

### Updated Trello Board 
<p align="center">
  <img width="750" height="475" src="https://github.com/tehmina-ahmed/Kaspas_Till_System/blob/main/Documentation/Updated%20Trello.png">
</p>
Here is the Updated Kanban Trello board which shows i have completed majority of the MVP requirements. 

## Report 
What I did well                                                                                                     |  How could I improve?
:-----------------------------------------------------------------------------------------------------------------: |:--------------------------------------------:
| 1) I successfully designed my App using wireframes                                                                | a) I could have created my stretch goal databases
| 2) I used Agile methodology throughout the project to manage tasks and time                                       | b) could have used CSS/BootStrap to make App prettier
| 3) I successfully created my MVP database tables using C# and MySQL                                               | c) Could have integrated more JavaScript
| 4) I successfully connected to Azure services and MySQL workbench 8.0                                             | d) Could have done more CI using GitHub if it connected
| 5) I successfully used HTML, CSS & C# with ASP.NET to create an MVC App with CRUD functionality                   | e) Could have implemented Testing by fixing bugs
| 6) I was able to identify and find solutions to risks associated with development in the matrix                   | f) Could have used Angular as part of front end
| 7) I was able to deploy the App to a satisfactory requirement level                                               | g) Deploy via Azure Pipelines 



## Developer
Tehmina Ahmed 





