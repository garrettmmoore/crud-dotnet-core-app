# Simple ASP.NET Core CRUD Application

## Application Details

### Server

- API built with ASP.Net Core
- Utilizes Entity Framework Core to define Database Model
- Equipped with controller for CRUD operations
- Connects to local Microsoft SQL Server for database management

### Client

- Signup form built with React
- Utilizes Redux for state management
- Consumes .Net Core Web API
- Utilizes Material-UI for component design system
- Includes form input validation
- Perform CRUD operations see changes reflected in the database

## How to run

### Prerequisites

The following tools need to be installed:

- .NET Core command-line interface
- Microsoft SQL Server
- Node.js

### Database

Install the `dotnet ef` command line tool.

```shell
dotnet tool install --global dotnet-ef
```

Initialize database migration.

```shell
dotnet ef migration
```

Update the database.

```shell
dotnet ef database update
```

### Server

From the root project directory, navigate to the `WebApi` folder.

```shell
dotnet restore
```

Restore project dependencies.

```shell
dotnet restore
```

Build the project.

```shell
dotnet build
```

Run the server.

```shell
dotnet run
```

### Client

From the root directory, navigate to the `client` folder.

```shell
cd client
```

Install dependencies.

```shell
npm i
```

Run the client on `localhost:3000`.

```shell
yarn start
```

or

```shell
npm run start
```
