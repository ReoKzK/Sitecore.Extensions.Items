using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Extensions.Items.Fields;
using Sitecore.Extensions.Items.Visualization;

namespace Sitecore.Extensions.Items.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Item item = new Item(ID.NewID, ItemData.Empty, Database.GetDatabase("master"));

            item.Fields.HasField("TestField");
            item.Fields.FieldHasValue("TestField2");

            item.Visualization.GetAllRenderingReferences();
            item.Visualization.GetRenderingReferences(ID.NewID);
        }
    }
}
