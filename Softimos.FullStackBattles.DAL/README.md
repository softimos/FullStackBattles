<a name='assembly'></a>
# Softimos.FullStackBattles.DAL

## Contents

- [Constants](#T-Softimos-FullStackBattles-DAL-Constants 'Softimos.FullStackBattles.DAL.Constants')
  - [ItemsPerPage](#F-Softimos-FullStackBattles-DAL-Constants-ItemsPerPage 'Softimos.FullStackBattles.DAL.Constants.ItemsPerPage')
- [IRepository\`1](#T-Softimos-FullStackBattles-DAL-Repositories-IRepository`1 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1')
  - [Count()](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Count 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.Count')
  - [Delete(entityToBeDeleted)](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Delete-`0- 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.Delete(`0)')
  - [GetAll()](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetAll 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.GetAll')
  - [GetById(id)](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetById-System-Int32- 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.GetById(System.Int32)')
  - [GetPage(pageNumber)](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetPage-System-Int32- 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.GetPage(System.Int32)')
  - [GetRandom()](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetRandom 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.GetRandom')
  - [Save(entityToBeSaved)](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Save-`0- 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.Save(`0)')
  - [Update(id,entityToBeUpdated)](#M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Update-System-Int32,`0- 'Softimos.FullStackBattles.DAL.Repositories.IRepository`1.Update(System.Int32,`0)')
- [PersonRepository](#T-Softimos-FullStackBattles-DAL-Repositories-PersonRepository 'Softimos.FullStackBattles.DAL.Repositories.PersonRepository')
  - [#ctor(context)](#M-Softimos-FullStackBattles-DAL-Repositories-PersonRepository-#ctor-Softimos-FullStackBattles-Database-CustomDatabaseContext- 'Softimos.FullStackBattles.DAL.Repositories.PersonRepository.#ctor(Softimos.FullStackBattles.Database.CustomDatabaseContext)')
  - [EntityDbSet](#P-Softimos-FullStackBattles-DAL-Repositories-PersonRepository-EntityDbSet 'Softimos.FullStackBattles.DAL.Repositories.PersonRepository.EntityDbSet')
- [SqlEntityFrameworkCrudRepositoryBase\`2](#T-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2')
  - [#ctor(context)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-#ctor-`1- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.#ctor(`1)')
  - [EntityDbSet](#P-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-EntityDbSet 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.EntityDbSet')
  - [Count()](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Count 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.Count')
  - [Delete(modelToBeDeleted)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Delete-`0- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.Delete(`0)')
  - [GetAll()](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetAll 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.GetAll')
  - [GetById(id)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetById-System-Int32- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.GetById(System.Int32)')
  - [GetPage(pageNumber)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetPage-System-Int32- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.GetPage(System.Int32)')
  - [GetRandom()](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetRandom 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.GetRandom')
  - [Save(modelToBeSaved)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Save-`0- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.Save(`0)')
  - [Update(id,newModel)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Update-System-Int32,`0- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2.Update(System.Int32,`0)')
- [SqlEntityFrameworkRepositoryBase\`2](#T-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2')
  - [#ctor(context)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-#ctor-`1- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2.#ctor(`1)')
  - [_Context](#F-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-_Context 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2._Context')
  - [Context](#P-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-Context 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2.Context')
  - [Dispose()](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-Dispose 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2.Dispose')
  - [VerifyItemIsAddedOrAttachedToDbSet(dbSet,item)](#M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-VerifyItemIsAddedOrAttachedToDbSet-Microsoft-EntityFrameworkCore-DbSet{`0},`0- 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2.VerifyItemIsAddedOrAttachedToDbSet(Microsoft.EntityFrameworkCore.DbSet{`0},`0)')
- [StarshipRepository](#T-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository 'Softimos.FullStackBattles.DAL.Repositories.StarshipRepository')
  - [#ctor(context)](#M-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository-#ctor-Softimos-FullStackBattles-Database-CustomDatabaseContext- 'Softimos.FullStackBattles.DAL.Repositories.StarshipRepository.#ctor(Softimos.FullStackBattles.Database.CustomDatabaseContext)')
  - [EntityDbSet](#P-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository-EntityDbSet 'Softimos.FullStackBattles.DAL.Repositories.StarshipRepository.EntityDbSet')

<a name='T-Softimos-FullStackBattles-DAL-Constants'></a>
## Constants `type`

##### Namespace

Softimos.FullStackBattles.DAL

##### Summary

Project constant values

<a name='F-Softimos-FullStackBattles-DAL-Constants-ItemsPerPage'></a>
### ItemsPerPage `constants`

##### Summary

Number of returned items per page

<a name='T-Softimos-FullStackBattles-DAL-Repositories-IRepository`1'></a>
## IRepository\`1 `type`

##### Namespace

Softimos.FullStackBattles.DAL.Repositories

##### Summary

Interface for repositories to force implementation of all desired methods.
Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | Repository data model type. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Count'></a>
### Count() `method`

##### Summary

Counts the number of items of an entity in a database.

##### Returns

Number of items.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Delete-`0-'></a>
### Delete(entityToBeDeleted) `method`

##### Summary

Deletes the specified element from the database.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityToBeDeleted | [\`0](#T-`0 '`0') | The entity to be deleted of type TEntity. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetAll'></a>
### GetAll() `method`

##### Summary

Gets all elements of an entity TEntity.

##### Returns

Enumerable collection of elements of type TEntity.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Gets the element by providing its identifier value.

##### Returns

Element of type TEntity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier value in the database. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetPage-System-Int32-'></a>
### GetPage(pageNumber) `method`

##### Summary

Gets a subset of elements of an entity TEntity.

##### Returns

Enumerable collection  of elements of type TEntity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pageNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Zero-based page index value. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-GetRandom'></a>
### GetRandom() `method`

##### Summary

Gets a random element of an entity TEntity.

##### Returns

Element of type TEntity.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Save-`0-'></a>
### Save(entityToBeSaved) `method`

##### Summary

Adds the specified element to the database.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityToBeSaved | [\`0](#T-`0 '`0') | The entity to be saved of type TEntity. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-IRepository`1-Update-System-Int32,`0-'></a>
### Update(id,entityToBeUpdated) `method`

##### Summary

Updates the specified element in the database.

##### Returns

Boolean value indicating whether the update operation was successful.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier value in the database. |
| entityToBeUpdated | [\`0](#T-`0 '`0') | The entity of type TEntity to be updated. |

<a name='T-Softimos-FullStackBattles-DAL-Repositories-PersonRepository'></a>
## PersonRepository `type`

##### Namespace

Softimos.FullStackBattles.DAL.Repositories

##### Summary

Repository of the person entity.

##### See Also

- [Softimos.FullStackBattles.DAL.SqlEntityFrameworkCrudRepositoryBase<Softimos.FullStackBattles.DTO.Person, Softimos.FullStackBattles.Database.CustomDatabaseContext>](#!-Softimos-FullStackBattles-DAL-SqlEntityFrameworkCrudRepositoryBase<Softimos-FullStackBattles-DTO-Person, Softimos-FullStackBattles-Database-CustomDatabaseContext> 'Softimos.FullStackBattles.DAL.SqlEntityFrameworkCrudRepositoryBase<Softimos.FullStackBattles.DTO.Person, Softimos.FullStackBattles.Database.CustomDatabaseContext>')
- [Softimos.FullStackBattles.DAL.IRepository<Softimos.FullStackBattles.DTO.Person>](#!-Softimos-FullStackBattles-DAL-IRepository<Softimos-FullStackBattles-DTO-Person> 'Softimos.FullStackBattles.DAL.IRepository<Softimos.FullStackBattles.DTO.Person>')

<a name='M-Softimos-FullStackBattles-DAL-Repositories-PersonRepository-#ctor-Softimos-FullStackBattles-Database-CustomDatabaseContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [PersonRepository](#T-Softimos-FullStackBattles-DAL-Repositories-PersonRepository 'Softimos.FullStackBattles.DAL.Repositories.PersonRepository') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Softimos.FullStackBattles.Database.CustomDatabaseContext](#T-Softimos-FullStackBattles-Database-CustomDatabaseContext 'Softimos.FullStackBattles.Database.CustomDatabaseContext') | The context. |

<a name='P-Softimos-FullStackBattles-DAL-Repositories-PersonRepository-EntityDbSet'></a>
### EntityDbSet `property`

##### Summary

Gets the entity database set.

<a name='T-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2'></a>
## SqlEntityFrameworkCrudRepositoryBase\`2 `type`

##### Namespace

Softimos.FullStackBattles.DAL.Repositories

##### Summary

Base class for EF Core repository having implemented CRUD operations. 
Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type of the entity. |
| TDbContext | The type of the database context. |

##### See Also

- [Softimos.FullStackBattles.DAL.SqlEntityFrameworkRepositoryBase<TEntity, TDbContext>](#!-Softimos-FullStackBattles-DAL-SqlEntityFrameworkRepositoryBase<TEntity, TDbContext> 'Softimos.FullStackBattles.DAL.SqlEntityFrameworkRepositoryBase<TEntity, TDbContext>')
- [Softimos.FullStackBattles.DAL.IRepository<TEntity>](#!-Softimos-FullStackBattles-DAL-IRepository<TEntity> 'Softimos.FullStackBattles.DAL.IRepository<TEntity>')

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-#ctor-`1-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [SqlEntityFrameworkCrudRepositoryBase\`2](#T-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkCrudRepositoryBase`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [\`1](#T-`1 '`1') | The context. |

<a name='P-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-EntityDbSet'></a>
### EntityDbSet `property`

##### Summary

Gets the entity database set.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Count'></a>
### Count() `method`

##### Summary

Counts the number of items of an entity in a database.

##### Returns

Number of items.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Delete-`0-'></a>
### Delete(modelToBeDeleted) `method`

##### Summary

Deletes the specified model to be deleted.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelToBeDeleted | [\`0](#T-`0 '`0') | The model to be deleted. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | modelToBeDeleted - Parameter {nameof(modelToBeDeleted)} is null. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetAll'></a>
### GetAll() `method`

##### Summary

Gets all elements of an entity TEntity.

##### Returns

Enumerable collection of elements of type TEntity.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Gets the element by providing its identifier value.

##### Returns

Element of type TEntity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier value in the database. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetPage-System-Int32-'></a>
### GetPage(pageNumber) `method`

##### Summary

Gets a subset of elements of an entity TEntity.

##### Returns

Enumerable collection of elements of type TEntity.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pageNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Zero-based page index value. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-GetRandom'></a>
### GetRandom() `method`

##### Summary

Gets a random element of an entity TEntity.
Due to the small amount of data the implementation prioritized minimal number of request to the database
and not the optimal ordering of the items.

##### Returns

Element of type TEntity.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Save-`0-'></a>
### Save(modelToBeSaved) `method`

##### Summary

Saves the specified model to be saved.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| modelToBeSaved | [\`0](#T-`0 '`0') | The model to be saved. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | modelToBeSaved - Parameter {nameof(modelToBeSaved)} is null. |

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkCrudRepositoryBase`2-Update-System-Int32,`0-'></a>
### Update(id,newModel) `method`

##### Summary

Updates the specified element in the database.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier. |
| newModel | [\`0](#T-`0 '`0') | The new model. |

<a name='T-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2'></a>
## SqlEntityFrameworkRepositoryBase\`2 `type`

##### Namespace

Softimos.FullStackBattles.DAL.Repositories

##### Summary

Base class for CRUD repository.
Pattern proposed by Ben Day: https://github.com/benday/dotnet-core-utils/

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The type of the entity. |
| TDbContext | The type of the database context. |

##### See Also

- [System.IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable')

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-#ctor-`1-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [SqlEntityFrameworkRepositoryBase\`2](#T-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2 'Softimos.FullStackBattles.DAL.Repositories.SqlEntityFrameworkRepositoryBase`2') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [\`1](#T-`1 '`1') | The context. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | context - Parameter {nameof(context)} is null. |

<a name='F-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-_Context'></a>
### _Context `constants`

##### Summary

The context

<a name='P-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-Context'></a>
### Context `property`

##### Summary

Gets the context.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-DAL-Repositories-SqlEntityFrameworkRepositoryBase`2-VerifyItemIsAddedOrAttachedToDbSet-Microsoft-EntityFrameworkCore-DbSet{`0},`0-'></a>
### VerifyItemIsAddedOrAttachedToDbSet(dbSet,item) `method`

##### Summary

Verifies if the item is added or attached to database set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dbSet | [Microsoft.EntityFrameworkCore.DbSet{\`0}](#T-Microsoft-EntityFrameworkCore-DbSet{`0} 'Microsoft.EntityFrameworkCore.DbSet{`0}') | The database set. |
| item | [\`0](#T-`0 '`0') | The item. |

<a name='T-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository'></a>
## StarshipRepository `type`

##### Namespace

Softimos.FullStackBattles.DAL.Repositories

##### Summary

Repository of the starship entity.

##### See Also

- [Softimos.FullStackBattles.DAL.SqlEntityFrameworkCrudRepositoryBase<Softimos.FullStackBattles.DTO.Starship, Softimos.FullStackBattles.Database.CustomDatabaseContext>](#!-Softimos-FullStackBattles-DAL-SqlEntityFrameworkCrudRepositoryBase<Softimos-FullStackBattles-DTO-Starship, Softimos-FullStackBattles-Database-CustomDatabaseContext> 'Softimos.FullStackBattles.DAL.SqlEntityFrameworkCrudRepositoryBase<Softimos.FullStackBattles.DTO.Starship, Softimos.FullStackBattles.Database.CustomDatabaseContext>')
- [Softimos.FullStackBattles.DAL.IRepository<Softimos.FullStackBattles.DTO.Starship>](#!-Softimos-FullStackBattles-DAL-IRepository<Softimos-FullStackBattles-DTO-Starship> 'Softimos.FullStackBattles.DAL.IRepository<Softimos.FullStackBattles.DTO.Starship>')

<a name='M-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository-#ctor-Softimos-FullStackBattles-Database-CustomDatabaseContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [StarshipRepository](#T-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository 'Softimos.FullStackBattles.DAL.Repositories.StarshipRepository') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Softimos.FullStackBattles.Database.CustomDatabaseContext](#T-Softimos-FullStackBattles-Database-CustomDatabaseContext 'Softimos.FullStackBattles.Database.CustomDatabaseContext') | The context. |

<a name='P-Softimos-FullStackBattles-DAL-Repositories-StarshipRepository-EntityDbSet'></a>
### EntityDbSet `property`

##### Summary

Gets the entity database set.
