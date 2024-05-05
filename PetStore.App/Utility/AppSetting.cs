namespace PetStore.App.Utility
{
	public static class AppSetting
	{
		const string BASE_URL = "https://petstore.swagger.io/v2/";
		public static string GetBaseUrl() { return BASE_URL; }

		public static string GetPetFindByStatus(string findByStatus) 
		{
			return $"pet/findByStatus?status={Uri.EscapeDataString(findByStatus)}";
		}

	}
}
