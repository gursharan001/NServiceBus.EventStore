using System;

namespace NServiceBus.AcceptanceTests
{
    using AcceptanceTesting.Customization;
    using NUnit.Framework;

    /// <summary>
    /// Base class for all the NSB test that sets up our conventions
    /// </summary>
    [TestFixture]
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class NServiceBusAcceptanceTest
    {
        [SetUp]
        public void SetUpEnvironment()
        {
            Environment.SetEnvironmentVariable("EventStoreTransport.ConnectionString","Not used");
        }
    }
}