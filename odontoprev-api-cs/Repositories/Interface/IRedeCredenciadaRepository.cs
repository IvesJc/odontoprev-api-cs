﻿using odontoprev_api_cs.Entities;

namespace odontoprev_api_cs.Repositories.Interface;

public interface IRedeCredenciadaRepository
{
    Task<List<RedeCredenciada>> GetAllRedeCredenciadasAsync();
    Task<RedeCredenciada?> GetRedeCredenciadaByIdAsync(int id);
    Task<RedeCredenciada> CreateRedeCredenciadaAsync(RedeCredenciada redeCredenciada);
    Task<RedeCredenciada?> UpdateRedeCredenciadaByAsync(int id, RedeCredenciada redeCredenciada);
    Task<RedeCredenciada?> DeleteRedeCredenciadaByAsync(int id);
}