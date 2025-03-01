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

---

### 1. **Use Asynchronous Programming**
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

### 2. **Optimize Database Access**
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

### 3. **Use Caching**
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

### 4. **Minimize Payload Size**
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

### 5. **Use Proper HTTP Methods and Status Codes**
   - **Why**: Proper use of HTTP methods and status codes improves API usability and clarity.
   - **How**:
     - Use `GET` for retrieving data, `POST` for creating resources, `PUT`/`PATCH` for updates, and `DELETE` for deletions.
     - Return appropriate HTTP status codes (e.g., `200 OK`, `201 Created`, `400 Bad Request`, `404 Not Found`, `500 Internal Server Error`).

---

### 6. **Implement Rate Limiting**
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

### 7. **Enable Compression**
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

### 8. **Use Dependency Injection**
   - **Why**: Dependency Injection (DI) promotes loose coupling and makes your code more testable and maintainable.
   - **How**: Register services in the DI container and inject them into controllers or other services.
   - **Example**:
     ```csharp
     services.AddScoped<IItemRepository, ItemRepository>();
     ```

---

### 9. **Monitor and Log**
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

### 10. **Use API Versioning**
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

### 11. **Secure Your API**
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

### 12. **Load Testing and Profiling**
   - **Why**: Load testing helps identify performance bottlenecks under heavy traffic.
   - **How**:
     - Use tools like Apache JMeter, k6, or Visual Studio Load Test.
     - Profile your application using tools like dotTrace or Visual Studio Diagnostic Tools.

---

### 13. **Use Content Delivery Networks (CDNs)**
   - **Why**: CDNs cache static assets closer to users, reducing latency and server load.
   - **How**: Serve static files (e.g., images, CSS, JS) through a CDN.

---

### 14. **Optimize Startup and Middleware**
   - **Why**: Reducing startup time and middleware overhead improves performance.
   - **How**:
     - Minimize the number of middleware components.
     - Use `AddControllers` instead of `AddMvc` if you don't need Razor Pages or Views.
     - **Example**:
       ```csharp
       services.AddControllers();
       ```

---

### 15. **Use Health Checks**
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

> Describe how a new developer could make use of your project.

To get a local copy up and running, follow these steps.

### Prerequisites

In order to run this project you need:

<!--
Example command:

```sh
 gem install rails
```
 -->

### Setup

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
