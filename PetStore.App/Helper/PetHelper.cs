using PetStore.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.App.Helper
{
	public static class PetHelper
	{
		public static void PrintGroupAndSortPets(List<Pet> pets)
		{
			// Order pets by category name 

			var sortedPets = pets
				.OrderBy(pet => pet.Category?.Name ?? "Unknown")
				.ThenByDescending(p => p.Name);

			// Output to console
			Console.WriteLine("Available pets sorted by category and displayed in reverse order by name:");
			Console.WriteLine("---------------------------------------------------------------------------");
			foreach (var pet in sortedPets)
			{
				string categoryName = pet.Category?.Name ?? "No Category";
				Console.WriteLine($"Category: {categoryName}, Pet Name: {pet.Name}");
			}

		}
	}
}
