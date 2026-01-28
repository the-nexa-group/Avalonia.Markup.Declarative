using Avalonia.Threading;
using System.Reflection;
using Avalonia.Controls;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests
{
    public partial class InjectServiceTests
    {
        public class TestService { }

        public partial class InjectComponent() : Component(ViewInitializationStrategy.Immediate)
        {
            [Inject]
            public TestService? Service { get; private set; }
            protected override Control? Build() => null;
        }

        public partial class DerivedComponent : InjectComponent
        {
            protected override Control? Build() => null;
        }

        [Fact]
        public async Task InjectServices_InjectsIntoBaseClassProperties()
        {
            // Arrange
            SetServiceProvider(new TestServiceProvider(new TestService()));
            var component = new DerivedComponent();

            // Act
            var property = typeof(InjectComponent).GetProperty("Service",
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var value = property?.GetValue(component);

            // Assert
            Assert.NotNull(value);
            Assert.IsType<TestService>(value);
        }

        private class TestServiceProvider(object service) : IServiceProvider
        {
            public object? GetService(Type serviceType) => service;
        }

        private static void SetServiceProvider(IServiceProvider provider)
        {
            // Use reflection to set the private static field _serviceProvider in AppBuilderExtensions
            var type = typeof(AppBuilderExtensions);
            var field = type.GetField("_serviceProvider", BindingFlags.Static | BindingFlags.NonPublic);
            field?.SetValue(null, provider);
        }
    }
}
