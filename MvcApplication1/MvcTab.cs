using Glimpse.Core.Extensibility;

namespace MvcApplication1 {
    public class MvcTab : TabBase {
        public override object GetData(ITabContext context) {
            return new { Test = "Data" };
        }

        public override string Name {
            get { return "MvcTab"; }
        }
    }
}