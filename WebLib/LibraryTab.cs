using Glimpse.Core.Extensibility;

namespace WebLib {
    public class LibraryTab : TabBase {
        public override object GetData(ITabContext context) {
            return new { Test = "Data" };
        }

        public override string Name {
            get { return "LibraryTab"; }
        }
    }
}