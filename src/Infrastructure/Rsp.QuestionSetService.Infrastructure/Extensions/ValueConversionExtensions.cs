using System.Text.Json;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Rsp.QuestionSetService.Infrastructure.Extensions;

internal static class ValueConversionExtensions
{
    /// <summary>
    /// Creates a ValueConvert and ValueComparer
    /// and adds it to the property's meta data
    /// This is to allow EF to detect changes in the file
    /// for storing and getting data in Json format
    /// </summary>
    public static PropertyBuilder<T> HasJsonConversion<T>(this PropertyBuilder<T> propertyBuilder)
    {
        var options = new JsonSerializerOptions();

        ValueConverter<T, string> converter = new
        (
            v => JsonSerializer.Serialize(v, options),
            v => JsonSerializer.Deserialize<T>(v, options)!
        );

        ValueComparer<T> comparer = new
        (
            (l, r) => JsonSerializer.Serialize(l, options) == JsonSerializer.Serialize(r, options),
            v => object.Equals(v, default(T)) ? 0 : JsonSerializer.Serialize(v, options).GetHashCode(),
            v => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(v, options), options)!
        );

        propertyBuilder.HasConversion(converter);
        propertyBuilder.Metadata.SetValueConverter(converter);
        propertyBuilder.Metadata.SetValueComparer(comparer);

        return propertyBuilder;
    }
}