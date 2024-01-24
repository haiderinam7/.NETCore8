# .NETCore8LabProject1

This project is a .NET 8 lab that I created while following a Udemy course.

## Table of Contents

1. [Introduction](#introduction)
2. [Getting Started](#getting-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
3. [Project Structure](#project-structure)
4. [Configuration](#configuration)
5. [Database Setup](#database-setup)
6. [Usage](#usage)

## Introduction

This project is a .NET 8 lab created by following a Udemy course. It includes various commits covering topics like setting up configuration, creating models, implementing data context, and connecting to a SQL database using Dapper and Entity Framework Core.

## Getting Started

### Prerequisites

- .NET 8 SDK

### Installation

Clone the repository:

   ```bash
   git clone https://github.com/haiderinam7/DotNETCore8LabProject1.git
   ```

   ...

## Project Structure

- `appsettings.json`: Configuration file.
- `models/`: Folder containing the models used in the project.
- `data/`: Folder containing the data context file.

## Configuration

Customize your application settings in the `appsettings.json` file according to your needs.

## Database Setup

1. Install SQL Server package:

   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```

   ...

2. Connect to the SQL database:

   ```csharp
   "DefaultConnection": "Server=${DB_SERVER};Database=${DB_NAME};User Id=${DB_USER};Password=${DB_PASSWORD};"

   ```

   ...

## Usage

Explore the project to understand the implementation of Dapper, Entity Framework Core, and SQL Server integration.

Feel free to add more details or adjust the sections based on your specific project requirements.
