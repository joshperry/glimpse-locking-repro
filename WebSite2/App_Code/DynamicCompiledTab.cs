using System;
using Glimpse.Core.Extensibility;

namespace ASP {
    // I Never get found by Glimpse
    public class DynamicCompiledTab : Glimpse.Core.Extensibility.TabBase {
        public override object GetData(ITabContext context) {
            return new { Test = "Data" };
        }

        public override string Name {
            get { return "DynamicTab"; }
        }
    }
}