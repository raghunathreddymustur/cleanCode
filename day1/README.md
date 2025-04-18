# Clean Coding Practices - Day 1

This document outlines the clean coding practices covered in the Day 1 exercises, focusing on the concepts demonstrated in the files: `functions.txt`, `meaningFulNames.txt`, and `variables.txt`.

## Key Concepts

### 1. Functions

-   **Principle:** Functions should be small and focused, performing a single, well-defined task.
-   **Guideline:** Keep functions concise, typically no more than 20 lines of code.
- **Guideline**:  Name your functions well, a function name should indicate its purpose.
-   **Example:** A function to calculate the area of a rectangle.

### 2. Meaningful Names

-   **Principle:** Choose names that accurately describe what a variable, function, or class represents.
-   **Guideline:** Use descriptive and pronounceable names.
-   **Guideline:** Be consistent in your naming conventions.
- **Guideline:** Names should reveal intent.
-   **Example:** Instead of `x`, use `numberOfStudents` or `studentCount`.

### 3. Variables

-   **Principle:** Declare variables close to their usage and keep their scope as narrow as possible.
-   **Guideline:** Avoid unnecessary global variables.
-   **Guideline:** Initialize variables upon declaration whenever possible.
- **Guideline:** avoid having a variable that holds multiple meanings.
-   **Example:** Instead of declaring all variables at the beginning of a method, declare them just before they are needed.

## Code Example (Java)
```
java
public class Rectangle {

    private double length;
    private double width;

    public Rectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }
    // Calculate the area of a rectangle.
    public double calculateArea() {
        return length * width;
    }
    //check if the side is valid.
    private boolean isValidSide(double side){
      return side > 0;
    }
    // set the length of the side
    public void setLength(double length){
      if (isValidSide(length)){
          this.length = length;
       }
    }

    public void setWidth(double width){
      if (isValidSide(width)){
        this.width = width;
      }
    }
     public static void main(String[] args) {
        Rectangle myRectangle = new Rectangle(5, 10);
        double area = myRectangle.calculateArea();
        System.out.println("Area of the rectangle: " + area);
    }
}
```
## Conclusion

By following these clean coding practices, we aim to write code that is easier to understand, maintain, and extend. The exercises in Day 1 set the foundation for these principles.