# RateLimiterMiddleware Class Library
Welcome to the **RateLimiterMiddleware** Class Library repository. This library provides an easy-to-use middleware for ASP.NET Core applications to limit the rate of requests based on IP addresses. It's designed to help prevent abuse of APIs by setting a cap on the number of requests that can be made from a single IP address in a given time frame.

## Features
- Easy integration with ASP.NET Core applications.
- IP-based request rate limiting.
- Customizable rate limiting rules.
- Suitable for both development and production environments.
## Getting Started
### Prerequisites
- .NET Core 3.1 or higher.
- Basic understanding of ASP.NET Core.
### Installation
To use the RateLimiterMiddleware in your project, follow these steps:

1. Clone the Repository
First, clone this repository to your local machine:

`git clone https://github.com/[your-username]/RateLimiterMiddleware.git`

3. Build the Library
Navigate to the cloned repository and build the project:

`cd RateLimiterMiddleware
dotnet build`

> This will generate a DLL file which can be found in the bin directory.

3. Integrate the Middleware
To integrate the RateLimiterMiddleware into your ASP.NET Core application, reference the built DLL in your application:

Copy the DLL file to your ASP.NET Core application's directory.

Add a reference to the DLL in your project file:

`<ItemGroup>
  <Reference Include="Path\To\RateLimiterMiddleware.dll" />
</ItemGroup>`
    
In the Startup.cs of your application, add the middleware to the request pipeline:

`public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // Other middleware
    app.UseMiddleware<RateLimiterMiddleware>();

    // Remaining configuration
}`

### Usage
Configure the middleware according to your rate limiting needs. For example, you can set up rules to allow a certain number of requests per minute per IP address.

### Publishing as a NuGet Package (Optional)
To make the middleware easily reusable, you can publish it as a NuGet package:

Create a NuGet account if you don't have one.

Generate a .nupkg file from your project:

`dotnet pack`

Publish the package to NuGet:

`dotnet nuget push -s https://api.nuget.org/v3/index.json -k [your-api-key] RateLimiterMiddleware.1.0.0.nupkg`

> Once published, the package can be added to any ASP.NET Core project via NuGet Package Manager.

### Contributing
Contributions to the RateLimiterMiddleware project are welcome. Please feel free to fork this repository, make changes, and submit pull requests.

### License
This project is licensed under the MIT License
