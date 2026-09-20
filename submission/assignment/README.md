# C# Basics Assignment

## Overview

This console application demonstrates the fundamental C# concepts covered in the assignment. It includes primitive data types, type conversion, parsing, boxing and unboxing, value-type and reference-type behavior, scope, compound assignment operators, and bitwise operators.

## Topics Covered

- Primitive data types and `GetType()`
- Implicit and explicit type conversion
- Integer and floating-point division
- Boxing and unboxing
- `int.Parse()` and `int.TryParse()`
- Value types using a `Point` struct
- Reference types using the `Order` class
- Stack and heap behavior
- Variable and block scope
- Compound assignment operators
- Bitwise operators

## Project Structure

```text
CSharpBasicsAssignment/
├── assets/
│   ├── stack_heap_diagram_3.png
│   └── stack_heap_diagrams_1_2.png
├── ANSWERS.md
├── CSharpBasicsAssignment.csproj
├── Order.cs
├── Program.cs
├── README.md
└── STACK_HEAP.md
```

## Requirements

- .NET 9 SDK
- Visual Studio 2022, Visual Studio Code, or another C# editor

## How to Run

1. Open a terminal in the `CSharpBasicsAssignment` folder.
2. Restore and build the project:

   ```bash
   dotnet build
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

## Supporting Files

- `ANSWERS.md` contains the written assignment answers.
- `STACK_HEAP.md` contains three step-by-step memory diagrams and the handwritten diagrams.
- `Order.cs` contains the `Order` class used in the value-versus-reference demonstration.
