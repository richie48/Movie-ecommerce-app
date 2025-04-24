# 🎬 Movie E-Commerce App
A fullstack web application built with C# and ASP.NET Core MVC, designed to provide users with a seamless experience in browsing, purchasing, and managing movie-related products. This project integrates essential e-commerce functionalities with a focus on movies, offering a platform for users to explore and buy their favorite films.   

### 🛠️ Tech Stack
Backend: C#, ASP.NET Core MVC   

Frontend: Razor Views, HTML, CSS, JavaScript   

Database: Entity Framework Core with SQL Server   

Authentication: ASP.NET Identity   

Deployment: Azure Pipelines (CI/CD)   
   
### 🚀 Features
User Authentication: Secure registration and login using ASP.NET Identity.

Product Catalog: Browse a collection of movies with detailed information.

Shopping Cart: Add movies to a cart and manage quantities.

Order Management: Place orders and view order history.

Admin Panel: Manage movie listings, categories, and orders.

Responsive Design: Optimized for various devices and screen sizes.

### 🧪 Getting Started
Prerequisites   
.NET 6 SDK   
SQL Server   

# Installation
Clone the repository:   
```
git clone https://github.com/richie48/Movie-ecommerce-app.git   
cd Movie-ecommerce-app
```

Configure the database:   
Update the appsettings.json file with your SQL Server connection string.
Apply migrations and seed the database:
```
dotnet ef database update
```

Run the application:
```  
dotnet run
```

The application will be available at https://localhost:5001.

### 📦 Deployment
This project includes an azure-pipelines.yml file for setting up continuous integration and deployment using Azure Pipelines. Configure your Azure DevOps project and connect it to this repository to automate builds and deployments.
