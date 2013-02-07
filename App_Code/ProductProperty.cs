using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ClassName
/// </summary>
public class ProductProperty
{
        public string name;
        public string displayName;
        public string type;
        public bool required;
        public ProductProperty (string name, string displayName, string type, bool required=false) {
            this.name=name;
            this.displayName=displayName;
            this.type=type;
            this.required=required;
    }
}
