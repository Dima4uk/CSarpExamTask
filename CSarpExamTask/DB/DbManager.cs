using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.DB;

public class DbManager //<T> where T : class
{
    private ApplicationContext _context;

    public DbManager(ApplicationContext context)
    {
        _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        _context.Add(entity);
        _context.SaveChanges();
    }
    public T? Read<T>(int Id) where T : class
    {
        
        return _context.Find<T>(Id);
    }
    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
    public void Remove<T>(int Id) where T : class
    {
        var entity = _context.Find<T>(Id);
        if (entity != null) 
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

    }
}
