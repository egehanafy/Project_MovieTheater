using Microsoft.EntityFrameworkCore;
using Project.BLL.Abstract;
using Project.DAL.Context;
using Project.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.BLL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private ProjectContext _db;
        private DbSet<T> _entities;

        public BaseRepository(ProjectContext db)
        {
            _db = db;
            _entities = _db.Set<T>();
        }

        public string Create(T entity)
        {
            try
            {
                _entities.Add(entity);
                _db.SaveChanges();
                return "veri eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            };
        }

        public string Delete(T entity)
        {
            try
            {
                var deleted = _entities.Find(entity.Id);
                _entities.Remove(deleted);
                _db.SaveChanges();
                return "veri silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(x=>x.Status == Entity.Enum.Status.Inserted || x.Status == Entity.Enum.Status.Updated).AsEnumerable();
        }

        public T GetById(int id)
        {
            var entity = _entities.Find(id);
            return entity;
        }

        public string Update(T entity)
        {
            string result = "";
            try
            {
                switch (entity.Status)
                {
                    case Entity.Enum.Status.Updated:
                        entity.Status = Entity.Enum.Status.Updated;
                        _db.Entry(entity).State = EntityState.Modified;
                        _db.SaveChanges();
                        result = "veri guncellendi";
                        break;
                    case Entity.Enum.Status.Deleted:
                        entity.Status= Entity.Enum.Status.Deleted;
                        _db.SaveChanges();
                        result = "veri silindi";
                        break;
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
