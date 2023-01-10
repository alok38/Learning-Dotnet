using System;


namespace ExtensionMethod
{
    public static class MyExtensions
    {
        public static int ToInt32(this string s)
        {
            return int.Parse(s);
        }
    }
}
