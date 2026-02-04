using System.Reflection;
using System.Text.Json;

using SimpleMvvm.Cat;
using SimpleMvvm.Data;

namespace SimpleMvvm.Repository
{
    public class CatRepository : ICatRepository
    {
        public CatModel[] GetAllCats()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SimpleMvvm.Data.cats.json"))
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                options.Converters.Add(new CatColorJsonConverter());

                return JsonSerializer.Deserialize<CatModel[]>(stream, options);
            }
        }
    }
}