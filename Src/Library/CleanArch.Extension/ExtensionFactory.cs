using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace CleanArch.Extension {
    public static class ExtensionFactory
    {
        public static TConfig InjectConfig<TConfig>(IConfiguration configuration, string configSection, IServiceCollection services = null) {
            var config = configuration.GetSection(configSection).Get<TConfig>();
            Console.WriteLine($"--- Start--- {configSection}: {JsonConvert.SerializeObject(config)}");
            if (configuration == null) {
                throw new Exception($"Missing config {configuration}");
            }

            if (services != null) {
                services.AddSingleton(typeof(TConfig), config);
            }

            return config;
        }
    }
}
