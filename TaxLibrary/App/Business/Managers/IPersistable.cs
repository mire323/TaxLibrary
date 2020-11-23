using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.App.Business.Entities;
using TaxLibrary.datatypes;

namespace TaxLibrary.App.Business.Managers
{
    public interface IPersistable<T> where T : IBusinessEntity
    {
        void Insert(T entity);

        void Insert(List<T> entities);

        void Update(T entity);

        void Update(List<T> entities);

        void Delete(T entity);

        void Delete(List<T> entities);

        void Delete(Id entityId);

        void DeleteAll();

        void OnBeforeInsert(IBusinessEntity entity);
    }
}
