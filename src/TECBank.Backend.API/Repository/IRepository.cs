using Domain.Model;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TECBank.Backend.Repository;

public interface IRepository
{
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    bool SaveChanges();
    Cliente [] GetAllClientes();
    Cliente GetClienteById(int id);

}
