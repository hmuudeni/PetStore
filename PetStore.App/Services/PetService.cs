using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PetStore.App.Models;
using PetStore.App.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        public async Task<List<Pet>> GetAvailablePetsAsync(string findByStatus)
		{
			HttpResponseMessage response;
			List<Pet> result = new List<Pet>();

			try
			{
				response = await httpClient.GetAsync($"pet/findByStatus?status={Uri.EscapeDataString(findByStatus)}");

				response.EnsureSuccessStatusCode();

				var content = await response.Content.ReadAsStringAsync();

				if (string.IsNullOrEmpty(content))
				{
					Console.WriteLine("Response content is empty or null");
					return result;
				}

				return JsonConvert.DeserializeObject<List<Pet>>(content);
			}
			catch(HttpRequestException ex)
			{
				Console.WriteLine($"HTTP request failed: {ex.Message}");
			}
			catch(JsonException ex)
			{
				Console.WriteLine($"Deserialization failed: {ex.Message}");
			}
			catch(Exception ex) 
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
			}
			return result;
			
		}
	}
}
