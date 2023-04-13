Install the following to get the required environment:
- .NET 5.0 Runtime
- Node.js
- React
- SQL Server with following: DB: TasksDB    
							 user: 'TrueNorth' 
							 password: 'Fabris2023' 

Steps to run the Exercise:

Inside the main folder (TN-Exercise):

Go to Exercise_Backend, then run CMD on it with the following commands: dotnet build
																		dotnet run
Go to Exercise_Frontend, then run CMD on it with the following commands: 'npm start'

Back-end should be listening on port 5001
Front-end should be started on port 3000

You can run front-end directly from Visual studio code from a terminal with the same command, also you can run back-end from visual studio, but running with docker (if IIS then the listening port will be 44300)

Database should be created when running first time via migrations.

Database structure:
Database: TasksDB
Table: Task 
Columns: Id (PK) int, not null
		 Title nvarchar 50, not null
		 IsDone bit, not null
		 
		 

