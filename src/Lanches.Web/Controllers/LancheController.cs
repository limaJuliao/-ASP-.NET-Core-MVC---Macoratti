﻿using Lanches.Application.ViewModels;
using Lanches.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches.Web.Controllers;

public class LancheController : Controller
{
    private readonly ILancheRepository _lancheRepository;
    public LancheController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }
    public IActionResult List()
    {
        //var lanches = _lancheRepository.Lanches;
        //return View(lanches);

        return View(new LancheListViewModel
        {
            Lanches = _lancheRepository.Lanches,
            CategoriaAtual = "Categoria Atual"
        });
    }
}