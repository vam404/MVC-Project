# MVCApp

## Overview
This is a .NET 8 application with an ASP.NET Core backend and an Angular frontend. It demonstrates CRUD-like functionality for products using EscuelaJs API as a data source.

## Requirements
- .NET 8 SDK
- Node.js [v22.16.0] and npm
- Angular CLI (global install recommended)

## Getting Started

### Backend
1. Open a terminal in the `Backend` folder.
2. Run: `dotnet restore dotnet build dotnet run`
3. The API should be accessible at [http://localhost:5141](http://localhost:5141).

### Frontend
1. Open a separate terminal in the `Frontend` folder.
2. Run: `npm install npm start`
3. The frontend should be accessible at [http://localhost:4200](http://localhost:4200).

## Testing
- In the `Backend` folder, run: `dotnet test`
- This runs the MSTest-based tests found in [MVCTests](Backend/MVCTests).
