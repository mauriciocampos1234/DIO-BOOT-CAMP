using Dominio.Entidades;
using Dominio.Interfaces;
using Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Servicos;

public class VeiculoServico : IVeiculoServico
{
    private readonly DbContexto _contexto;

    public VeiculoServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public void Apagar(Veiculo veiculo)
    {
        _contexto.Veiculos.Remove(veiculo);
        _contexto.SaveChanges();
    }

    public void Atualizar(Veiculo veiculo)
    {
        _contexto.Veiculos.Update(veiculo);
        _contexto.SaveChanges();
    }

    public object? BuscaPorId(int id)
    {
        return _contexto.Veiculos.Where(v => v.Id == id).FirstOrDefault();
    }

    public Veiculo? BuscarPorId(int id)
    {
        return _contexto.Veiculos.Where(v => v.Id == id).FirstOrDefault();
    }

    public void Incluir(Veiculo veiculo)
    {
        _contexto.Veiculos.Add(veiculo);
        _contexto.SaveChanges();
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        var query = _contexto.Veiculos.AsQueryable();
        if (!string.IsNullOrEmpty(nome))
        {
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            query = query.Where(v => EF.Functions.Like(v.Nome.ToLower(), $"%{nome}%"));
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }
        int itensPorPagina = 10;

        if (pagina != null)

            query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);
        
        return query.ToList();
    }
}