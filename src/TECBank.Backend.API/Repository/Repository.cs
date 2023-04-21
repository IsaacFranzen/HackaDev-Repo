using Domain.Model;
using Microsoft.EntityFrameworkCore;
using TECBank.Backend.Repository.DataContext;

namespace TECBank.Backend.Repository;

public class Repository : IRepository
{
    private readonly TecBankContext _context;
    public Repository(TecBankContext context)
    {
        _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        _context.Add(entity);

    }

    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }

    public bool SaveChanges()
    {
        return _context.SaveChanges() > 0;

    }

    public Cliente[] GetAllClientes()
    {
        IQueryable<Cliente> query = _context.Clientes;
        query = query.AsNoTracking().OrderBy(c => c.Id);
        return query.ToArray();
    }

    public Cliente GetClienteById(int id)
    {
        IQueryable<Cliente> query = _context.Clientes;
        query = query.AsNoTracking()
            .OrderBy(c => c.Id)
            .Where(cli => cli.Id == id);
        return query.FirstOrDefault();
    }
}
