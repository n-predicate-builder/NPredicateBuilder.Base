# NPredicateBuilder

![build-status](https://github.com/mjbradvica/NPredicateBuilder/workflows/main/badge.svg) ![downloads](https://img.shields.io/nuget/dt/NPredicateBuilder) ![downloads](https://img.shields.io/nuget/v/NPredicateBuilder) ![activity](https://img.shields.io/github/last-commit/mjbradvica/NPredicateBuilder/master)

Simple, testable, LINQ queries.

NPredicateBuilder allows you to build small and easily testable Where and Order clauses that you can chain together to create complex queries.

## Quick Overview

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

## Install NPredicateBuilder

The best way is to [install with NuGet](https://www.nuget.org/packages/NPredicateBuilder/).

In your domain layer.

```bash
Install-Package NPredicateBuilder
```

If you are doing LINQ to Entities, install the following in your data access layer.

```bash
Install-Package NPredicateBuilder.EF
```

## Documentation

Any and all documentation can be [viewed in the wiki](https://github.com/n-predicate-builder/NPredicateBuilder/wiki).

It's only a five minute read!
