# InvoiceApp

## Purpose and Scope
The **InvoiceApp** is an **ASP.NET Core Razor Pages** application designed for **invoice management**. It supports full **CRUD** (Create, Read, Update, Delete) operations, with an emphasis on **invoice creation**.

The application allows users to:
- Create, view, edit, and delete invoices
- Maintain invoice details, client information, service descriptions, and pricing
- Perform **live total price calculations** and **server-side validations**

For more details:
- See: **Creating Invoices**, **Listing and Viewing Invoices**, **Editing Invoices**, **Deleting Invoices**
- Architecture details: **System Architecture**
- Data Model specifications: **Data Models and Validation**

---

## Architecture Overview

| Layer           | Purpose                           | Key Components                      |
|-----------------|-----------------------------------|-------------------------------------|
| Presentation    | User interface and form rendering | Razor Pages (`.cshtml` files)       |
| Page Model      | Business logic and request handling | PageModel classes (`.cshtml.cs` files) |
| Data Transfer   | Form binding and validation       | `InvoiceDto` class                 |
| Entity           | Database representation           | `Invoice` entity class             |
| Data Access     | Database operations              | `ApplicationDbContextClass`        |

---

## Technology Stack and Dependencies

| Technology               | Purpose                      | Implementation Details                                   |
|---------------------------|------------------------------|-----------------------------------------------------------------|
| ASP.NET Core Razor Pages | Web framework                | Page-based architecture with code-behind models           |
| Entity Framework Core     | Data access                | `ApplicationDbContextClass` with `Invoices` DbSet       |
| Bootstrap                | UI framework                | Responsive cards, forms, and table layouts              |
| JavaScript                | Client-side logic           | Real-time total price calculations (`updateTotalPrice()`) |
| Data Annotations          | Validation                 | Attributes like `[Required]`, `[Range]`, `[EmailAddress]`, `[Phone]` |

---

## Client-Side Features
- **Real-time calculations**: `updateTotalPrice()` automatically recalculates totals when quantity or unit price changes.
- **Validation**: Client-side validations work in tandem with server-side rules.
- **Responsive design**: Leverages Bootstrap classes for mobile-friendly forms and tables.

---

## Validation Rules
- **Number, Status, Service, ClientName**: Required
- **UnitPrice**: Must be in range **1–999,999**
- **Quantity**: Must be in range **1–99**
- **Email**: Must match a valid email format
- **Phone**: Must match a valid phone number format
