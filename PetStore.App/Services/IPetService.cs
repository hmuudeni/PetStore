using PetStore.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.App.Services
{
	public interface IPetService
	{
		Task<List<Pet>> GetAvailablePetsAsync(string findByStatus);
	}
}
