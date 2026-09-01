# Rectangle Calculator – VB.NET

## About This Project

This project is a simple **Rectangle Calculator** built using **VB.NET Windows Forms**. I created it as a teaching project to help students understand the basics of programming, user input, variables, calculations, and displaying results.

The application allows a user to enter the **length** and **width** of a rectangle and then calculates its:

* Area
* Perimeter

## Learning Objectives

While working on this project, I was teaching students how to:

* Create a Windows Forms application using VB.NET.
* Design a simple user interface using the Form Designer.
* Use `TextBox` controls to accept user input.
* Use a `Button` to perform calculations.
* Declare and use variables.
* Convert TextBox values into numbers using `Convert.ToDouble()`.
* Apply mathematical formulas in a program.
* Display calculated results on the form.

## Rectangle Formulas

Students learned the two basic formulas used in the application.

### Area

The area of a rectangle is calculated using:

```text
Area = Length × Width
```

In VB.NET:

```vb
Dim area As Double = length * width
```

### Perimeter

The perimeter of a rectangle is calculated using:

```text
Perimeter = 2 × (Length + Width)
```

In VB.NET:

```vb
Dim perimeter As Double = 2 * (length + width)
```

## Converting User Input

Values entered into a TextBox are treated as text. Before using them in calculations, we convert them into `Double` values.

```vb
Dim length As Double = Convert.ToDouble(txtLength.Text)
Dim width As Double = Convert.ToDouble(txtWidth.Text)
```

This allows the program to work with both whole numbers and decimal values.

## Example

If the user enters:

```text
Length = 10
Width = 5
```

The program calculates:

```text
Area = 50
Perimeter = 30
```

If decimal values are entered, the program can also calculate decimal results because the values are stored as `Double`.

## Interface

The form contains:

* **Length TextBox** – Used to enter the length.
* **Width TextBox** – Used to enter the width.
* **Calculate Button** – Performs the calculations.
* **Area TextBox** – Displays the calculated area.
* **Perimeter TextBox** – Displays the calculated perimeter.

## Concepts Covered

| Concept               | What Students Learned                |
| --------------------- | ------------------------------------ |
| Windows Forms         | Creating a graphical application     |
| TextBox               | Receiving and displaying information |
| Button                | Triggering calculations              |
| Variables             | Storing values                       |
| `Double`              | Working with numbers and decimals    |
| `Convert.ToDouble()`  | Converting text into numbers         |
| Multiplication        | Calculating area                     |
| Addition              | Used in the perimeter formula        |
| Mathematical formulas | Applying formulas in code            |

## Technologies Used

* VB.NET
* Windows Forms
* Visual Studio

## Purpose of the Project

This project was created as a **beginner-friendly teaching exercise**. The goal was not only to build a working rectangle calculator, but also to help students understand how programming concepts can be applied to solve a real mathematical problem.

It provides a good foundation for moving on to more advanced topics such as **input validation, error handling, conditional statements, and larger Windows Forms applications**.
