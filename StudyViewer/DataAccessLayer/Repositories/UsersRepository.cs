using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
	public class UsersRepository : IRepository<User>
	{
		public UsersRepository()
		{

		}

		public void Add(User type)
		{
			throw new NotImplementedException();
		}

		public void Delete(User type)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public User GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Update(User type)
		{
			throw new NotImplementedException();
		}
	}
}
