## **D → Dependency Inversion Principle (DIP)**

### **Definition**

High-level modules should not depend on low-level modules.
Both should depend on **abstractions (interfaces)**.
Also: abstractions should not depend on details; details should depend on abstractions.

### **Why?**

- Loose coupling
- Testable
- Easy to extend

### **Example**

❌ **Bad: High-level class depends directly on concrete class**

```csharp
class EmailService {
    public void SendEmail() { }
}

class Notification {
    private EmailService email = new EmailService();
    public void Send() => email.SendEmail();
}
```

✔️ **Good: Depend on interfaces**

```csharp
interface IMessageService {
    void SendMessage();
}

class EmailService : IMessageService {
    public void SendMessage() { }
}

class Notification {
    private readonly IMessageService _service;
    public Notification(IMessageService service) {
        _service = service;
    }
    public void Send() => _service.SendMessage();
}
```
