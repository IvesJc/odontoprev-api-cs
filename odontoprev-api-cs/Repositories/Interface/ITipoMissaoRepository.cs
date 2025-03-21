﻿using odontoprev_api_cs.DTOs.TipoMissao;
using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface ITipoMissaoRepository
{
    Task<List<TipoMissao>> GetAllTipoMissaosAsync();
    Task<TipoMissao?> GetTipoMissaoByIdAsync(int id);
    Task<TipoMissao> CreateTipoMissaoAsync(TipoMissao tipoMissao);
    Task<TipoMissao?> UpdateTipoMissaoByAsync(int id, UpdateTipoMissaoDto tipoMissao);
    Task<TipoMissao?> DeleteTipoMissaoByAsync(int id);
}