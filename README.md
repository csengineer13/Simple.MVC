# About

A .NET MVC project with pre-installed nuget packages, project setup, and basic CRUD to reduce new project startup time.

## First Time...

- Clone Repo
- Open and build project in VS
	- Downloads project dependencies
- Update `Web.Config`'s connection string to point to a DB
- Run `database-update` in Package Manager Console (target MVC project)


## Project Structure

- Domain Project
- ViewModel Project
- MVC Project


## Installed:

- **AutoMapper** [Install](https://www.nuget.org/packages/AutoMapper/) | [Docs](https://github.com/AutoMapper/AutoMapper/wiki/Getting-started)
- **Bogus** [Install](https://www.nuget.org/packages/Bogus/) | [Docs](https://github.com/bchavez/Bogus)


### Swapping/Similar Tools

- **AutoMapper** is a very powerful tool that makes it easy to _map_ from one class to another. Common use cases are from forms to domain object, or from domain objects to view models.
	- [Dapper](https://github.com/StackExchange/dapper-dot-net) is a commonly used alternative.
- **Bogus** is a port of faker.js. It's used to seed your database with some tasy fake (but realistic looking) data. It's one of the newer ports, and has decent adoption. This is the first time I've used it over Faker.NET
	- [Faker.Net](https://www.nuget.org/packages/Faker.Net/) or [here](https://github.com/slashdotdash/faker-cs)


### What's Next?

This is for small/simple projects. If you wanted to abstract things out further, you may want to consider the following:

- Create additional projects:
	- Simple.Repository
	- Simple.Service
	- Simple.Identity
	- Simple.ExternalServices
- Implement Dependency Injection using [Unity](https://github.com/unitycontainer/unity/tree/master/quickstarts)
- Flush out Base/Common/[AggregateRoot](http://martinfowler.com/bliki/DDD_Aggregate.html) classes
- Move migrations to the new Repository project
- Implement [Command/Query Responsibility Segregation](http://martinfowler.com/bliki/CQRS.html) in the Service layer
- Implement [Unit of Work](http://www.codeproject.com/Articles/581487/Unit-of-Work-Design-Pattern) design pattern

We DO NOT do this in the current project because it adds a lot of boiler plate code that increases the time to dev. However, it big time increases maintainability, consistancy across projects, etc. To reduce development time, it may be worth looking into code scaffolding via:

- [SideWaffle](http://sidewaffle.com/)
- [MSDN Article](http://blogs.msdn.com/b/webdev/archive/2014/04/03/creating-a-custom-scaffolder-for-visual-studio.aspx)

