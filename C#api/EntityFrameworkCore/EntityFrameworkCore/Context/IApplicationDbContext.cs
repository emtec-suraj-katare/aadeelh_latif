using EntityFrameworkCore.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}
