using System.Linq;
using EFCore.Data;
using EFCore.Models.Aggregate;
using EFCore.Models.Api;

namespace EFCore
{
    public class Service
    {
        private readonly MyDbContext _context;

        public Service(MyDbContext context)
        {
            _context = context;
        }

        public IQueryable<ModelApi> GetListQuery()
        {
            return _context.Models.Select(ModelApi.SelectExpression).ToList().AsQueryable();
        }

        public void Add(Model model)
        {
            _context.Models.Add(model);
            _context.SaveChanges();
        }
    }
}