global using Xunit;
global using Moq;

global using Entities.Exceptions.NotFound.Products;
global using Entities.Exceptions.NotFound.Providers;
global using Entities.Exceptions.NotFound.Sales;
global using Entities.Models.Products;
global using Entities.Models.Providers;
global using Entities.Models.Sales;
global using Entities.Models.Users;

global using Shared.DataTransferObjects.Products;
global using Shared.DataTransferObjects.Providers;
global using Shared.DataTransferObjects.Sales;
global using Shared.DataTransferObjects.Users;

global using Service.Contracts;
global using Service.Contracts.Products;
global using Service.Contracts.Proveedores;
global using Service.Contracts.Sales;
global using Service.Contracts.Users;

global using Service.Products;
global using Service.Proveedores;
global using Service.Sales;
global using Service.Users;

global using Presentation.Controllers.Products;
global using Presentation.Controllers.Proveedores;
global using Presentation.Controllers.Sales;
global using Presentation.Controllers.Users;

global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Mvc;

global using AutoMapper;