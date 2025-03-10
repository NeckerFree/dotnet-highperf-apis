<a name="readme-top"></a>

<!--
!!! IMPORTANT !!!
This README is an example of how you could professionally present your codebase. 
Writing documentation is a crucial part of your work as a professional software developer and cannot be ignored. 

You should modify this file to match your project and remove sections that don't apply.

REQUIRED SECTIONS:
- Table of Contents
- About the Project
  - Built With
  - Live Demo
- Getting Started
- Authors
- Future Features
- Contributing
- Show your support
- Acknowledgements
- License

OPTIONAL SECTIONS:
- FAQ

After you're finished please remove all the comments and instructions!

For more information on the importance of a professional README for your repositories: https://github.com/microverseinc/curriculum-transversal-skills/blob/main/documentation/articles/readme_best_practices.md
-->

<div align="center">
  <!-- You are encouraged to replace this logo with your own! Otherwise you can also remove it. -->
  <img src="murple_logo.png" alt="logo" width="140"  height="auto" />
  <br/>

  <h3><b>Microverse README Template</b></h3>

</div>

<!-- TABLE OF CONTENTS -->

# 📗 Table of Contents

- [📖 About the Project](#about-project)
  - [🛠 Built With](#built-with)
    - [Tech Stack](#tech-stack)
    - [Key Features](#key-features)
  - [🚀 Live Demo](#live-demo)
- [💻 Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Setup](#setup)
  - [Install](#install)
  - [Usage](#usage)
  - [Run tests](#run-tests)
  - [Deployment](#deployment)
- [👥 Authors](#authors)
- [🔭 Future Features](#future-features)
- [🤝 Contributing](#contributing)
- [⭐️ Show your support](#support)
- [🙏 Acknowledgements](#acknowledgements)
- [❓ FAQ (OPTIONAL)](#faq)
- [📝 License](#license)

<!-- PROJECT DESCRIPTION -->

# 📖 [dotnet-highperf-apis] <a name="about-project"></a>

**[dotnet-highperf-apis]** is a project that demonstrates best practices about how to build high-performance APIs using .NET Core.
E-Commerce Application with .NET and AI Tools
This project demonstrates how to create a high-performance e-commerce application from scratch using .NET and leverage AI tools like GitHub Copilot and IntelliCode to accelerate development. The application includes a frontend (Razor Pages or MVC) and a backend (RESTful APIs) with a focus on scalability, performance, and maintainability.
## 🛠 Built With <a name="built-with"></a>

### Tech Stack <a name="tech-stack"></a>

> Describe the tech stack and include only the relevant sections that apply to your project.

<details>
  <summary>Client</summary>
  <ul>
    <li><a href="https://reactjs.org/">React.js</a></li>
  </ul>
</details>

<details>
  <summary>Server</summary>
  <ul>
    <li><a href="https://expressjs.com/">Express.js</a></li>
  </ul>
</details>

<details>
<summary>Database</summary>
  <ul>
    <li><a href="https://www.postgresql.org/">PostgreSQL</a></li>
  </ul>
</details>

<!-- Features -->

### Key Features <a name="key-features"></a>

Designing high-performance RESTful APIs in .NET Core requires careful consideration of various factors, including architecture, coding practices, and infrastructure. Below are some **best practices** to help you build efficient, scalable, and maintainable APIs:

Frontend: React TS for a responsive user interface.

Backend: RESTful APIs built with ASP.NET Core for high performance and scalability.

AI Tools: Leverage GitHub Copilot and IntelliCode for code generation, unit testing, and debugging.

High-Performance Practices: Asynchronous programming, caching, database optimization, and more.

### 1. **Use AI Tools to create the app from scratch
Creating an e-commerce application from scratch using .NET and leveraging integrated AI tools in Visual Studio (like GitHub Copilot and IntelliCode) can significantly accelerate development. Below is a step-by-step guide to help you take full advantage of these tools:

---

#### **Step 1: Set Up Your Development Environment**
1. **Install Visual Studio**:
   - Download and install the latest version of Visual Studio with the .NET workload.
   - Ensure you have the necessary components for web development (e.g., ASP.NET Core).

2. **Enable AI Tools**:
   - Install and enable **GitHub Copilot** and **IntelliCode** from the Visual Studio Marketplace.
   - Configure Copilot with your GitHub account and IntelliCode with your preferences.

3. **Create a New Project**:
   - Open Visual Studio and create a new ASP.NET Core Web Application.
   - Choose the **Model-View-Controller (MVC)** or **Razor Pages** template, depending on your preference.

---

#### **Step 2: Design the Application Architecture**
1. **Define the Core Components**:
   - **Models**: Product, Order, Cart, User, etc.
   - **Controllers**: ProductController, OrderController, CartController, etc.
   - **Views**: Product list, product details, cart view, checkout page, etc.
   - **Services**: ProductService, OrderService, PaymentService, etc.

2. **Use AI Tools to Generate Boilerplate Code**:
   - Use Copilot to generate initial classes for models, controllers, and services.
   - For example, type:
     ```csharp
     // Generate a Product model with properties like Id, Name, Price, and Description
     ```
     Copilot will suggest a complete class definition.

---

#### **Step 3: Implement the Product Catalog**
1. **Create the Product Model**:
   - Use Copilot to generate the `Product` class:
     ```csharp
     public class Product
     {
         public int Id { get; set; }
         public string Name { get; set; }
         public decimal Price { get; set; }
         public string Description { get; set; }
         public string ImageUrl { get; set; }
     }
     ```

2. **Scaffold the Product Controller**:
   - Use Visual Studio's scaffolding tools to generate a controller for the `Product` model.
   - Enhance the generated code with Copilot by asking it to add methods for filtering, sorting, and pagination.

3. **Create Views for Product Listing**:
   - Use Copilot to generate Razor views for displaying products.
   - For example, type:
     ```html
     <!-- Generate a Razor view to display a list of products -->
     ```
     Copilot will suggest a complete view with a table or grid layout.

---

#### **Step 4: Implement the Shopping Cart**
1. **Create the Cart Model**:
   - Use Copilot to generate the `Cart` and `CartItem` classes:
     ```csharp
     public class Cart
     {
         public List<CartItem> Items { get; set; } = new List<CartItem>();
         public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);
     }

     public class CartItem
     {
         public int ProductId { get; set; }
         public string ProductName { get; set; }
         public decimal Price { get; set; }
         public int Quantity { get; set; }
     }
     ```

2. **Add Cart Functionality**:
   - Use Copilot to generate methods for adding, removing, and updating items in the cart.
   - For example, type:
     ```csharp
     // Generate a method to add a product to the cart
     ```
     Copilot will suggest the implementation.

3. **Create Cart Views**:
   - Use Copilot to generate Razor views for displaying the cart and handling user interactions.

---

#### **Step 5: Implement User Authentication**
1. **Scaffold Identity**:
   - Use Visual Studio's built-in Identity scaffolding to add user authentication.
   - Enhance the generated code with Copilot to customize the login, registration, and profile management pages.

2. **Secure Controllers and Actions**:
   - Use Copilot to add authorization attributes to controllers and actions:
     ```csharp
     [Authorize(Roles = "Admin")]
     public class AdminController : Controller
     {
         // Admin-only actions
     }
     ```

---

#### **Step 6: Implement Order Processing**
1. **Create the Order Model**:
   - Use Copilot to generate the `Order` and `OrderItem` classes:
     ```csharp
     public class Order
     {
         public int Id { get; set; }
         public string UserId { get; set; }
         public DateTime OrderDate { get; set; }
         public decimal TotalPrice { get; set; }
         public List<OrderItem> Items { get; set; } = new List<OrderItem>();
     }

     public class OrderItem
     {
         public int ProductId { get; set; }
         public string ProductName { get; set; }
         public decimal Price { get; set; }
         public int Quantity { get; set; }
     }
     ```

2. **Implement Checkout Functionality**:
   - Use Copilot to generate the checkout process, including payment integration (e.g., Stripe or PayPal).

---

#### **Step 7: Use IntelliCode for Code Quality**
1. **Leverage IntelliCode Suggestions**:
   - As you write code, IntelliCode will provide context-aware suggestions for methods, properties, and parameters.
   - Use its recommendations to improve code quality and adhere to best practices.

2. **Refactor Code**:
   - Use IntelliCode's refactoring tools to simplify and optimize your code.

---

#### **Step 8: Automate Testing with AI**
1. **Generate Unit Tests**:
   - Use Copilot to generate unit tests for your controllers, services, and models.
   - For example, type:
     ```csharp
     // Generate unit tests for the ProductService class
     ```
     Copilot will suggest test cases.

2. **Run and Validate Tests**:
   - Use Visual Studio's Test Explorer to run the generated tests and ensure they pass.

---

#### **Step 9: Deploy the Application**
1. **Set Up CI/CD**:
   - Use GitHub Actions or Azure DevOps to automate the build and deployment process.
   - Use Copilot to generate the pipeline configuration file.

2. **Deploy to Azure**:
   - Use Visual Studio's built-in tools to deploy the application to Azure App Service.

---

#### **Step 10: Document and Share**
1. **Document the Process**:
   - Use Copilot to generate documentation for your application, including setup instructions and usage guidelines.

2. **Share Your Work**:
   - Push your code to GitHub and share it with the community.
   - Write a blog post or create a video tutorial to showcase how you leveraged AI tools to build the application.

---

#### **Example: Using Copilot to Generate a Product Service**
```csharp
// Prompt: Generate a ProductService class with methods to get all products, get a product by ID, and add a new product
public class ProductService
{
    private readonly List<Product> _products = new();

    public IEnumerable<Product> GetAllProducts() => _products;

    public Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

    public void AddProduct(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
    }
}
```

---

### 2. **Use Asynchronous Programming**
   - **Why**: Asynchronous programming allows your API to handle more requests by freeing up threads while waiting for I/O-bound operations (e.g., database queries, file I/O, or external API calls).
   - **How**: Use `async` and `await` for all I/O-bound operations.
   - **Example**:
     ```csharp
     public async Task<IActionResult> GetItemAsync(int id)
     {
         var item = await _repository.GetItemByIdAsync(id);
         if (item == null)
         {
             return NotFound();
         }
         return Ok(item);
     }
     ```

---

### 3. **Optimize Database Access**
   - **Use Efficient Queries**: Write optimized SQL queries or use an ORM like Entity Framework Core efficiently (e.g., avoid `SELECT *`).
   - **Use Indexing**: Ensure proper indexing on frequently queried columns.
   - **Pagination**: Implement pagination for large datasets to reduce response size and improve performance.
     ```csharp
     public async Task<IActionResult> GetItemsAsync(int page = 1, int pageSize = 10)
     {
         var items = await _repository.GetItemsAsync(page, pageSize);
         return Ok(items);
     }
     ```

---

### 4. **Use Caching**
   - **Why**: Caching reduces the load on your server and database by serving frequently requested data from memory.
   - **How**:
     - Use in-memory caching (`IMemoryCache`) for small, frequently accessed data.
     - Use distributed caching (e.g., Redis) for scalable applications.
   - **Example**:
     ```csharp
     public async Task<IActionResult> GetItemAsync(int id)
     {
         if (_memoryCache.TryGetValue($"Item_{id}", out var item))
         {
             return Ok(item);
         }

         item = await _repository.GetItemByIdAsync(id);
         if (item == null)
         {
             return NotFound();
         }

         _memoryCache.Set($"Item_{id}", item, TimeSpan.FromMinutes(5));
         return Ok(item);
     }
     ```

---

### 5. **Minimize Payload Size**
   - **Why**: Smaller payloads reduce network latency and improve response times.
   - **How**:
     - Use compression (e.g., Gzip or Brotli) for responses.
     - Return only the necessary fields (e.g., use DTOs or projection).
   - **Example**:
     ```csharp
     public async Task<IActionResult> GetItemSummaryAsync(int id)
     {
         var item = await _repository.GetItemSummaryByIdAsync(id);
         if (item == null)
         {
             return NotFound();
         }
         return Ok(item);
     }
     ```

---

### 6. **Use Proper HTTP Methods and Status Codes**
   - **Why**: Proper use of HTTP methods and status codes improves API usability and clarity.
   - **How**:
     - Use `GET` for retrieving data, `POST` for creating resources, `PUT`/`PATCH` for updates, and `DELETE` for deletions.
     - Return appropriate HTTP status codes (e.g., `200 OK`, `201 Created`, `400 Bad Request`, `404 Not Found`, `500 Internal Server Error`).

---

### 7. **Implement Rate Limiting**
   - **Why**: Rate limiting prevents abuse and ensures fair usage of your API.
   - **How**: Use middleware like `AspNetCoreRateLimit` to enforce rate limits.
   - **Example**:
     ```csharp
     services.AddMemoryCache();
     services.Configure<IpRateLimitOptions>(Configuration.GetSection("IpRateLimiting"));
     services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
     services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
     services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
     ```

---

### 8. **Enable Compression**
   - **Why**: Compressing responses reduces bandwidth usage and improves performance.
   - **How**: Use middleware to enable response compression.
   - **Example**:
     ```csharp
     services.AddResponseCompression(options =>
     {
         options.EnableForHttps = true;
     });

     app.UseResponseCompression();
     ```

---

### 9. **Use Dependency Injection**
   - **Why**: Dependency Injection (DI) promotes loose coupling and makes your code more testable and maintainable.
   - **How**: Register services in the DI container and inject them into controllers or other services.
   - **Example**:
     ```csharp
     services.AddScoped<IItemRepository, ItemRepository>();
     ```

---

### 10. **Monitor and Log**
   - **Why**: Monitoring and logging help you identify performance bottlenecks and errors.
   - **How**:
     - Use logging frameworks like Serilog or NLog.
     - Use Application Performance Monitoring (APM) tools like Application Insights or Prometheus.
   - **Example**:
     ```csharp
     public async Task<IActionResult> GetItemAsync(int id)
     {
         _logger.LogInformation("Fetching item with ID {Id}", id);
         var item = await _repository.GetItemByIdAsync(id);
         if (item == null)
         {
             _logger.LogWarning("Item with ID {Id} not found", id);
             return NotFound();
         }
         return Ok(item);
     }
     ```

---

### 11. **Use API Versioning**
   - **Why**: Versioning ensures backward compatibility and allows you to evolve your API without breaking existing clients.
   - **How**: Use libraries like `Microsoft.AspNetCore.Mvc.Versioning`.
   - **Example**:
     ```csharp
     services.AddApiVersioning(options =>
     {
         options.DefaultApiVersion = new ApiVersion(1, 0);
         options.AssumeDefaultVersionWhenUnspecified = true;
         options.ReportApiVersions = true;
     });
     ```

---

### 12. **Secure Your API**
   - **Why**: Security is critical to protect sensitive data and prevent unauthorized access.
   - **How**:
     - Use HTTPS to encrypt data in transit.
     - Implement authentication (e.g., JWT, OAuth2) and authorization.
     - Validate and sanitize all inputs to prevent injection attacks.
   - **Example**:
     ```csharp
     services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = Configuration["Jwt:Issuer"],
                     ValidAudience = Configuration["Jwt:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                 };
             });
     ```

---

### 13. **Load Testing and Profiling**
   - **Why**: Load testing helps identify performance bottlenecks under heavy traffic.
   - **How**:
     - Use tools like Apache JMeter, k6, or Visual Studio Load Test.
     - Profile your application using tools like dotTrace or Visual Studio Diagnostic Tools.

---

### 14. **Use Content Delivery Networks (CDNs)**
   - **Why**: CDNs cache static assets closer to users, reducing latency and server load.
   - **How**: Serve static files (e.g., images, CSS, JS) through a CDN.

---

### 15. **Optimize Startup and Middleware**
   - **Why**: Reducing startup time and middleware overhead improves performance.
   - **How**:
     - Minimize the number of middleware components.
     - Use `AddControllers` instead of `AddMvc` if you don't need Razor Pages or Views.
     - **Example**:
       ```csharp
       services.AddControllers();
       ```

---

### 16. **Use Health Checks**
   - **Why**: Health checks help monitor the status of your API and dependencies.
   - **How**: Use the built-in health checks middleware.
   - **Example**:
     ```csharp
     services.AddHealthChecks()
             .AddDbContextCheck<AppDbContext>();

     app.UseHealthChecks("/health");
     ```

---

### Summary
By following these best practices, you can design high-performance RESTful APIs in .NET Core that are scalable, secure, and maintainable. Focus on asynchronous programming, efficient database access, caching, and monitoring to ensure optimal performance.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LIVE DEMO -->

## 🚀 Live Demo <a name="live-demo"></a>

> Add a link to your deployed project.

- [Live Demo Link](https://google.com)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->

## 💻 Getting Started <a name="getting-started"></a>

Prerequisites

[.NET SDK](https://dotnet.microsoft.com/download)

[Visual Studio](https://visualstudio.microsoft.com/) with ASP.NET Core workload.

[GitHub Copilot](https://copilot.github.com/) and [IntelliCode](https://visualstudio.microsoft.com/services/intellicode/) installed and configured.

### Prerequisites

In order to run this project you need:

<!--
Example command:

```sh
 gem install rails
```
 -->

### Setup
Enable AI Tools:

Install and enable GitHub Copilot and IntelliCode from the Visual Studio Marketplace.

Configure Copilot with your GitHub account and IntelliCode with your preferences.
Clone this repository to your desired folder:

<!--
Example commands:

```sh
  cd my-folder
  git clone git@github.com:myaccount/my-project.git
```
--->

### Install

Install this project with:

<!--
Example command:

```sh
  cd my-project
  gem install
```
--->

### Usage

To run the project, execute the following command:

<!--
Example command:

```sh
  rails server
```
--->

### Run tests

To run tests, run the following command:

<!--
Example command:

```sh
  bin/rails test test/models/article_test.rb
```
--->

### Deployment

You can deploy this project using:

<!--
Example:

```sh

```
 -->

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- AUTHORS -->

## 👥 Authors <a name="authors"></a>

> Mention all of the collaborators of this project.

👤 **Author1**

- GitHub: [@githubhandle](https://github.com/githubhandle)
- Twitter: [@twitterhandle](https://twitter.com/twitterhandle)
- LinkedIn: [LinkedIn](https://linkedin.com/in/linkedinhandle)

👤 **Author2**

- GitHub: [@githubhandle](https://github.com/githubhandle)
- Twitter: [@twitterhandle](https://twitter.com/twitterhandle)
- LinkedIn: [LinkedIn](https://linkedin.com/in/linkedinhandle)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- FUTURE FEATURES -->

## 🔭 Future Features <a name="future-features"></a>

> Describe 1 - 3 features you will add to the project.

- [ ] **[new_feature_1]**
- [ ] **[new_feature_2]**
- [ ] **[new_feature_3]**

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- CONTRIBUTING -->

## 🤝 Contributing <a name="contributing"></a>

Contributions, issues, and feature requests are welcome!

Feel free to check the [issues page](../../issues/).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- SUPPORT -->

## ⭐️ Show your support <a name="support"></a>

> Write a message to encourage readers to support your project

If you like this project...

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGEMENTS -->

## 🙏 Acknowledgments <a name="acknowledgements"></a>

> Give credit to everyone who inspired your codebase.

I would like to thank...

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- FAQ (optional) -->

## ❓ FAQ (OPTIONAL) <a name="faq"></a>

> Add at least 2 questions new developers would ask when they decide to use your project.

- **[Question_1]**

  - [Answer_1]

- **[Question_2]**

  - [Answer_2]

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->

## 📝 License <a name="license"></a>

This project is [MIT](./LICENSE) licensed.

_NOTE: we recommend using the [MIT license](https://choosealicense.com/licenses/mit/) - you can set it up quickly by [using templates available on GitHub](https://docs.github.com/en/communities/setting-up-your-project-for-healthy-contributions/adding-a-license-to-a-repository). You can also use [any other license](https://choosealicense.com/licenses/) if you wish._

<p align="right">(<a href="#readme-top">back to top</a>)</p>
