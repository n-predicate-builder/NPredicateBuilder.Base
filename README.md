# NPredicateBuilder

Simple, testable, LINQ queries.

![TempIcon](images/tempIcon.jpg)

![build-status](https://github.com/mjbradvica/NPredicateBuilder/workflows/main/badge.svg) ![downloads](https://img.shields.io/nuget/dt/NPredicateBuilder) ![downloads](https://img.shields.io/nuget/v/NPredicateBuilder) ![activity](https://img.shields.io/github/last-commit/mjbradvica/NPredicateBuilder/master)

## Overview

NPredicateBuilder is a way to build LINQ queries and orders with the following:

- :microscope: Small API (2 methods and 2 base classes)
- :straight_ruler: Learn in 5 minutes
- :key: Easily integrate into LINQ
- :heavy_check_mark: Write testable queries in seconds
- :recycle: Reuse your queries and orders

## Table of Contents

- [NPredicateBuilder](#npredicatebuilder)
  - [Overview](#overview)
  - [Table of Contents](#table-of-contents)
  - [Dependencies](#dependencies)
  - [Installation](#installation)
  - [Quick Start](#quick-start)
  - [Testing](#testing)
  - [Documentation](#documentation)
  - [FAQ](#faq)
    - [What is NPredicateBuilder?](#what-is-npredicatebuilder)
    - [Do I need NPredicateBuilder?](#do-i-need-npredicatebuilder)
    - [Whats the difference between the base library and the EF version?](#whats-the-difference-between-the-base-library-and-the-ef-version)
    - [How is performance?](#how-is-performance)
    - [How does NPredicateBuilder work with other LINQ statements?](#how-does-npredicatebuilder-work-with-other-linq-statements)

## Dependencies

- Base Library - None
- EF Library - NET480 - [LinqKit.EntityFramework](https://www.nuget.org/packages/LinqKit.EntityFramework)
- EF Library - NET3.1/5/6/7/8 - [LinqKit.Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/LinqKit.Microsoft.EntityFrameworkCore)

NPredicateBuilder uses LinqKit to expand queries into properly formed IQueryable.

## Installation

The best way is to [install with NuGet](https://www.nuget.org/packages/NPredicateBuilder/).

In your domain layer.

```bash
Install-Package NPredicateBuilder
```

If you are doing LINQ to Entities, install the following in your data access layer.

```bash
Install-Package NPredicateBuilder.EF
```

## Quick Start

```csharp
class PeopleQuery : BaseQuery<People>
{
    public PeopleQuery AndNameIs(string name)
    {
        AddAndCriteria(x => x.Name == name);

        return this;
    }

    public PeopleQuery OrAgeIsOver(int age)
    {
        AddOrCriteria(x => x.Age > age);

        return this;
    }
}
```

Then create a complex query by chaining them together.

```csharp
var peopleQuery = new PeopleQuery()
    .AndNameIs("brad")
    .OrAgeIsOver(10);
```

Pass your queries and orders to the designated extension method.

```csharp
var result = ApplicationContext.People
            .NPredicateBuilderEFWhere(peopleQuery);
```

Because it's just an extension method, it behaves like any other LINQ to Object or LINQ to Entities query.

```csharp
var result = ApplicationContext.People
            .NPredicateBuilderEFWhere(peopleQuery)
            .Skip(10)
            .Take(15)
            .Select(x => new { x.Name, x.Age })
            .ToList();
```

NPredicateBuilder can easily be added to any existing or new codebase, no matter what size!

> NPredicateBuilder can simplify Ordering in the same way it handles Queries.

## Testing

Unit tests are easy to write for queries.

```csharp
[TestMethod]
public void Where_Queryable_FiltersCorrectly()
{
    _customers = new List<Customer>
    {
        TestHelper.Billy(),
        TestHelper.Bobby(),
    };

    var query = new CustomerTestQuery().AndNameIsBobby();

    var result = _customers.AsQueryable().NPredicateBuilderEFWhere(query);

    Assert.AreEqual("Bobby", result.Single().Name);
}
```

## Documentation

Any and all documentation can be [viewed in the wiki](https://github.com/n-predicate-builder/NPredicateBuilder/wiki).

It's only a five minute read!

## FAQ

### What is NPredicateBuilder?

NPredicateBuilder is way to writing LINQ queries and orders that can be tested individually, and reused multiple times to cut down on duplication.

### Do I need NPredicateBuilder?

If your application is simple and has a minimum amount of simple queries-you may not need it.

NPredicateBuilder was created in mind when you find yourself writing the same query or order multiple times-or you have very complex queries that require testing.

### Whats the difference between the base library and the EF version?

If you are doing LINQ to Objects you only need the base library.

If you are using EntityFramework you need the EF library for NPredicateBuilder to work properly.

### How is performance?

Your experience may very depending on how complex your queries.

Generally NPredicateBuilder will be "a little" slower due to each query needing to be expanded. However, unless your performance requirements are extreme, the different is not noticeable.

### How does NPredicateBuilder work with other LINQ statements?

It works like any other LINQ statement because its an extension method for either the IEnumerable or IQueryable interfaces.
