namespace MilkAndCookies.Utility
{
    public static class CookieUtility
    {
        public static CookieOptions DefaultOptions => new()
        {
            Expires = DateTimeOffset.Now.AddMinutes(5),
            MaxAge = TimeSpan.FromMinutes(30),
        };
    }
}
