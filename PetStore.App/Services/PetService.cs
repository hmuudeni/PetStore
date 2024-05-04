using Microsoft.Extensions.Options;
using PetStore.App.Models;
using PetStore.App.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.App.Services
{
	public class PetService : IPetService
	{
		private readonly HttpClient httpClient;
		private string baseUrl = string.Empty;
        public PetService(HttpClient client, IOptions<ApiAccessor> options)
        {
            httpClient = client;
			baseUrl= options.Value.BaseUrl;
			httpClient.BaseAddress = new Uri(baseUrl);
        }
        public Task<List<Pet>> GetAvailablePetsAsync(string findByStatus)
		{
			throw new NotImplementedException();
		}
	}
}
