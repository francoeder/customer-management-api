﻿using AutoMapper;
using CustomerManagement.Api.Controllers;
using CustomerManagement.Api.Tests.Base;
using CustomerManagement.Application.Interfaces;
using CustomerManagement.Application.Notifications;
using Moq;

namespace CustomerManagement.Api.Tests.Controllers.Fixtures
{
    public class CustomerControllerFixture : BaseFixture
    {
        public readonly Mock<ICustomerService> CustomerServiceMock;
        public readonly Mock<INotifier> NotifierMock;

        public CustomerControllerFixture()
        {
            CustomerServiceMock = new Mock<ICustomerService>();
            NotifierMock = new Mock<INotifier>();
        }

        public CustomerController GetInstance()
        {
            return new CustomerController(CustomerServiceMock.Object, NotifierMock.Object);
        }
    }
}
