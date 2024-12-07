# Pizza Management Application

This is a full-stack pizza management application designed for restaurant owners and chefs to manage pizza toppings and recipes. The project demonstrates a robust backend implemented in C# and a modern frontend using HTML, CSS, and JavaScript.

## Features

- **Owner Panel**: Manage available toppings (add, edit, delete).
- **Chef Panel**: Create new pizzas, edit existing ones, and manage toppings.
- **Persistent State**: Data is stored and updated in memory for this local implementation.
- **Modern Design**: The frontend mimics Visual Studio’s dark theme for a sleek UI.
- **Automated Tests**: Includes a suite of tests to ensure the application functions as expected.

---

## Prerequisites

### For Building and Running Locally
1. **.NET SDK** (Version 6.0 or later)  
   [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
2. **Node.js** (Optional, if you plan to extend with npm packages)  
   [Download Node.js](https://nodejs.org/)
3. **Visual Studio** or any IDE with C# support (e.g., Visual Studio Code)

---

## Setting Up the Project

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/PizzaManagementApp.git
cd PizzaManagementApp
```
### 2. Restore Dependencies
```bash
dotnet restore
```
### 3. Build the Project
To build the project:
```bash
dotnet build
```
### 4. Run the Application
```bash
dotnet run
```
