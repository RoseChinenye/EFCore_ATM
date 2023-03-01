# BANK ATM WITH EFCORE 😃👓👓

## About 👓

This is a simple implementation of Bank ATM application using Entity Framework Core.

---
## Definition of Terms 👓

**Entity Framework core (EF CORE) :**
EF provides the capability to interact with data from relational databases using an object model that maps directly to the business objects (or domain objects) in your application. For example, rather than treating a batch of data as a collection of rows and columns, you can operate on a collection of strongly typed objects termed entities. These entities are held in specialized collection classes that are LINQ aware, enabling data access operations using C# code. 

---
## ATM SERVICES 👓

- Deposit
- Withdrawal
- Check Balance
- Transfer

N/B : All the operations done in this ATM are saved!

---
## Demo Login Credentials 👓

| Account Number | Pin |
| ----------- | ----------- |
| 1234567891 | 2345 |
| 1234567892 | 3456 |
| 1234567893 | 4567 |
| 1234567894 | 5678 |
| 1234567895 | 6789 |
| 1234567895 | 6789 |
| 122345678 | 7811 |
| 4338838337 | 3388 |
| 27920222 | 3888 |
| 2913533 | 6443 |
| 55555555 | 5443 |
| 666445555 | 7443 |
| 922828225 | 7443 |

---
## Steps to Run 👓

Follow the following steps to successfully run and use this application.

**Paste your system's server name on the Connection String**
- Open the *ATM_DAL* project
- Open the *AtmDbContextFactory.cs* class
- Edit the connection string and paste your system server name in the *Data Source* value of the *ConnectionString* variable.
```C#
string connectionString = @"Data Source=(Your Server Name);Initial Catalog=EFCoreAtmAppDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

```
- Save

4. **Run the program**

---
## Packages Installed 👓

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

---
## Software Development Summary 👓

- Technology: C# and EF CORE
- Console App Framework: .NET6
- Project Type: Class Library
- Class Library Framework: .Net standard 6.0
- IDE: Visual Studio (Version 2022)
- Paradigm or pattern of programming: Object-Oriented Programming (OOP)

NOTE: We appreciated the use of EF CORE to interact with the relational database.
This repo is subject to future modifications.

