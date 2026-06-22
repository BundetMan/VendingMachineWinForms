# Vending Machine System

A desktop vending machine simulation built with **C# WinForms**, **EF Core**, and **Microsoft SQL Server**. The project was developed as a hands-on exercise in applying classic **Object-Oriented Analysis & Design (OOAD)** patterns to a real, interactive application — covering both the customer-facing vending experience and an admin dashboard for inventory/sales management.

## Features

### Customer Side
- Browse products by category (**All / Drink / Snacks**)
- Insert money with currency selection (e.g. KHR)
- Live balance tracking as money is inserted
- Purchase products via **Buy Now**, with real-time stock and state feedback
- On-screen machine state indicator (e.g. `Idle`, `HasMoney`, `Dispensing`)

### Admin Dashboard
- Overview metrics: **Total Revenue**, **Total Sales**, **Total Products**, **Low Stock / Needs Restocking**
- Full product management: **Add**, **Edit**, **Delete**
- Refresh inventory view in real time
- Stock and pricing management per product

## Design Patterns Used

This project was built specifically to apply real OOAD design patterns rather than just implementing basic CRUD logic:

| Pattern | Purpose in this project |
|---|---|
| **State** | Manages the vending machine's operational states (e.g. idle, has money, dispensing, out of stock) and the transitions between them |
| **Strategy** | Enables interchangeable payment handling logic via `IPaymentStrategy` |
| **Observer** | Notifies UI components in real time when machine state or balance changes, via a registered list of `IObserver` listeners |
| **Factory** | Abstracts product creation through `ProductFactory`, decoupling product instantiation from the rest of the system |
| **Singleton** | Ensures a single shared `DbContextManager` instance is used for all database access |

## Tech Stack

- **C# / .NET WinForms** — desktop UI
- **Entity Framework Core** — ORM / data access
- **Microsoft SQL Server** — persistent storage for products, stock, and sales
- **OOAD Design Patterns** — State, Strategy, Observer, Factory, Singleton

## Project Structure

```
VendingMachinePro/
├── Logic/
│   ├── Data/                     # DbContextManager (Singleton) and EF Core context
│   ├── FactoryMethodPattern/     # ProductFactory and product creation logic
│   ├── ObserverPattern/          # IObserver and UI notification logic
│   ├── StatePattern/             # IVendingState and concrete state implementations
│   └── StrategyPattern/          # IPaymentStrategy and payment implementations
├── Migrations/                   # EF Core migrations
├── Models/
│   ├── Product.cs
│   ├── Sale.cs
│   └── VendingMachine.cs
├── Resources/                     # Images/icons used in the UI
├── AddProduct.cs                  # Admin: add product form
├── AdminDashboard.cs               # Admin dashboard
├── AllForm.cs                      # Customer-facing vending UI
├── EditForm.cs                     # Admin: edit product form
├── SuccessForm.cs                  # Purchase success confirmation
└── Program.cs
```

## Getting Started

### Prerequisites
- .NET (version used in this project)
- Microsoft SQL Server (local or remote instance)
- Visual Studio (recommended for WinForms development)

### Setup
1. Clone the repository
   ```bash
   git clone https://github.com/BundetMan/VendingMachineWinForms
   ```
2. Update the connection string in your configuration to point to your SQL Server instance.
3. Apply EF Core migrations to create the database schema:
   ```bash
   dotnet ef database update
   ```
4. Build and run the project from Visual Studio (or `dotnet run` if applicable).

### Seeding Products
Use the **Admin Dashboard → Add New Product** form to populate initial inventory, or seed directly via the database if a seed script is provided.

## Notes

- This project was built as a learning exercise to practice OOAD principles in a practical, interactive application — not intended for production/commercial use.
- Currency and pricing are configured for **KHR (Cambodian Riel)** by default but can be adapted.

## License

This project is provided for educational/demonstration purposes.
