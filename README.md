Pizza Management Application
This is a full-stack pizza management application designed for restaurant owners and chefs to manage pizza toppings and recipes. The project demonstrates a robust backend implemented in C# and a modern frontend using HTML, CSS, and JavaScript.

Features
Owner Panel: Manage available toppings (add, edit, delete).
Chef Panel: Create new pizzas, edit existing ones, and manage toppings.
Persistent State: Data is stored and updated in memory for this local implementation.
Modern Design: The frontend mimics Visual Studio’s dark theme for a sleek UI.
Automated Tests: Includes a suite of tests to ensure the application functions as expected.
Prerequisites
For Building and Running Locally
.NET SDK (Version 6.0 or later)
Download .NET SDK
Node.js (Optional, if you plan to extend with npm packages)
Download Node.js
Visual Studio or any IDE with C# support (e.g., Visual Studio Code)
Setting Up the Project
1. Clone the Repository
bash
Copy code
git clone https://github.com/yourusername/PizzaManagementApp.git
cd PizzaManagementApp
2. Restore Dependencies
In the project directory, restore all dependencies:

bash
Copy code
dotnet restore
3. Build the Project
To build the project:

bash
Copy code
dotnet build
4. Run the Application
To run the application locally:

bash
Copy code
dotnet run
The application will be hosted on http://localhost:5000. Open the browser and navigate to the appropriate endpoints:

Owner Panel: http://localhost:5000/Home/OwnerLogin
Chef Panel: http://localhost:5000/Home/ChefLogin
Running Tests
The project includes an automated test suite that covers:

Backend endpoints (API functionality for toppings and pizzas).
Core functionalities like adding, editing, and deleting pizzas or toppings.
1. Run Tests
To execute the test suite:

bash
Copy code
dotnet test
2. Test Coverage
Ensure all major functionalities are covered, including:

Adding and deleting toppings.
Editing and updating pizzas.
Handling invalid or duplicate inputs gracefully.
3. Debugging Tests
Use Visual Studio or Visual Studio Code to debug test cases. Open the Test Explorer panel to inspect and run individual tests.
