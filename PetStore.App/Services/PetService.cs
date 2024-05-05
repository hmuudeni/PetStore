using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PetStore.App.Models;
using PetStore.App.Utility;
using System.Net;

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
								
				response = await httpClient.GetAsync(AppSetting.GetPetFindByStatus(findByStatus));

				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();

					if (string.IsNullOrEmpty(content))
					{
						Console.WriteLine("Response content is empty or null");
						return result;
					}

					result =  JsonConvert.DeserializeObject<List<Pet>>(content);
					return result;
				}
				else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					Console.WriteLine($"Invalid status code: {response.StatusCode}");
					return result; 
				}

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
