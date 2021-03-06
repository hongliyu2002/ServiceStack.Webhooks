﻿using Moq;
using NUnit.Framework;
using ServiceStack.FluentValidation;
using ServiceStack.Webhooks.ServiceModel;

namespace ServiceStack.Webhooks.UnitTests.ServiceModel
{
    public class UpdateSubscriptionHistoryValidatorSpec
    {
        [TestFixture]
        public class GivenADto
        {
            private Mock<ISubscriptionDeliveryResultValidator> deliveryResultValidator;
            private UpdateSubscriptionHistory dto;
            private UpdateSubscriptionHistoryValidator validator;

            [SetUp]
            public void Initialize()
            {
                dto = new UpdateSubscriptionHistory();
                deliveryResultValidator = new Mock<ISubscriptionDeliveryResultValidator>();
                validator = new UpdateSubscriptionHistoryValidator(deliveryResultValidator.Object);
            }

            [Test, Category("Unit")]
            public void WhenAllPropertiesValid_ThenSucceeds()
            {
                validator.ValidateAndThrow(dto);
            }
        }
    }
}