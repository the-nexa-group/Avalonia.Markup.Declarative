using System;

namespace Avalonia.Markup.Declarative;

/// <summary>
/// Provides extension methods for configuring an <see cref="AppBuilder"/>.
/// </summary>
public static class AppBuilderExtensions
{
    private static IComponentControlFactory? _componentControlFactory;
    private static IServiceProvider? _serviceProvider;
    private static ViewInitializationStrategy _defaultViewInitializationStrategy = ViewInitializationStrategy.Lazy;

    /// <summary>
    /// Gets the current <see cref="IServiceProvider"/> instance.
    /// </summary>
    public static IServiceProvider? ServiceProvider => _serviceProvider;

    /// <summary>
    /// Gets the current <see cref="IComponentControlFactory"/> instance.
    /// </summary>
    internal static IComponentControlFactory? ComponentControlFactory => _componentControlFactory;

    /// <summary>
    /// Gets the default <see cref="ViewInitializationStrategy"/> used by views when not explicitly specified.
    /// </summary>
    internal static ViewInitializationStrategy DefaultViewInitializationStrategy => _defaultViewInitializationStrategy;

    /// <param name="appBuilder">The <see cref="AppBuilder"/> to configure.</param>
    extension(AppBuilder appBuilder)
    {
        /// <summary>
        /// Configures the <see cref="AppBuilder"/> to use the specified <see cref="IServiceProvider"/>.
        /// </summary>
        /// <param name="serviceProvider">The <see cref="IServiceProvider"/> to use.</param>
        /// <returns>The configured <see cref="AppBuilder"/>.</returns>
        public AppBuilder UseServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            return appBuilder;
        }

        public AppBuilder UseComponentControlFactory(IComponentControlFactory componentControlFactory)
        {
            _componentControlFactory = componentControlFactory;
            return appBuilder;
        }

        /// <summary>
        /// Configures the default initialization strategy for views.
        /// </summary>
        /// <param name="strategy">The <see cref="ViewInitializationStrategy"/> to use as default for all views.</param>
        /// <returns>The configured <see cref="AppBuilder"/>.</returns>
        public AppBuilder UseViewInitializationStrategy(ViewInitializationStrategy strategy)
        {
            _defaultViewInitializationStrategy = strategy;
            return appBuilder;
        }

        /// <summary>
        /// Enables or disables hot reload functionality for the application.
        /// </summary>
        /// <param name="enable">A value indicating whether to enable hot reload. Defaults to <c>true</c>.</param>
        /// <returns>The configured <see cref="AppBuilder"/>.</returns>
        public AppBuilder UseHotReload(bool enable = true)
        {
            if (enable)
                HotReloadManager.Activate();
            else
                HotReloadManager.Deactivate();
            
            return appBuilder;
        }
    }
}