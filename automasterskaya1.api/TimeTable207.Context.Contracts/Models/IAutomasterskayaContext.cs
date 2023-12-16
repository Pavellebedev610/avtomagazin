using Automasterskaya.Context.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using TimeTable207.Context.Contracts.Models;
namespace TimeTable207.Context.Contracts
{
    public interface IAutomasterskayaContext 
    {
        /// <summary>
        /// ������
        /// </summary>
        DbSet<Car> Cars { get; }

        /// <summary>
        /// ��������
        /// </summary>
        DbSet<Customer> Customers { get; }

        DbSet<Service> Services { get; }

        int SaveChanges();
    }
}
