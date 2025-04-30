
# Product API Project

## Description
This is a simple .NET Core Product API project. It exposes the following endpoints to manage product data:

- **GET /api/products**: Lists all products.
- **GET /api/products/{id}**: Retrieves a single product by ID.
- **POST /api/products**: Adds a new product.

The project uses a static in-memory list for storing product data. It also demonstrates dependency injection by implementing a service layer for product management.

Configuration settings like `AppName` and `DefaultCurrency` are read from the `appsettings.json` file.

## Technologies Used
- **Backend**: .NET Core (C#)
- **Frontend**: A simple web application consuming the Product API.
- **Testing**: Unit tests using MSTest or xUnit
- **CI/CD**: GitHub Actions for Continuous Integration and Deployment

## How to Run the Project

### 1. Clone the repository
```bash
git clone https://github.com/shadiaal/W10D4_Repo.git
cd ProductApi
```

### 2. Restore Dependencies
Run the following command to restore all dependencies:
```bash
dotnet restore
```

### 3. Build the Solution
Run the following command to build the solution:
```bash
dotnet build
```

### 4. Run the API
Start the API using the following command:
```bash
dotnet run
```
The API will be available at `http://localhost:5008`.

### 5. Testing the Endpoints

#### GET /api/products
This will return a list of all products.

#### GET /api/products/{id}
This will return a single product by ID.

#### POST /api/products
Use this endpoint to add a new product by sending a JSON body with product details:
```json
{
  "name": "Sample Product",
  "price": 99.99
}
```

## Frontend Application
A simple frontend application can be built using HTML, CSS, and JavaScript (or any preferred framework) to consume the Product API and display product data.

## Unit Tests
Unit tests are provided for the API endpoints to verify their functionality. Run the following command to execute the tests:
```bash
dotnet test
```

## CI/CD Pipeline
The project includes a GitHub Actions workflow for CI/CD. This pipeline performs the following tasks:
1. Builds the .NET Core ProductApi project.
2. Restores dependencies and builds the solution.
3. Runs unit tests.
4. Generates test reports in TRX format and stores them as artifacts.

The GitHub Actions configuration can be found in `.github/workflows/ci.yml`.


