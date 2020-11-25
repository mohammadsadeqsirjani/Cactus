using System.Data;
using System.Reflection;

public static partial class Extension
{
    /// <summary>
    ///     A T[] extension method that converts the @this to a data table.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DataTable.</returns>
    public static DataTable ToDataTable<T>(this T[] @this)
    {
        var type = typeof(T);

        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var dataTable = new DataTable();

        foreach (var property in properties) dataTable.Columns.Add(property.Name, property.PropertyType);

        foreach (var field in fields) dataTable.Columns.Add(field.Name, field.FieldType);

        foreach (var item in @this)
        {
            var dataRow = dataTable.NewRow();

            foreach (var property in properties) dataRow[property.Name] = property.GetValue(item, null);

            foreach (var field in fields) dataRow[field.Name] = field.GetValue(item);

            dataTable.Rows.Add(dataRow);
        }

        return dataTable;
    }
}