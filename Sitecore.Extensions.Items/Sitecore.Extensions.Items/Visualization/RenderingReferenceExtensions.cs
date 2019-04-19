using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Layouts;
using System;

namespace Sitecore.Extensions.Items.Visualization
{
    public static class RenderingReferenceExtensions
    {
        /// <summary>
        /// Returns data source of current RenderingReference object
        /// </summary>
        /// <param name="reference"></param>
        /// <returns></returns>
        public static Item GetDataSourceItem(this RenderingReference reference)
        {
            if (reference != null)
            {
                return GetItem(reference.Settings.DataSource, reference.Database);
            }

            return null;
        }

        private static Item GetItem(string pathOrId, Database db)
        {
            return Guid.TryParse(pathOrId, out var itemId)
                ? db.GetItem(new ID(itemId))
                : db.GetItem(pathOrId);
        }
    }
}