using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Common
{
    [Serializable]
    public enum ModuleType
    {
        Administration = 0,
        Catalogue = 1,
        Processing = 2,
        Statistic = 3
    }
    public class GetModuleTypeName
    {
        public static string GetString(ModuleType type)
        {
            switch (type)
            { 
                case ModuleType.Administration:
                    return "Quản trị hệ thống";
                case ModuleType.Catalogue:
                    return "Danh mục";
                case ModuleType.Processing:
                    return "Xử lý nghiệp vụ";
                case ModuleType.Statistic:
                    return "Báo cáo - thống kê";
            }
            return string.Empty;
        }
    }
}
