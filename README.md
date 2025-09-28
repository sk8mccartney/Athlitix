# **Athlitix**

*School project by Skate McCartney*

**Athlitix** is a sports event management and tracking application, designed to help organizers and participants efficiently monitor sporting events. The app integrates AI to predict outcomes based on participants' profiles and historical performance data.

---

## **Development Overview**

The project will be developed using **C#** on the **.NET Core** framework. Data will be persisted using an **MS SQL Server** database, managed through **Entity Framework** with a *code-first* approach.

The front-end interface will be built using a combination of **Razor Pages** for structured layout and **jQuery** for enhanced user interaction and dynamic UX features.

---

## **Key Technologies**

* **Backend:** C#, .NET Core
* **Database:** MS SQL Server, Entity Framework (Code First)
* **Frontend:** Razor Pages, jQuery
* **AI Integration:** Predictive analytics based on performance history and participant profiles

---

# 🧑‍💻 Athlitix — Coding Standards & Naming Conventions

This document outlines the coding standards and database naming conventions for the **Athlitix** project. These guidelines are designed to ensure consistency, maintainability, and scalability throughout development.

---

## 📌 General Guidelines

* Follow official **.NET Core (7/8)** coding conventions.
* Keep code clean, readable, and modular.
* Follow **SOLID principles** in application architecture.
* Avoid hard-coded values — use constants or configuration.
* Keep functions/methods **short and single-responsibility**.

---

## 🧱 C# Coding Standards

### ✅ Naming Conventions

| Type              | Convention               | Example                |
| ----------------- | ------------------------ | ---------------------- |
| **Class**         | `PascalCase`             | `EventManager`         |
| **Interface**     | `PascalCase`, prefix `I` | `IEventService`        |
| **Method**        | `PascalCase`             | `GetUpcomingEvents()`  |
| **Variable**      | `camelCase`              | `eventList`            |
| **Constant**      | `PascalCase`             | `DefaultPageSize`      |
| **Private Field** | `_camelCase` (optional)  | `_eventRepository`     |
| **Property**      | `PascalCase`             | `EventDate`            |
| **Enum**          | `PascalCase`             | `EventStatus.Upcoming` |

---

## 🧾 Database Naming Standards (Entity Framework Code-First)

### ✅ Table & Column Naming

| Type               | Convention                     | Example                         |
| ------------------ | ------------------------------ | ------------------------------- |
| **Table**          | `PascalCase`, Singular         | `Event`, `Participant`, `Venue` |
| **Column**         | `PascalCase`                   | `FirstName`, `EventDate`        |
| **Primary Key**    | `Id` or `EntityNameId`         | `Id`, `EventId`                 |
| **Foreign Key**    | `RelatedEntityId`              | `ParticipantId`, `EventId`      |
| **Junction Table** | `Singular`, alphabetical order | `EventParticipant`              |

> ✅ *Avoid plural table names — e.g., use `Event`, not `Events`.*

---

## 📂 Recommended Folder Structure

```
/Athlitix
│
├── Controllers         # Razor Page / API Controllers
├── Models              # Domain Models and DTOs
├── Data                # DbContext and EF Configurations
├── Services            # Business Logic Layer
├── Views               # Razor Views
├── wwwroot             # Static files (CSS, JS, images)
└── Migrations          # Entity Framework Migrations
```

---

## 🛠️ Best Practices

* Use **async/await** for all I/O-bound methods.
* Validate input with **Data Annotations** or **FluentValidation**.
* Use **DTOs** to avoid exposing domain models.
* Keep **DbContext** clean — configure via `OnModelCreating()` or Fluent API.
* Separate business logic into services, avoid bloated controllers.
* Consider **Feature Folders** if UI scales beyond a few views.

---

## 🧪 Optional Tooling

To enforce consistency:

* `.editorconfig` — Enforce code formatting and spacing.
* `StyleCop.Analyzers` — Static analysis for C# standards.
* `Prettier` / `ESLint` — If JS-heavy UI is added.



