namespace EMR_local.Models
{
    public static class AppSetting
    {
        public static string? JwtKey { get; set; }
        public static string? JwtIssuer { get; set; }
        public static int TokenExpirationtime { get; set; }
    }
}