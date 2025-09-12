using Microsoft.EntityFrameworkCore;

namespace OgameAnalytics.Infrastructure.Data
{
    public class OgameDbContext(DbContextOptions<OgameDbContext> options) : DbContext(options)
    {




    }
}
