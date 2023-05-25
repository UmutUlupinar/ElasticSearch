using ElasticSearch.Data.Entity;
using ElasticSearch.Service.Interface;

namespace ElasticSearch.Service.Service;

public class ElasticSearchService : IElasticSearchService
{
    public Task CheckIndex(string indexName)
    {
        throw new NotImplementedException();
    }

    public Task InsertDocument(string indexName, City city)
    {
        throw new NotImplementedException();
    }

    public Task DeleteIndex(string IndexName)
    {
        throw new NotImplementedException();
    }

    public Task<List<City>> GetDocuments(string indexName)
    {
        throw new NotImplementedException();
    }
}