﻿using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces;
using Lanches.Infra.Data.Context;

namespace Lanches.Infra.Data.Repositories;

public class CategoriaRepository : EFCoreRepository<Categoria>, ICategoriaRepository
{
    private readonly AppDbContext _context;
    public CategoriaRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}
