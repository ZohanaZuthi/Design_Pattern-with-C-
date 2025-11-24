## **L → Liskov Substitution Principle (LSP)**

### **Definition**

Objects of a parent class should be replaceable with objects of its child class **without breaking the program**.

### **Why?**

- Ensures inheritance is logical
- Prevents unexpected behavior when using subclasses

### **Example**

❌ **Bad: Subclass breaks parent behavior**

```csharp
class Bird { public virtual void Fly() { } }

class Ostrich : Bird { public override void Fly() => throw new Exception(); }
```

✔️ **Good: Split hierarchy**

```csharp
class Bird { }
class FlyingBird : Bird { public virtual void Fly() { } }
class Ostrich : Bird { }
class Sparrow : FlyingBird { public override void Fly() { } }
```

---
