using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Layouts;
using System.Linq;

namespace Sitecore.Extensions.Items.Visualization
{
    public static class VisualizationExtensions
    {
        /// <summary>
        /// Returns all rendering references in Presentation Details of specified rendering
        /// </summary>
        /// <param name="itemVisualization"></param>
        /// <param name="renderingId"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        public static RenderingReference[] GetRenderingReferences(this ItemVisualization itemVisualization, ID renderingId, DeviceItem device = null)
        {
            return itemVisualization.GetRenderings(device ?? Sitecore.Context.Device, false)
                       .Where(x => x.RenderingID.Equals(renderingId))
                       .ToArray();
        }

        /// <summary>
        /// Returns all rendering references in Presentation Details
        /// </summary>
        /// <param name="itemVisualization"></param>
        /// <returns></returns>
        public static RenderingReference[] GetAllRenderingReferences(this ItemVisualization itemVisualization, DeviceItem device = null)
        {
            if (itemVisualization == null)
            {
                return new RenderingReference[0];
            }

            return itemVisualization.GetRenderings(device ?? Sitecore.Context.Device, false);
        }
    }
}