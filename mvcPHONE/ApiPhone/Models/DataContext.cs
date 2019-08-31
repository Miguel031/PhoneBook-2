
namespace ApiPhone.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiPhone.Models.Phone> Phones { get; set; }
    }
}