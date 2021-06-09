using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRProject.Models.Common
{
    public static class TypeExtension
    {
        public static bool IsEmpty(this Guid value) => value == default;
        public static bool IsEmpty(this DateTime? value) => value == default || value == DateTime.Now.AddDays(1);
        public static bool IsEmpty(this DateTime value) => value == default;


        public static Guid? ToNullable(this Guid value) => value.IsEmpty() ? null : (Guid?)value;


        public static bool IsEmpty(this Guid? value) => value == default || value == Guid.Empty;


        public static bool IsNullOrEmpty(this string value) => String.IsNullOrEmpty(value);

        public static string GetSerializeObject(this object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            });
        }
    }
}
