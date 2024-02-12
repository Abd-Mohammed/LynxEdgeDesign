using System.Runtime.InteropServices.JavaScript;
using LynxEdgeDesign.Data.Models;
using Microsoft.AspNetCore.Components;

namespace LynxEdgeDesign.Pages.Profiles
{
	public partial class Profiles
	{
		// TODO: The Code is not clean, I will refactor it when The requirements are completed. 

		private Vehicle[] _vehicles =
		[
			new Vehicle(),
			new Vehicle(),
			new Vehicle()
		];


		private readonly List<Profile> _profiles = [];
		private Profile _profile = new();

		private bool _popup = false;
		private string _unit = "SEC";

		private void ShowPopup()
		{
			_popup = true;
		}

		private void ClosePopUp()
		{
			_popup = false;
		}

		private void SelectItems(int index, bool toggle)
		{
			var item = _profiles.SingleOrDefault(p => p.Id == index)!;

			if (toggle)
			{
				item.Class = item.Class == "selected" ? "" : "selected";
			}
			else
			{
				_profiles.ForEach(p =>
				{
					p.Class = "";
				});
				item.Class = "selected";
			}
		}


		private void AddProfile()
		{
			_profile.Vehicles = [.. _vehicles];
			_profiles.Add(_profile);

			ClosePopUp();
		}
	}
}
