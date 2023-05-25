using ElasticSearch.Data.Enum;

namespace ElasticSearch.Data.Entity;

public class City
{
    public string Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string Name { get; set; }
    public string LocalName { get; set; }
    public int Population { get; set; }
    public RegionType RegionType { get; set; }
}