using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ClassName
/// </summary>
public class ProductProperty{
        public string displayName;
        public string type;
        public bool required;
		public bool vertical;
        public ProductProperty (string displayName, string type, bool required=false, bool vertical=false) {
            this.displayName=displayName;
            this.type=type;
            this.required=required;
			this.vertical=vertical;
    }
}
