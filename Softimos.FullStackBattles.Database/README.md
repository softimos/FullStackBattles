<a name='assembly'></a>
# Softimos.FullStackBattles.Database

## Contents

- [CustomDatabaseContext](#T-Softimos-FullStackBattles-Database-CustomDatabaseContext 'Softimos.FullStackBattles.Database.CustomDatabaseContext')
  - [#ctor(options)](#M-Softimos-FullStackBattles-Database-CustomDatabaseContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions- 'Softimos.FullStackBattles.Database.CustomDatabaseContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions)')
  - [People](#P-Softimos-FullStackBattles-Database-CustomDatabaseContext-People 'Softimos.FullStackBattles.Database.CustomDatabaseContext.People')
  - [Starships](#P-Softimos-FullStackBattles-Database-CustomDatabaseContext-Starships 'Softimos.FullStackBattles.Database.CustomDatabaseContext.Starships')
  - [PrepareDatabase()](#M-Softimos-FullStackBattles-Database-CustomDatabaseContext-PrepareDatabase 'Softimos.FullStackBattles.Database.CustomDatabaseContext.PrepareDatabase')
  - [SeedSampleData()](#M-Softimos-FullStackBattles-Database-CustomDatabaseContext-SeedSampleData 'Softimos.FullStackBattles.Database.CustomDatabaseContext.SeedSampleData')
  - [SeedTable\`\`1(fileName,dbSet)](#M-Softimos-FullStackBattles-Database-CustomDatabaseContext-SeedTable``1-System-String,Microsoft-EntityFrameworkCore-DbSet{``0}- 'Softimos.FullStackBattles.Database.CustomDatabaseContext.SeedTable``1(System.String,Microsoft.EntityFrameworkCore.DbSet{``0})')

<a name='T-Softimos-FullStackBattles-Database-CustomDatabaseContext'></a>
## CustomDatabaseContext `type`

##### Namespace

Softimos.FullStackBattles.Database

##### Summary

EF Core context class for the database used in the solution.

##### See Also

- [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext')

<a name='M-Softimos-FullStackBattles-Database-CustomDatabaseContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [CustomDatabaseContext](#T-Softimos-FullStackBattles-Database-CustomDatabaseContext 'Softimos.FullStackBattles.Database.CustomDatabaseContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions](#T-Microsoft-EntityFrameworkCore-DbContextOptions 'Microsoft.EntityFrameworkCore.DbContextOptions') | The options for this context. |

<a name='P-Softimos-FullStackBattles-Database-CustomDatabaseContext-People'></a>
### People `property`

##### Summary

Gets or sets the People entity.

<a name='P-Softimos-FullStackBattles-Database-CustomDatabaseContext-Starships'></a>
### Starships `property`

##### Summary

Gets or sets the Starships entity.

<a name='M-Softimos-FullStackBattles-Database-CustomDatabaseContext-PrepareDatabase'></a>
### PrepareDatabase() `method`

##### Summary

Creates the database if it does not exist and fills it with sample data.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-Database-CustomDatabaseContext-SeedSampleData'></a>
### SeedSampleData() `method`

##### Summary

Seeds the sample data from JSON files into the database.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-Database-CustomDatabaseContext-SeedTable``1-System-String,Microsoft-EntityFrameworkCore-DbSet{``0}-'></a>
### SeedTable\`\`1(fileName,dbSet) `method`

##### Summary

Fills the selected entity table with data from selected JSON file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the JSON file. |
| dbSet | [Microsoft.EntityFrameworkCore.DbSet{\`\`0}](#T-Microsoft-EntityFrameworkCore-DbSet{``0} 'Microsoft.EntityFrameworkCore.DbSet{``0}') | The database set. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Entity type |
