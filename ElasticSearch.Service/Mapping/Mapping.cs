using ElasticSearch.Data.Entity;
using ElasticSearch.Data.Enum;
using Nest;

namespace ElasticSearch.Service.Mapping;

public static class Mapping
{
    public static CreateIndexDescriptor CityMapping(this CreateIndexDescriptor descriptor)
    {
        return descriptor.Map<City>(m => m.Properties(p => p
            .Keyword(k => k.Name(n => n.Id))
            .Text(t => t.Name(n => n.Name))
            .Text(t => t.Name(n => n.RegionType))
            .Number(t => t.Name(n => n.Population))
            .Date(t => t.Name(n => n.CreateDate)))
        );
    }
}