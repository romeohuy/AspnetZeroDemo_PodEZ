using PodEZ.PodEZTemplate.EntityFrameworkCore;

namespace PodEZ.PodEZTemplate.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly PodEZTemplateDbContext _context;

        public InitialHostDbBuilder(PodEZTemplateDbContext context)
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
