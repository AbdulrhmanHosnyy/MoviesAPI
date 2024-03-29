## Objective:
Manage movie information through a RESTful API.

## Components:
Controllers: Handle HTTP requests for movie-related operations. Data Models: Define the structure of the Movie entity. Services: Implement business logic for movie operations. DTOs: Define data transfer objects for data exchange. Helpers: Include a MappingProfile for AutoMapper configuration.

## Database Interaction:
Utilizes Entity Framework Core for database access. Follows a Code-First approach with migration support.

## Key Features:
CRUD operations for movies (Create, Read, Update, Delete). Supports file upload for movie posters. Utilizes AutoMapper for object mapping. Implements input validation (e.g., allowed file extensions, maximum poster size).

## Dependencies:
Requires the use of IMoviesService, MoviesService, and AppDbContext. Leverages AutoMapper for object mapping.

## Clean Project Structure:
Organized folders for properties, controllers, data, DTOs, helpers, migration, models, and services.

Usage:
Retrieve, add, update, or delete movies through the API.

Best Practices:
Utilizes dependency injection, follows RESTful principles, and maintains a modular project structure.
