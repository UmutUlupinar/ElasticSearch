using ElasticSearch.Data.Entity;

namespace ElasticSearch.Service.Interface;

public interface IElasticSearchService
{
    Task CheckIndex(string indexName);
    Task InsertDocument(string indexName, City city);
    Task DeleteIndex(string IndexName);
    Task<List<City>> GetDocuments(string indexName);
}