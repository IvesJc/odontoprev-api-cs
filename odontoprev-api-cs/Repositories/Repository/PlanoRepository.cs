﻿using odontoprev_api_cs.Data.AppData;
using odontoprev_api_cs.DTOs.Plano;
using odontoprev_api_cs.Entities;
using odontoprev_api_cs.Repositories.Interface;

namespace odontoprev_api_cs.Repositories.Repository;

public class PlanoRepository(AppDbContext  dbContext) : IPlanoRepository
{
    public Task<List<Plano>> GetAllPlanosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Plano?> GetPlanoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Plano> CreatePlanoAsync(CreatePlanoDto plano)
    {
        throw new NotImplementedException();
    }

    public Task<Plano?> UpdatePlanoByAsync(int id, UpdatePlanoDto plano)
    {
        throw new NotImplementedException();
    }

    public Task<Plano?> DeletePlanoByAsync(int id)
    {
        throw new NotImplementedException();
    }
}