

namespace CleanArch.BusinessAPI {
    public class Startup {
        public IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}