## **I → Interface Segregation Principle (ISP)**

### **Definition**

Do not force a class to implement interfaces it does **not** use.
→ Prefer **small, specific interfaces** over large, general ones.

### **Why?**

- Classes remain clean
- Interfaces stay meaningful

### **Example**

❌ **Bad: One fat interface**

```csharp
interface IWorker {
    void Work();
    void Eat();
}
```

Robots don’t eat, so this is wrong.

✔️ **Good: Split interfaces**

```csharp
interface IWork { void Work(); }
interface IEat { void Eat(); }
```

Robot implements only what it needs.

---
