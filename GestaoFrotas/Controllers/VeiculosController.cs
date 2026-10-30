using GestaoFrotas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFrotas.Controllers;

public class VeiculosController : Controller
{
    private static readonly List<Veiculo> _veiculos = new()
    {
        new Veiculo { Id = 1, Placa = "TOE4I19", Marca = "Volkswagen", Modelo = "Polo", Ano = 2025, Status = StatusVeiculo.Ativo },
        new Veiculo { Id = 2, Placa = "RBB9G73", Marca = "Fiat", Modelo = "Argo", Ano = 2022, Status = StatusVeiculo.EmManutencao },
        new Veiculo { Id = 3, Placa = "TOF3F22", Marca = "Chevrolet", Modelo = "Tracker", Ano = 2026, Status = StatusVeiculo.Inativo }
    };

    public IActionResult Index()
    {
        return View(_veiculos);
    }
}