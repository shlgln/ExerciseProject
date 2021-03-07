using ExerciseProject.DataBaseCon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.UnitOfWork
{
    public class EFUnitOfWork : UnitOfWorkRepository
    {
        private readonly DataBaseContext _context;
        public EFUnitOfWork(DataBaseContext dataBaseContext)
        {
            _context = dataBaseContext;
        }
        public void complete()
        {
            _context.SaveChanges();
        }
    }
}
