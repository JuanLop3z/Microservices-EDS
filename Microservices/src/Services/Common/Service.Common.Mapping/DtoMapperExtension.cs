using System.Text.Json;

namespace Services.Common.Mapping
{
    public static class DtoMapperExtension
    {
        //se usa para serializar la clase y mapearla si tienen las mismas propiedades
        public static T MapTo<T>(this object value) 
        {
            return JsonSerializer.Deserialize<T>(
                JsonSerializer.Serialize(value)
            );
        }
    }
}
