# Unexpected Behavior with Implicit Operator Overloading and Arithmetic Operations in C#

This repository demonstrates a subtle bug that can occur when using implicit operator overloading in C# along with arithmetic operations.  The implicit conversion between a custom class and an integer type might lead to unexpected behavior if not handled correctly.

The `bug.cs` file contains code that showcases this issue.  The `bugSolution.cs` file provides a solution.  The core problem is the lack of explicit operator overloading for arithmetic operations in the original code.