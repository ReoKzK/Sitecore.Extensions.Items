using Sitecore.Data.Items;

namespace Sitecore.Extensions.Items
{
    public static class ItemExtensions
    {
        public static bool HasLayout(this Item item)
        {
            return item?.Visualization?.Layout != null;
        }
    }
}