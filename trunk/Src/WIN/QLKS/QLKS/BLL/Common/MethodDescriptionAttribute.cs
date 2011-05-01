using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLKS.BLL.Common
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Method)]
    public class MethodDescriptionAttribute:System.Attribute
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private ModuleType type;

        public ModuleType Type
        {
            get { return type; }
            set { type = value; }
        }
        public MethodDescriptionAttribute(ModuleType type, string title, string description)
        {
            this.Type = type;
            this.Title = title;
            this.Description = description;
        }
    }
}
