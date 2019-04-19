using System.Globalization;
using Sitecore.Collections;
using Sitecore.Data;

namespace Sitecore.Extensions.Items.Fields
{
    public static class FieldCollectionExtensions
    {
        public static bool HasField(this FieldCollection fieldCollection, ID fieldId)
        {
            return fieldCollection[fieldId] != null;
        }

        public static bool HasField(this FieldCollection fieldCollection, string fieldName)
        {
            return fieldCollection[fieldName] != null;
        }

        public static bool FieldHasValue(this FieldCollection fieldCollection, ID fieldId)
        {
            return !string.IsNullOrWhiteSpace(fieldCollection[fieldId]?.Value);
        }

        public static bool FieldHasValue(this FieldCollection fieldCollection, string fieldName)
        {
            return !string.IsNullOrWhiteSpace(fieldCollection[fieldName]?.Value);
        }

        public static int? GetInteger(this FieldCollection fieldCollection, ID fieldId)
        {
            return !int.TryParse(fieldCollection[fieldId].Value, out var result) ? new int?() : result;
        }

        public static int? GetInteger(this FieldCollection fieldCollection, string fieldName)
        {
            return !int.TryParse(fieldCollection[fieldName].Value, out var result) ? new int?() : result;
        }

        public static double? GetDouble(this FieldCollection fieldCollection, ID fieldId)
        {
            var value = fieldCollection[fieldId]?.Value;

            if (value == null)
            {
                return null;
            }

            if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var num) 
                || double.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out num) 
                || double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out num))
            {
                return num;
            }

            return null;
        }
    }
}