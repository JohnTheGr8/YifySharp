using System;
using System.ComponentModel;

namespace YifySharp.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T enumValue) where T : struct
        {
            // Verify type is enum
            var type = enumValue.GetType();
            if (!type.IsEnum)
                throw new ArgumentException("enumValue must be of type Enum", "enumValue");

            // Look for Description attribute for the enum
            var memberInfo = type.GetMember(enumValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                // Attribute found, return the value
                if (attrs.Length > 0)
                    return ((DescriptionAttribute) attrs[0]).Description;
            }
            // Attribute does not exist, just use ToString
            return enumValue.ToString();
        }
    }
}
