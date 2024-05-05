# PetStore

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

PetStore is a console .NET application designed for users to view a list of available pets in various categories, sorted in reverse order by name.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Further steps](#further-steps)
  - [Improve the Project Layout](#improve-the-project-layout)
  - [Application Performance](#application-performance)
  - [Secure Code Implementation](#secure-code-implementation)
  - [Continuous Integration/Continuous Deployment](#continuous-integration-continuous-deployment)
  - [Scalability](#scalability)
- [Contact](#contact)

## Features
- View available pets by status (Available).
## Getting Started
Follow these steps to get started with the project.

### Prerequisites
Ensure you have the following installed in your development environment:
- [.NET 8.0](https://dotnet.microsoft.com/download)
- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/vs/)

### Installation
1. Clone this repository to your local machine:
   ```bash
   https://github.com/hmuudeni/PetStore.git
2. Open the project in Visual Studio or your preferred IDE.
3. Restore dependencies using the .NET CLI:
   ```bash
   dotnet restore
   dotnet build
   dotnet run

## Further Steps

#### Improve the Project Layout

Use the clean architecture approach to manage business logic, the data access layer, and the services layer. 
Implement class libraries for these sections.
     
#### Application Performance

Example: PetService – GetAvailablePetsAsync

1. Consider HTTP response caching (to be implemented).
2. Optimize JSON deserialization, especially when the payload is large. Here is an example code snippet form Chat GPT:
   
    ```bash
    // Asynchronously read the content as a stream and deserialize
    using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
    {
      return await System.Text.Json.JsonSerializer.DeserializeAsync<List<Pet>>(stream)
                                                 .ConfigureAwait(false);
    }   
  
5. Use asynchronous stream reading (to be implemented).
6. Implement pagination if the API supports it.
7. Implemented Solutions for Performance
     - Reuse HttpClient for efficient HTTP calls.
     - Use asynchronous methods and operations.
     - Implement error handling.
       
#### Secure Code Implementation

1. Validate input to ensure, for example, that findByStatus is a valid input (to be implemented).
2. Handle exceptions (already implemented).
3. Implement logging with Azure App Insights (to be implemented).
4. Store sensitive URLs in Azure Key Vault, not in the codebase (to be implemented).
5. Consider a Logging Framework: Instead of printing errors to the console

#### Continuous Integration/Continuous Deployment
1. Implement CI/CD to build and deploy the source code using Azure DevOps.

#### Scalability

1. Deploy using Docker.
2. Store Docker images in Docker Hub or Azure Container Registry.
3. Consider Azure Kubernetes Service (AKS) for scalability.
4. For load balancing, can use Azure API Gateway.
5. To make console applications cloud-native, consider a microservices architecture for independent scaling.
6. Implement caching for improved scalability.

#### Contact
email : hmumanjula@gmail.com

