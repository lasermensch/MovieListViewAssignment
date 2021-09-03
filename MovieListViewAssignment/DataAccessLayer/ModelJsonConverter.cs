using MovieListViewAssignment.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieListViewAssignment.DataAccessLayer
{
    //public class ModelJsonConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType)
    //    {
    //        return objectType == typeof(Movie);
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        var jObject = JObject.Load(reader);
    //        var genres = jObject.Property("genres").Value<JObject>();
    //        var model = new Movie
    //        {
    //            Genres = genres.Properties().Skip(1).ToList<int>(g => g.id)
    //        };
    //    }
    //}
}
