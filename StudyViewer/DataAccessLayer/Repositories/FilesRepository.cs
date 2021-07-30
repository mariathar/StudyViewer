using Data.Entities;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
	public class FilesRepository : IRepository<File>
	{
		public FilesRepository()
		{

		}

		public void Add(File type)
		{
			throw new NotImplementedException();
		}

		public void Delete(File type)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<File> GetAll()
		{
			throw new NotImplementedException();
		}

		public File GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Update(File type)
		{
			throw new NotImplementedException();
		}
	}
}
