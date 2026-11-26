<div align="center">

# Property Rental Management System (C#)

### Object-Oriented Domain Modeling for Real Estate Lease Administration

> A modular **C# / .NET 8.0** application developed for the Object-Oriented Programming course, modeling core real estate rental operations—properties, tenants, landlords, lease agreements, rent tracking, and receipt generation—using clean OOP principles.

[![C#](https://img.shields.io/badge/C%23-OOP-239120?style=flat-square&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Visual Studio](https://img.shields.io/badge/IDE-Visual_Studio-5C2D91?style=flat-square&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)
[![UPCA](https://img.shields.io/badge/UPCA-LESI-009639?style=flat-square)](https://www.ipca.pt/)

</div>

---

## Academic Context

| | |
|---|---|
| **Institution** | Polytechnic University of Cávado and Ave (UPCA) |
| **Degree** | B.Sc. in Computer Systems Engineering |
| **Course** | Object-Oriented Programming (OOP) |

---

## Table of Contents

- [Overview](#overview)
- [Core OOP Concepts Applied](#core-oop-concepts-applied)
- [Domain Model Architecture](#domain-model-architecture)
- [Project Structure](#project-structure)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Author](#author)

---

## Overview

The **Property Rental Management System** is a C# application designed to model and organize the core entities and workflows of residential or commercial property leasing: properties, tenants, landlords, lease contracts, rent records, and payment receipts.

The primary focus of the project is applying foundational **Object-Oriented Programming (OOP)** principles to a real-world domain—emphasizing clean class hierarchies, strong encapsulation, modular organization, and clear separation of responsibilities.

---

## Core OOP Concepts Applied

| Concept | Implementation in Project |
| :--- | :--- |
| **Classes and Objects** | Models real-world domain entities (`Imovel`, `Contrato`, `Renda`, `Recibo`) as cohesive, strongly typed classes. |
| **Encapsulation** | Protects internal entity state behind controlled properties and methods, ensuring data integrity across operations. |
| **Inheritance** | Factors shared personal attributes into the `Pessoa` base class, extended by specialized `Inquilino` (Tenant) and `Senhorio` (Landlord) subclasses. |
| **Modular Code Organization** | Isolates each domain entity into its own dedicated source file for maintainability and readability. |
| **Separation of Responsibilities** | Assigns each class a distinct, well-defined role within the rental lifecycle—from property registration to receipt issuance. |

---

## Domain Model Architecture

```text
                    ┌──────────────────┐
                    │      Pessoa      │
                    └────────┬─────────┘
                             │
             ┌───────────────┴───────────────┐
             ▼                               ▼
    ┌────────────────┐              ┌────────────────┐
    │   Inquilino    │              │    Senhorio    │
    │    (Tenant)    │              │   (Landlord)   │
    └───────┬────────┘              └───────┬────────┘
            │                               │
            │       ┌────────────────┐      │
            └──────►│    Contrato    │◄─────┘
                    │   (Contract)   │
                    └───────┬────────┘
                            │
             ┌──────────────┴──────────────┐
             ▼                             ▼
    ┌────────────────┐            ┌────────────────┐
    │     Imovel     │            │     Renda      │
    │   (Property)   │            │     (Rent)     │
    └────────────────┘            └───────┬────────┘
                                          │
                                          ▼
                                 ┌────────────────┐
                                 │     Recibo     │
                                 │   (Receipt)    │
                                 └────────────────┘
```

---

## Project Structure

Core files and classes in the solution:

| File | Role |
| :--- | :--- |
| `Program.cs` | Application entry point and execution workflow |
| `Pessoa.cs` | Base class encapsulating common attributes for people |
| `Inquilino.cs` | Subclass of `Pessoa` representing a tenant |
| `Senhorio.cs` | Subclass of `Pessoa` representing a landlord |
| `Imovel.cs` | Represents a rental property and its attributes |
| `Contrato.cs` | Manages lease agreements linking landlords, tenants, and properties |
| `Renda.cs` | Tracks rent details and payment obligations |
| `Recibo.cs` | Handles payment receipt issuance |

---

## Tech Stack

| Technology | Version / Scope | Purpose |
| :--- | :--- | :--- |
| **C#** | Modern C# | Primary object-oriented programming language |
| **.NET** | 8.0 | Runtime and SDK |
| **Visual Studio** | — | Integrated development environment (IDE) |

---

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (or any compatible C# IDE / CLI)

### 1. Clone the Repository

```bash
git clone [https://github.com/Brito21x/GestaoRendasImoveis.git](https://github.com/Brito21x/GestaoRendasImoveis.git)
cd GestaoRendasImoveis
```

### 2. Build and Run

Using the .NET CLI:

```bash
dotnet restore
dotnet build
dotnet run
```

Alternatively, open the `.sln` file in **Visual Studio** and press `F5` (or click **Run**) to build and execute the application.

---

## Author

**Edgar Brito** · Polytechnic University of Cávado and Ave (UPCA)  
Computer Systems Engineering

[![GitHub](https://img.shields.io/badge/GitHub-Brito21x-181717?style=flat-square&logo=github&logoColor=white)](https://github.com/Brito21x)
