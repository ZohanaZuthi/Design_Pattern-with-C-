## **O → Open/Closed Principle (OCP)**

### **Definition**

A class should be **open for extension** but **closed for modification**.
→ You should not modify existing code to add new features; you should **extend** it.

### **Why?**

- Reduces bugs in tested code
- Supports new features without breaking old ones

### **Example**

Using polymorphism instead of editing a class repeatedly:

```csharp
abstract class Shape {
    public abstract double Area();
}

class Circle : Shape {
    public override double Area() => 3.14 * 5 * 5;
}

class Rectangle : Shape {
    public override double Area() => 10 * 5;
}
```

When you add a new shape, you **create a new class**, not modify old ones.

---
