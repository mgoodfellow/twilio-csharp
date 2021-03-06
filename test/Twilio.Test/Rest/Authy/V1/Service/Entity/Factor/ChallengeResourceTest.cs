/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Authy.V1.Service.Entity.Factor;

namespace Twilio.Tests.Rest.Authy.V1.Service.Entity.Factor 
{

    [TestFixture]
    public class ChallengeTest : TwilioTest 
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Authy,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Factors/YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Challenges",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Create("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": \"Hi! Mr. John Doe, would you like to sign up?\",\"hidden_details\": \"Hidden details about the sign up\",\"factor_strength\": \"low\",\"factor_type\": \"sms\",\"url\": \"https://authy.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChallengeResource.Create("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Authy,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Factors/YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Challenges/sid",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Delete("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = ChallengeResource.Delete("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Authy,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Factors/YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Challenges/sid",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Fetch("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchSidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": \"details\",\"hidden_details\": \"hidden_details\",\"factor_strength\": \"low\",\"factor_type\": \"sms\",\"url\": \"https://authy.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChallengeResource.Fetch("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchLatestResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"pending\",\"responded_reason\": \"none\",\"details\": \"details\",\"hidden_details\": \"hidden_details\",\"factor_strength\": \"low\",\"factor_type\": \"sms\",\"url\": \"https://authy.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChallengeResource.Fetch("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Authy,
                "/v1/Services/ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Factors/YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Challenges/sid",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChallengeResource.Update("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestVerifySidResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"approved\",\"responded_reason\": \"none\",\"details\": \"Hi! Mr. John Doe, would you like to sign up?\",\"hidden_details\": \"Hidden details about the sign up\",\"factor_strength\": \"low\",\"factor_type\": \"sms\",\"url\": \"https://authy.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChallengeResource.Update("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestVerifyLatestResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"factor_sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"date_responded\": \"2015-07-30T20:00:00Z\",\"expiration_date\": \"2015-07-30T20:00:00Z\",\"status\": \"approved\",\"responded_reason\": \"none\",\"details\": \"Hi! Mr. John Doe, would you like to sign up?\",\"hidden_details\": \"Hidden details about the sign up\",\"factor_strength\": \"low\",\"factor_type\": \"sms\",\"url\": \"https://authy.twilio.com/v1/Services/ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Challenges/YCaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ChallengeResource.Update("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "YFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "sid", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}