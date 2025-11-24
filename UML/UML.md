# Dependency vs Association vs Aggregation vs Composition

## 1️⃣ Dependency (weakest relationship)

### ✔ Meaning

One class **uses** another class **temporarily**.
Only needed for a moment (e.g., inside a method).

### ✔ Example

```csharp
class Car
{
    void Start(Engine engine)   // engine is used temporarily
    {
        engine.Run();
    }
}
```

### ✔ UML Arrow

```
Car -- - - - > Engine   (dependency)
```

### ✔ When to use

- Helper objects
- Method parameters
- Local variables

---

## 2️⃣ Association (general long-term relationship)

### ✔ Meaning

One class **knows** another class.
Both can exist independently.
“HAS A” relationship.

### ✔ Example

```csharp
class Driver
{
    private Car car;  // Driver has a Car
}
```

### ✔ UML Arrow

```
Driver ─────────> Car    (association)
```

### ✔ When to use

- One object stores a reference to another
- No ownership

---

## 3️⃣ Aggregation (weak ownership)

### ✔ Meaning

One class **owns** another class **partially**,
but the owned object can live **without** the owner.

“Whole-part but independent.”

### ✔ Example

```csharp
class Team
{
    List<Player> Players;  // Players can exist without the team
}
```

### ✔ UML Arrow

```
Team ⬦─────────> Player   (aggregation)
```

### ✔ When to use

- Parent-child relationship
- Child has separate life

---

## 4️⃣ Composition (strong ownership)

### ✔ Meaning

One class **completely owns** another class.
If the parent dies → the child dies.

“Whole-part but dependent.”

### ✔ Example

```csharp
class House
{
    private Room room = new Room(); // Room's life depends on House
}
```

### ✔ UML Arrow

```
House ◆─────────> Room    (composition)
```

### ✔ When to use

- Strong ownership
- Lifecycles tightly connected

---

# 🎯 Comparison Table

| Concept         | Lifetime Relationship    | UML Symbol     | Example          |
| --------------- | ------------------------ | -------------- | ---------------- |
| **Dependency**  | Temporary                | Dashed arrow   | Method parameter |
| **Association** | Long-term reference      | Solid arrow    | Driver → Car     |
| **Aggregation** | Whole-part (independent) | Empty diamond  | Team → Player    |
| **Composition** | Whole-part (dependent)   | Filled diamond | House → Room     |

---

# 🧠 Memory Trick

- **Dependency** → “uses”
- **Association** → “knows”
- **Aggregation** → “has (but not owns)”
- **Composition** → “owns”

---

If you'd like, I can also generate a **clean UML diagram image** for this explanation.
