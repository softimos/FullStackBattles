<a name='assembly'></a>
# Softimos.FullStackBattles.WebApi

## Contents

- [PeopleController](#T-Softimos-FullStackBattles-WebApi-Controllers-PeopleController 'Softimos.FullStackBattles.WebApi.Controllers.PeopleController')
  - [#ctor(personRepository,logger)](#M-Softimos-FullStackBattles-WebApi-Controllers-PeopleController-#ctor-Softimos-FullStackBattles-DAL-Repositories-IRepository{Softimos-FullStackBattles-DTO-Person},Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{Softimos-FullStackBattles-DTO-Person}}- 'Softimos.FullStackBattles.WebApi.Controllers.PeopleController.#ctor(Softimos.FullStackBattles.DAL.Repositories.IRepository{Softimos.FullStackBattles.DTO.Person},Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{Softimos.FullStackBattles.DTO.Person}})')
- [Program](#T-Softimos-FullStackBattles-WebApi-Program 'Softimos.FullStackBattles.WebApi.Program')
  - [CreateHostBuilder(args)](#M-Softimos-FullStackBattles-WebApi-Program-CreateHostBuilder-System-String[]- 'Softimos.FullStackBattles.WebApi.Program.CreateHostBuilder(System.String[])')
  - [Main(args)](#M-Softimos-FullStackBattles-WebApi-Program-Main-System-String[]- 'Softimos.FullStackBattles.WebApi.Program.Main(System.String[])')
- [ResourceControllerBase\`1](#T-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1')
  - [#ctor(entityRepository,logger)](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-#ctor-Softimos-FullStackBattles-DAL-Repositories-IRepository{`0},Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{`0}}- 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.#ctor(Softimos.FullStackBattles.DAL.Repositories.IRepository{`0},Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{`0}})')
  - [entityRepository](#F-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-entityRepository 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.entityRepository')
  - [logger](#F-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-logger 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.logger')
  - [Create(model)](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-Create-`0- 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.Create(`0)')
  - [Delete(id)](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-Delete-System-Int32- 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.Delete(System.Int32)')
  - [GetById(id)](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetById-System-Int32- 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.GetById(System.Int32)')
  - [GetCount()](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetCount 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.GetCount')
  - [GetList()](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetList 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.GetList')
  - [GetPage(pageNumber)](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetPage-System-Int32- 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.GetPage(System.Int32)')
  - [GetRandom()](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetRandom 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.GetRandom')
  - [Update(id,newModel)](#M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-Update-System-Int32,`0- 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1.Update(System.Int32,`0)')
- [StarshipsController](#T-Softimos-FullStackBattles-WebApi-Controllers-StarshipsController 'Softimos.FullStackBattles.WebApi.Controllers.StarshipsController')
  - [#ctor(starshipRepository,logger)](#M-Softimos-FullStackBattles-WebApi-Controllers-StarshipsController-#ctor-Softimos-FullStackBattles-DAL-Repositories-IRepository{Softimos-FullStackBattles-DTO-Starship},Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{Softimos-FullStackBattles-DTO-Starship}}- 'Softimos.FullStackBattles.WebApi.Controllers.StarshipsController.#ctor(Softimos.FullStackBattles.DAL.Repositories.IRepository{Softimos.FullStackBattles.DTO.Starship},Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{Softimos.FullStackBattles.DTO.Starship}})')
- [Startup](#T-Softimos-FullStackBattles-WebApi-Startup 'Softimos.FullStackBattles.WebApi.Startup')
  - [#ctor(configuration)](#M-Softimos-FullStackBattles-WebApi-Startup-#ctor-Microsoft-Extensions-Configuration-IConfiguration- 'Softimos.FullStackBattles.WebApi.Startup.#ctor(Microsoft.Extensions.Configuration.IConfiguration)')
  - [_corsPolicyName](#F-Softimos-FullStackBattles-WebApi-Startup-_corsPolicyName 'Softimos.FullStackBattles.WebApi.Startup._corsPolicyName')
  - [Configuration](#P-Softimos-FullStackBattles-WebApi-Startup-Configuration 'Softimos.FullStackBattles.WebApi.Startup.Configuration')
  - [Configure(app,env,logger)](#M-Softimos-FullStackBattles-WebApi-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment,Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Startup}- 'Softimos.FullStackBattles.WebApi.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IWebHostEnvironment,Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Startup})')
  - [ConfigureServices(services)](#M-Softimos-FullStackBattles-WebApi-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Softimos.FullStackBattles.WebApi.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [InitializeSwagger(services)](#M-Softimos-FullStackBattles-WebApi-Startup-InitializeSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Softimos.FullStackBattles.WebApi.Startup.InitializeSwagger(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-Softimos-FullStackBattles-WebApi-Controllers-PeopleController'></a>
## PeopleController `type`

##### Namespace

Softimos.FullStackBattles.WebApi.Controllers

##### Summary

Controller for people resources

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-PeopleController-#ctor-Softimos-FullStackBattles-DAL-Repositories-IRepository{Softimos-FullStackBattles-DTO-Person},Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{Softimos-FullStackBattles-DTO-Person}}-'></a>
### #ctor(personRepository,logger) `constructor`

##### Summary

Initializes a new instance of the [PeopleController](#T-Softimos-FullStackBattles-WebApi-Controllers-PeopleController 'Softimos.FullStackBattles.WebApi.Controllers.PeopleController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| personRepository | [Softimos.FullStackBattles.DAL.Repositories.IRepository{Softimos.FullStackBattles.DTO.Person}](#T-Softimos-FullStackBattles-DAL-Repositories-IRepository{Softimos-FullStackBattles-DTO-Person} 'Softimos.FullStackBattles.DAL.Repositories.IRepository{Softimos.FullStackBattles.DTO.Person}') | The person repository. |
| logger | [Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{Softimos.FullStackBattles.DTO.Person}}](#T-Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{Softimos-FullStackBattles-DTO-Person}} 'Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{Softimos.FullStackBattles.DTO.Person}}') | The logger. |

<a name='T-Softimos-FullStackBattles-WebApi-Program'></a>
## Program `type`

##### Namespace

Softimos.FullStackBattles.WebApi

##### Summary

Main class of the application.

<a name='M-Softimos-FullStackBattles-WebApi-Program-CreateHostBuilder-System-String[]-'></a>
### CreateHostBuilder(args) `method`

##### Summary

Creates the host builder.

##### Returns

Host Builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The arguments. |

<a name='M-Softimos-FullStackBattles-WebApi-Program-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

Defines the entry point of the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The arguments. |

<a name='T-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1'></a>
## ResourceControllerBase\`1 `type`

##### Namespace

Softimos.FullStackBattles.WebApi.Controllers

##### Summary

Base Controller for resource entities

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-#ctor-Softimos-FullStackBattles-DAL-Repositories-IRepository{`0},Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{`0}}-'></a>
### #ctor(entityRepository,logger) `constructor`

##### Summary

Initializes a new instance of the [ResourceControllerBase\`1](#T-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1 'Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entityRepository | [Softimos.FullStackBattles.DAL.Repositories.IRepository{\`0}](#T-Softimos-FullStackBattles-DAL-Repositories-IRepository{`0} 'Softimos.FullStackBattles.DAL.Repositories.IRepository{`0}') | The entity repository. |
| logger | [Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{\`0}}](#T-Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{`0}} 'Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{`0}}') | The logger. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | entityRepository |

<a name='F-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-entityRepository'></a>
### entityRepository `constants`

##### Summary

The entity repository

<a name='F-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-logger'></a>
### logger `constants`

##### Summary

The logger

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-Create-`0-'></a>
### Create(model) `method`

##### Summary

Adds the specified element to the database.

##### Returns

ActionResult indicating whether the operation was successful.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`0](#T-`0 '`0') | Entity model. |

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-Delete-System-Int32-'></a>
### Delete(id) `method`

##### Summary

Deletes the specified element from the database.

##### Returns

ActionResult indicating whether the operation was successful.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier value in the database. |

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetById-System-Int32-'></a>
### GetById(id) `method`

##### Summary

Gets the element from the database by providing its identifier value.

##### Returns

Element of entity type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier value in the database. |

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetCount'></a>
### GetCount() `method`

##### Summary

Counts the number of items of an entity in a database.

##### Returns

Number of items.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetList'></a>
### GetList() `method`

##### Summary

Gets all elements from the database.

##### Returns

Enumerable collection of elements of entity type

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetPage-System-Int32-'></a>
### GetPage(pageNumber) `method`

##### Summary

Gets a subset of elements from the database.

##### Returns

Enumerable collection of elements of entity type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pageNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Zero-based page index value. |

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-GetRandom'></a>
### GetRandom() `method`

##### Summary

Gets a random element from the database.

##### Returns

Element of entity type.

##### Parameters

This method has no parameters.

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase`1-Update-System-Int32,`0-'></a>
### Update(id,newModel) `method`

##### Summary

Updates the specified element in the database.

##### Returns

ActionResult indicating whether the operation was successful.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The identifier value in the database. |
| newModel | [\`0](#T-`0 '`0') | entity entity. |

<a name='T-Softimos-FullStackBattles-WebApi-Controllers-StarshipsController'></a>
## StarshipsController `type`

##### Namespace

Softimos.FullStackBattles.WebApi.Controllers

##### Summary

Controller for starships resources

##### See Also

- [Microsoft.AspNetCore.Mvc.ControllerBase](#T-Microsoft-AspNetCore-Mvc-ControllerBase 'Microsoft.AspNetCore.Mvc.ControllerBase')

<a name='M-Softimos-FullStackBattles-WebApi-Controllers-StarshipsController-#ctor-Softimos-FullStackBattles-DAL-Repositories-IRepository{Softimos-FullStackBattles-DTO-Starship},Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{Softimos-FullStackBattles-DTO-Starship}}-'></a>
### #ctor(starshipRepository,logger) `constructor`

##### Summary

Initializes a new instance of the [StarshipsController](#T-Softimos-FullStackBattles-WebApi-Controllers-StarshipsController 'Softimos.FullStackBattles.WebApi.Controllers.StarshipsController') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| starshipRepository | [Softimos.FullStackBattles.DAL.Repositories.IRepository{Softimos.FullStackBattles.DTO.Starship}](#T-Softimos-FullStackBattles-DAL-Repositories-IRepository{Softimos-FullStackBattles-DTO-Starship} 'Softimos.FullStackBattles.DAL.Repositories.IRepository{Softimos.FullStackBattles.DTO.Starship}') | The starship repository. |
| logger | [Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{Softimos.FullStackBattles.DTO.Starship}}](#T-Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Controllers-ResourceControllerBase{Softimos-FullStackBattles-DTO-Starship}} 'Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Controllers.ResourceControllerBase{Softimos.FullStackBattles.DTO.Starship}}') | The logger. |

<a name='T-Softimos-FullStackBattles-WebApi-Startup'></a>
## Startup `type`

##### Namespace

Softimos.FullStackBattles.WebApi

##### Summary

Configures the application at start time.

<a name='M-Softimos-FullStackBattles-WebApi-Startup-#ctor-Microsoft-Extensions-Configuration-IConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Initializes a new instance of the [Startup](#T-Softimos-FullStackBattles-WebApi-Startup 'Softimos.FullStackBattles.WebApi.Startup') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The application configuration. |

<a name='F-Softimos-FullStackBattles-WebApi-Startup-_corsPolicyName'></a>
### _corsPolicyName `constants`

##### Summary

Identifies The CORS policy by its unique name

<a name='P-Softimos-FullStackBattles-WebApi-Startup-Configuration'></a>
### Configuration `property`

##### Summary

Gets the application configuration.

<a name='M-Softimos-FullStackBattles-WebApi-Startup-Configure-Microsoft-AspNetCore-Builder-IApplicationBuilder,Microsoft-AspNetCore-Hosting-IWebHostEnvironment,Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Startup}-'></a>
### Configure(app,env,logger) `method`

##### Summary

This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') | The application. |
| env | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') | The env. |
| logger | [Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Startup}](#T-Microsoft-Extensions-Logging-ILogger{Softimos-FullStackBattles-WebApi-Startup} 'Microsoft.Extensions.Logging.ILogger{Softimos.FullStackBattles.WebApi.Startup}') | The logger. |

<a name='M-Softimos-FullStackBattles-WebApi-Startup-ConfigureServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(services) `method`

##### Summary

This method gets called by the runtime. Use this method to add services to the container.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The services collection. |

<a name='M-Softimos-FullStackBattles-WebApi-Startup-InitializeSwagger-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### InitializeSwagger(services) `method`

##### Summary

Initializes Swagger configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The services collection. |
