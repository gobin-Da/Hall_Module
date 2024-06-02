## Hall Module System
-------------------------

An online hall management system built with ASP.NET MVC. This project aims to streamline and automate hall administration tasks.

## Features

- User Management: Manage Admin, Manager, Student and Staff profiles.
- Notice Board: Allows to manage notices and shows them to the user.
- Room Allocation: Efficient room assignment and tracking with categories.
- Building Allocation: Efficient building assignment and tracking.
- Administration: Helps to maintain policies with the allocation of the employees and access.
- Payment System: Handle fees and payments of products.
- Reporting: Generate various reports for administration.
- Apply: Fulfils the applying criteria for seat allocation.
- Settings: Provides a general setting to edit the hall information.

## Technologies Used

- ASP.NET MVC
- Entity Framework (Code First)
- Lambda Expressions
- SignalR
- Templates: SB-Admin2, jQuery UI, Bootstrap, csHTML, JavaScript

## Getting Started

- After running the application the user will be redirected to the home page. 
- In the home page there will be a login option in which admin, manager and students can login. First of all admin will be the first to logged in 
and will add the manager. The manager then will add the students. Through this process the accesses will be distributed.
- The accesses are based on the roles, they are: admin, manager and student.
     
   ROLES              ACCESS to Create and Modify                                      ACCESS to only Read
  
 1) ADMIN:          Notice, Buildings, Rooms, Administration, Apply, Settings          Dashboard, Members, Accounting, Reports
 2) MANAGER: 	      Members, Accounting, Apply                              	         Notice, Buildings, Rooms, Administration, Reports
 3) STUDENT: 	      Members, Accounting, Apply                              	         Notice, Buildings, Rooms, Administration, Reports

 
### Prerequisites

- Visual Studio
- SQL Server
- .NET Framework

### Installation

- Clone the repository:
     ```bash 
			git clone https://github.com/gobin-Da/Hall_Module.git
			cd HallModule
- Open the project: Open 'Hostel.sln' in visual studio
- Configure the database connection: Update the connection string in 'Web.config'
	<connectionStrings>
    		<add name="DefaultConnection" 
         	connectionString="Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;"
        	 providerName="System.Data.SqlClient" />
	</connectionStrings>
- Run the application: Build and run the project in visual studio.

### Usage

- Login: Access the system using admin credentials.
- Dashboard: Navigate through the user-friendly dashboard to manage hostel operations.

### Contributing
Contributions are welcome! Please fork the repository and submit a pull request.

### Contact
For any inquiries or issues, please contact gobin-Da.


