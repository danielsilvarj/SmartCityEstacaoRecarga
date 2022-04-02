using Microsoft.EntityFrameworkCore;
using SmartCity.Dominio.Interfaces;
using SmartCity.Infra.Dados.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Infra.Dados.Repositorio
{
    public class RepositorioBase<T> : IBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<SqlContext> _optionsBuilder;

        public RepositorioBase()
        {
            _optionsBuilder = new DbContextOptions<SqlContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new SqlContext(_optionsBuilder))
            {
                try
                {
                    db.Set<T>().Add(obj);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new SqlContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new SqlContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new SqlContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IReadOnlyList<T> Listar()
        {
            using (var db = new SqlContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
