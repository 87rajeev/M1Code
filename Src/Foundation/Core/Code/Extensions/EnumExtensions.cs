using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace M1CP.Foundation.Base.Extensions
{
  
    public static class EnumExtensions
    {
        
        public static string ToDescription(this Enum enumeration)
        {
            Type type = enumeration.GetType();
            MemberInfo[] members = type.GetMember(enumeration.CastTo<string>());
            if (members.Length > 0)
            {
                return members[0].ToDescription();
            }
            return enumeration.CastTo<string>();
        }
    }
}
