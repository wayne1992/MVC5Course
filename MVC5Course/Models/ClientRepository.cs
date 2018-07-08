using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public IQueryable<Client> SearchName(string Keyword) {

            var client = this.All();
            if (!String.IsNullOrEmpty(Keyword))
            {
                client = client.Where(p => p.FirstName.Contains(Keyword));
            }
            return client;
        }

        public Client Find(int id) {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}