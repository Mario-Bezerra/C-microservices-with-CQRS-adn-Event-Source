# Social Media Project

Overview
This is a C# project built using the .NET framework, following the principles of Domain-Driven Design (DDD), Event Sourcing, and Command Query Responsibility Segregation (CQRS). The project aims to provide a robust and scalable solution for a social media.

## Architecture

The project is divided into three layers:
### Domain Layer: 
Represents the domain model of the system. It is responsible for representing business concepts and their business rules.
### Event Layer: 
Captures the events that occur in the domain. These events are stored in an event repository.
### Query Layer: 
Provides access to domain data. It is responsible for answering queries made by users.

## DDD
DDD is an approach to software development that emphasizes the modeling of the business domain. The domain is the set of concepts and rules that are relevant to the business.

In this project, the domain is modeled using the following concepts:

Entities: Represent domain objects that have a state and behavior.
Commands: Represent actions that can be performed on the domain.
Conventions: Are rules that define how the domain should be used.

## Event Sourcing
Event Sourcing is an architectural pattern that stores events that occur in the system. These events are stored in an event repository.

In this project, the event repository is used to store domain events. These events are used to reconstruct the domain state in case of failure or recovery.

## CQRS
CQRS is an architectural pattern that separates query operations from state-changing operations. Query operations are used to answer queries made by users. State-changing operations are used to change the state of the domain.
In this project, CQRS is used to separate query operations from state-changing operations. Query operations are performed by the query layer. State-changing operations are performed by the domain layer.

## How to use
To use this project, you will need a development environment with *.NET 8* and *docker* installed.
To build the project, run the following command in the terminal:

```bash
docker-compose up -d
dotnet build
```
To run the project, run the following command in the terminal:

```bash
dotnet run
```

## License

[MIT](https://choosealicense.com/licenses/mit/)
