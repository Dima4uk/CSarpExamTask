using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.DB;

public class DbManager <T> where T : class
{
    private ApplicationContext _context;

    public DbManager(ApplicationContext context)
    {
        _context = context;
    }
    public void Add(T obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }
    public T? Read(int Id)
    {
        
        return _context.Find<T>(Id);
    }
    public void Update(T obj)
    {
        _context.Update(obj);
        _context.SaveChanges();
    }
    public void Remove(int Id)
    {
        var obj = _context.Find<T>(Id);
        _context.Remove(obj);
        _context.SaveChanges();
    }
}
