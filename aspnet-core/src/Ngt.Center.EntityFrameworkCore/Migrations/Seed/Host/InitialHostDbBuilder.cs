using Ngt.Center.EntityFrameworkCore;

namespace Ngt.Center.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly CenterDbContext _context;

        public InitialHostDbBuilder(CenterDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
