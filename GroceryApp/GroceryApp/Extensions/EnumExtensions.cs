namespace GroceryApp.Extensions
{
    using System;

    public static class EnumExtensions
    {
        public static T GetEnumValue<T>(this string strValue) where T : struct, IConvertible
        {
            Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new Exception($"T {typeof(T)} must be an Enumeration type.");
            }

            return Enum.TryParse(strValue, true, out T val) ? val : throw new Exception($"The string does not exist in Enum {typeof(T)}.");
        }
    }
}