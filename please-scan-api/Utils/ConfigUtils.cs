namespace Its.PleaseScan.Api.Utils
{
    public static class ConfigUtils
    {
        public static string GetConfig(IConfiguration cfg, string key)
        {
            var v = "";

            var envKey = key.Replace(":", "__");
            var envVar = Environment.GetEnvironmentVariable(envKey);

            if (envVar == null)
            {
                if (cfg != null)
                {
                    var u = cfg[key];
                    v = string.IsNullOrWhiteSpace(u) ? "" : u;
                }
            }
            else
            {
                v = envVar;
            }

            return v;
        }
    }
}
