using Microsoft.EntityFrameworkCore;

namespace OtripleS.Web.Api.Storage;

public class StorageBroker : EFxceptions.EFxceptionsContext, IStorageBroker
{
    private readonly IConfiguration _configuration;

    public StorageBroker(IConfiguration configuration)
    {
        _configuration = configuration;
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connectionString);
    }
}