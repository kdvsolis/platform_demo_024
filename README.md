# PlatformDemo

## Overview

PlatformDemo is a .NET 8 application that showcases service plans and associated timesheets using Entity Framework Core with PostgreSQL. This project demonstrates how to set up a basic CRUD application with Razor Pages.

## Features

- Display a list of service plans with their purchase dates and associated timesheets.
- Seed sample data for testing.
- Utilizes PostgreSQL for data storage.

## Technologies Used

- .NET 8
- ASP.NET Core 8
- Entity Framework Core
- PostgreSQL

## Setup Instructions

### Prerequisites

- .NET 8 SDK
- PostgreSQL

### Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd PlatformDemo
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Update the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=your_database;Username=your_username;Password=your_password"
   }
   ```

4. Create the database and apply migrations:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. Seed the database:
   The database will be seeded with sample data automatically when the application starts.

### Running the Application

To run the application, use the following command:

```bash
dotnet run
```

Navigate to `http://localhost:7068/ServicePlans` in your web browser to view the list of service plans.

## Contribution

If you want to contribute to this project, feel free to fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.