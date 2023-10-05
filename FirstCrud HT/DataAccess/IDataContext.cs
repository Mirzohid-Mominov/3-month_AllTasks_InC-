using FileBaseContext.Abstractions.Models.FileSet;
using FirstCrudAPI_Hometask.Models;

namespace FirstCrudAPI_Hometask.DataAccess
{
    public interface IDataContext
    {
        IFileSet<User, Guid> Users { get; }
        ValueTask SaveChangesAsync();
    }
}

