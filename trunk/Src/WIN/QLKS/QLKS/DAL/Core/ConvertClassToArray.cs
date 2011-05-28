using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Reflection;

namespace QLKS.DAL.Core
{
    public class ConvertClassToArray
    {
        public static String[] GetParamName(object item)
        {
            String[] d;
            // define type
            Type t = item.GetType();
            MemberInfo[] member = t.GetProperties();
            int i=0;
            d = new string[member.Length];
            foreach (MemberInfo m in member)
            {
                d[i] = m.Name;
                i++;
            }
            return d;
        }
        public static String[] GetParamName(object item,int? flag)
        {
            String[] d = GetParamName(item);
            int length = d.Length;
            string[] rs = new string[length + 1];
            for (int i = 0; i < rs.Length; i++)
            {
                if (i < length)
                {
                    rs[i] = d[i];
                }
                else
                {
                    rs[i] = "flag";
                }
            }
            return rs;

        }
        public static object[] GetValues(object item)
        {
            Type t = item.GetType();
            String[] name = GetParamName(item);
            object[] d = new object[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                PropertyInfo info = t.GetProperty(name[i]);
                d[i] =  info.GetValue(item, null);
            }
            return d;
        }
        public static object[] GetValues(object item, int flag)
        {
            object[] d = GetValues(item);
            object[] rs = new object[d.Length+1];
            for (int i = 0; i < rs.Length; i++)
            {
                if (i < d.Length)
                    rs[i] = d[i];
                else
                    rs[i] = flag;
            }
            return rs;
        }
    }
}
