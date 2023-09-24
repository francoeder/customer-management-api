﻿using AutoMapper;
using CustomerManagement.Api.Controllers;
using CustomerManagement.Api.Tests.Base;
using CustomerManagement.Domain.Interfaces.Services;
using Moq;

namespace CustomerManagement.Api.Tests.Controllers.Fixtures
{
    public class CustomerControllerFixture : BaseFixture
    {
        public readonly Mock<ICustomerService> CustomerServiceMock;
        public readonly Mock<IMapper> MapperMock;

        public CustomerControllerFixture()
        {
            CustomerServiceMock = new Mock<ICustomerService>();
            MapperMock = new Mock<IMapper>();
        }

        public CustomerController GetInstance()
        {
            return new CustomerController(CustomerServiceMock.Object, MapperMock.Object);
        }
    }
}