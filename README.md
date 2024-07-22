# ASP.NET Calculator

This is a simple calculator project developed in C# using ASP.NET. The calculator performs basic operations such as addition, subtraction, multiplication, and division. Additionally, the project includes automated tests using xUnit, AutoFixture, Moq, and FluentAssertions.

## Features
- Addition
- Subtraction
- Multiplication
- Division

## Project Structure

```plaintext
CalculadoraASP.NET/
├── CalculadoraASP.NET.sln
├── src/
│   ├── BasicUnitTesting/
│   │   ├── Calculator.cs
│   │   ├── ICalculator.cs
│   │   ├── Program.cs
│   │   ├── BasicUnitTesting.csproj
│   ├── MathematicalOperations/
│   │   ├── Operations.cs
│   ├── MathematicalOperations.Test/
│   │   ├── CalculatorTest.cs
│   │   ├── MathematicalOperations.Test.csproj
├── README.md
```
## Prerequisites
- .NET 6 SDK
- Visual Studio 2022

---

# How to Run the Project
### 1.Clone the repository:
`` git clone https://github.com/eduardoaalmeidaa/basicUnitTesting.git ``
`` cd basicUnitTesting ``
### 2.Navigate to the project directory:
`` cd src/BasicUnitTesting ``
### 3.Run the project:
`` dotnet run ``
### 4.Access the calculator in your browser at: ``http://localhost:5000``

---

# Automated Tests
### The tests are performed using xUnit, AutoFixture, Moq, and FluentAssertions.
## Running the Tests
### 1.Navigate to the test directory:
`` cd src/MathematicalOperations.Test ``
### 2.Run the tests:
`` dotnet test ``

---

## Test Structure
### The tests are organized in the following files:
`` CalculatorTest.cs: Tests for the Calculator class and the Operations service ``

## Packages Used
- xUnit
- AutoFixture
- Moq
- FluentAssertions


