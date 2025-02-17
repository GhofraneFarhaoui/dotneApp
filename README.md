# dotnetApp

A simple .NET 8.0 web application that handles jokes and home page requests. This app is built using ASP.NET Core MVC with Razor views for rendering HTML. It includes controllers for different functionalities, models for data handling, and views for displaying content.

## Project Structure

- **appsettings.json**: General configuration for the application.
- **appsettings.Development.json**: Configuration for the development environment.
- **dotnetApp.csproj**: Defines project settings, dependencies, and build configuration.
- **dotnetApp.sln**: Solution file for grouping multiple projects.

### Directories

- **bin/**: Contains compiled binaries and other output files.
  - **Debug/**: Debug build output.
  - **net8.0/**: Build output for .NET 8.0 framework.
- **Controllers/**: Contains controller classes responsible for HTTP requests.
  - **HomeController.cs**: Controller for the home page.
  - **JokesController.cs**: Controller for jokes-related requests.
- **Models/**: Contains classes that represent data structures.
  - **ErrorViewModel.cs**: Model for error page.
  - **Joke.cs**: Model for jokes data.
- **obj/**: Contains temporary object files and other build artifacts.
  - **Debug/**: Debug build artifacts.
  - **net8.0/**: .NET 8.0 framework build artifacts.
  - **dotnetApp.csproj.nuget.dgspec.json**: NuGet dependency graph specification.
  - **dotnetApp.csproj.nuget.g.props**: MSBuild properties for NuGet.
  - **dotnetApp.csproj.nuget.g.targets**: MSBuild targets for NuGet.
  - **project.assets.json**: Information about project dependencies.
  - **project.nuget.cache**: Cache file for NuGet packages.
- **Properties/**: Contains project properties and settings.
  - **launchSettings.json**: Launch configuration for the application.
- **Views/**: Contains Razor pages for rendering HTML.
  - **\_ViewImports.cshtml**: Common directives for Razor views.
  - **\_ViewStart.cshtml**: Code that runs at the start of each view.
  - **Shared/**: Contains shared views.
    - **Error.cshtml**: View for displaying error messages.
  - **Home/**: Contains views for the Home controller.
- **wwwroot/**: Contains static files like CSS, JavaScript, and images.
  - **css/**: CSS files for the website.
  - **favicon.ico**: Favicon for the website.
  - **js/**: JavaScript files.
  - **lib/**: Library files.

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- Visual Studio or your preferred code editor

### Installation

1. Clone this repository:

   ```bash
   git clone https://github.com/GhofraneFarhaoui/dotnetApp.git
   ```

   Navigate to the project directory:
   cd dotnetApp
   Restore the dependencies:
   dotnet restore
   Run the application:
   dotnet run
   The application should now be running on http://localhost:5000.
