using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core._Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum value)
        {
            var attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        public static IDictionary<int, string> ToDictionary(Type enumType)
        {
            var dictionary = new Dictionary<int, string>();

            var enumValues = Enum.GetValues(enumType);
            var enumKeys = Enum.GetNames(enumType);
            var index = 0;
            
            foreach (int val in enumValues)
            {
                dictionary.Add(val, enumKeys[index]);
                index++;
            }

            return dictionary;
        }
    }
}
