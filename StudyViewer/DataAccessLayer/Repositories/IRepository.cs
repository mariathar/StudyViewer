using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
	public interface IRepository<TEntity>
	{
		TEntity GetById(Guid id);

		IEnumerable<TEntity> GetAll();

		void Add(TEntity type);

		void Update(TEntity type);

		void Delete(TEntity type);
	}
}
