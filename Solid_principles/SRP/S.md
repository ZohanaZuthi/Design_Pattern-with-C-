# **SOLID Principles (Markdown Version)**

SOLID is an acronym for **five design principles** that make object-oriented code **cleaner, maintainable, extendable, and less error-prone**.
These principles were popularized by **Robert C. Martin (Uncle Bob)**.

---

## **S → Single Responsibility Principle (SRP)**

### **Definition**

A class should have **only one reason to change**.
It should do **one job** and do it well.

### **Why?**

- Easier to maintain
- Less chance of breaking other features
- Promotes clean separation of concerns

### **Example**

❌ **Bad: One class doing many things**

```csharp
class Report {
    public void GenerateReport() { }
    public void PrintReport() { }
    public void SaveToDatabase() { }
}
```

✔️ **Good: Split responsibilities**

```csharp
class ReportGenerator { public void Generate() { } }
class ReportPrinter { public void Print() { } }
class ReportRepository { public void Save() { } }
```

---
