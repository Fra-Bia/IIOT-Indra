namespace ITS.Indra.Infrastructure.Persistence;

using ITS.Indra.ApplicationCore.Entities;
using ITS.Indra.ApplicationCore.Persistence;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class WeatherStationsSqlRepository : IWeatherStationsRepository
{
    private readonly string _connectionString;

    public WeatherStationsSqlRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sql");
        // Dottor-WeatherStations
    }

    public Task<IEnumerable<WeatherStation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<WeatherStation?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(WeatherStation weatherStation)
    {
        throw new NotImplementedException();
    }
}
