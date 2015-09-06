using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	/// <summary>
	/// Use these tests to populate your developer account with sample data.
	/// Data used are from the sample Northwind database : https://northwinddatabase.codeplex.com/
	/// </summary>
	[TestClass]
	public class SampleDataCreate : TestBase
	{
		#region Suppliers

		[TestMethod]
		public void CreateSuppliers()
		{
			var suppliers = new List<Supplier>
			{
				new Supplier
				{
					Name = "Exotic Liquids",
					ContactName = "Charlotte Cooper",
					DeliveryAddress01 = "49 Gilbert St.",
					DeliveryAddress02 = "London",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "EC1 4SD",
					DeliveryAddress05 = "UK",
					Telephone = "(171) 555-2222",
					Fax = ""
				},
				new Supplier
				{
					Name = "New Orleans Cajun Delights",
					ContactName = "Shelley Burke",
					DeliveryAddress01 = "P.O. Box 78934",
					DeliveryAddress02 = "New Orleans",
					DeliveryAddress03 = "LA",
					DeliveryAddress04 = "70117",
					DeliveryAddress05 = "USA",
					Telephone = "(100) 555-4822",
					Fax = ""
				},
				new Supplier
				{
					Name = "Grandma Kelly's Homestead",
					ContactName = "Regina Murphy",
					DeliveryAddress01 = "707 Oxford Rd.",
					DeliveryAddress02 = "Ann Arbor",
					DeliveryAddress03 = "MI",
					DeliveryAddress04 = "48104",
					DeliveryAddress05 = "USA",
					Telephone = "(313) 555-5735",
					Fax = "(313) 555-3349"
				},
				new Supplier
				{
					Name = "Tokyo Traders",
					ContactName = "Yoshi Nagase",
					DeliveryAddress01 = "9-8 Sekimai Musashino-shi",
					DeliveryAddress02 = "Tokyo",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "100",
					DeliveryAddress05 = "Japan",
					Telephone = "(03) 3555-5011",
					Fax = ""
				},
				new Supplier
				{
					Name = "Cooperativa de Quesos 'Las Cabras'",
					ContactName = "Antonio del Valle Saavedra",
					DeliveryAddress01 = "Calle del Rosal 4",
					DeliveryAddress02 = "Oviedo",
					DeliveryAddress03 = "Asturias",
					DeliveryAddress04 = "33007",
					DeliveryAddress05 = "Spain",
					Telephone = "(98) 598 76 54",
					Fax = ""
				},
				new Supplier
				{
					Name = "Mayumi's",
					ContactName = "Mayumi Ohno",
					DeliveryAddress01 = "92 Setsuko Chuo-ku",
					DeliveryAddress02 = "Osaka",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "545",
					DeliveryAddress05 = "Japan",
					Telephone = "(06) 431-7877",
					Fax = ""
				},
				new Supplier
				{
					Name = "Pavlova, Ltd.",
					ContactName = "Ian Devling",
					DeliveryAddress01 = "74 Rose St. Moonie Ponds",
					DeliveryAddress02 = "Melbourne",
					DeliveryAddress03 = "Victoria",
					DeliveryAddress04 = "3058",
					DeliveryAddress05 = "Australia",
					Telephone = "(03) 444-2343",
					Fax = "(03) 444-6588"
				},
				new Supplier
				{
					Name = "Specialty Biscuits, Ltd.",
					ContactName = "Peter Wilson",
					DeliveryAddress01 = "29 King's Way",
					DeliveryAddress02 = "Manchester",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "M14 GSD",
					DeliveryAddress05 = "UK",
					Telephone = "(161) 555-4448",
					Fax = ""
				},
				new Supplier
				{
					Name = "PB Knäckebröd AB",
					ContactName = "Lars Peterson",
					DeliveryAddress01 = "Kaloadagatan 13",
					DeliveryAddress02 = "Göteborg",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "S-345 67",
					DeliveryAddress05 = "Sweden",
					Telephone = "031-987 65 43",
					Fax = "031-987 65 91"
				},
				new Supplier
				{
					Name = "Refrescos Americanas LTDA",
					ContactName = "Carlos Diaz",
					DeliveryAddress01 = "Av. das Americanas 12.890",
					DeliveryAddress02 = "Sao Paulo",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "5442",
					DeliveryAddress05 = "Brazil",
					Telephone = "(11) 555 4640",
					Fax = ""
				},
				new Supplier
				{
					Name = "Heli Süßwaren GmbH & Co. KG",
					ContactName = "Petra Winkler",
					DeliveryAddress01 = "Tiergartenstraße 5",
					DeliveryAddress02 = "Berlin",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "10785",
					DeliveryAddress05 = "Germany",
					Telephone = "(010) 9984510",
					Fax = ""
				},
				new Supplier
				{
					Name = "Plutzer Lebensmittelgroßmärkte AG",
					ContactName = "Martin Bein",
					DeliveryAddress01 = "Bogenallee 51",
					DeliveryAddress02 = "Frankfurt",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "60439",
					DeliveryAddress05 = "Germany",
					Telephone = "(069) 992755",
					Fax = ""
				},
				new Supplier
				{
					Name = "Nord-Ost-Fisch Handelsgesellschaft mbH",
					ContactName = "Sven Petersen",
					DeliveryAddress01 = "Frahmredder 112a",
					DeliveryAddress02 = "Cuxhaven",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "27478",
					DeliveryAddress05 = "Germany",
					Telephone = "(04721) 8713",
					Fax = "(04721) 8714"
				},
				new Supplier
				{
					Name = "Formaggi Fortini s.r.l.",
					ContactName = "Elio Rossi",
					DeliveryAddress01 = "Viale Dante, 75",
					DeliveryAddress02 = "Ravenna",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "48100",
					DeliveryAddress05 = "Italy",
					Telephone = "(0544) 60323",
					Fax = "(0544) 60603"
				},
				new Supplier
				{
					Name = "Norske Meierier",
					ContactName = "Beate Vileid",
					DeliveryAddress01 = "Hatlevegen 5",
					DeliveryAddress02 = "Sandvika",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "1320",
					DeliveryAddress05 = "Norway",
					Telephone = "(0)2-953010",
					Fax = ""
				},
				new Supplier
				{
					Name = "Bigfoot Breweries",
					ContactName = "Cheryl Saylor",
					DeliveryAddress01 = "3400 - 8th Avenue Suite 210",
					DeliveryAddress02 = "Bend",
					DeliveryAddress03 = "OR",
					DeliveryAddress04 = "97101",
					DeliveryAddress05 = "USA",
					Telephone = "(503) 555-9931",
					Fax = ""
				},
				new Supplier
				{
					Name = "Svensk Sjöföda AB",
					ContactName = "Michael Björn",
					DeliveryAddress01 = "Brovallavägen 231",
					DeliveryAddress02 = "Stockholm",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "S-123 45",
					DeliveryAddress05 = "Sweden",
					Telephone = "08-123 45 67",
					Fax = ""
				},
				new Supplier
				{
					Name = "Aux joyeux ecclésiastiques",
					ContactName = "Guylène Nodier",
					DeliveryAddress01 = "203, Rue des Francs-Bourgeois",
					DeliveryAddress02 = "Paris",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "75004",
					DeliveryAddress05 = "France",
					Telephone = "(1) 03.83.00.68",
					Fax = "(1) 03.83.00.62"
				},
				new Supplier
				{
					Name = "New England Seafood Cannery",
					ContactName = "Robb Merchant",
					DeliveryAddress01 = "Order Processing Dept. 2100 Paul Revere Blvd.",
					DeliveryAddress02 = "Boston",
					DeliveryAddress03 = "MA",
					DeliveryAddress04 = "2134",
					DeliveryAddress05 = "USA",
					Telephone = "(617) 555-3267",
					Fax = "(617) 555-3389"
				},
				new Supplier
				{
					Name = "Leka Trading",
					ContactName = "Chandra Leka",
					DeliveryAddress01 = "471 Serangoon Loop, Suite #402",
					DeliveryAddress02 = "Singapore",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "512",
					DeliveryAddress05 = "Singapore",
					Telephone = "555-8787",
					Fax = ""
				},
				new Supplier
				{
					Name = "Lyngbysild",
					ContactName = "Niels Petersen",
					DeliveryAddress01 = "Lyngbysild Fiskebakken 10",
					DeliveryAddress02 = "Lyngby",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "2800",
					DeliveryAddress05 = "Denmark",
					Telephone = "43844108",
					Fax = "43844115"
				},
				new Supplier
				{
					Name = "Zaanse Snoepfabriek",
					ContactName = "Dirk Luchte",
					DeliveryAddress01 = "Verkoop Rijnweg 22",
					DeliveryAddress02 = "Zaandam",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "9999 ZZ",
					DeliveryAddress05 = "Netherlands",
					Telephone = "(12345) 1212",
					Fax = "(12345) 1210"
				},
				new Supplier
				{
					Name = "Karkki Oy",
					ContactName = "Anne Heikkonen",
					DeliveryAddress01 = "Valtakatu 12",
					DeliveryAddress02 = "Lappeenranta",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "53120",
					DeliveryAddress05 = "Finland",
					Telephone = "(953) 10956",
					Fax = ""
				},
				new Supplier
				{
					Name = "G'day, Mate",
					ContactName = "Wendy Mackenzie",
					DeliveryAddress01 = "170 Prince Edward Parade Hunter's Hill",
					DeliveryAddress02 = "Sydney",
					DeliveryAddress03 = "NSW",
					DeliveryAddress04 = "2042",
					DeliveryAddress05 = "Australia",
					Telephone = "(02) 555-5914",
					Fax = "(02) 555-4873"
				},
				new Supplier
				{
					Name = "Ma Maison",
					ContactName = "Jean-Guy Lauzon",
					DeliveryAddress01 = "2960 Rue St. Laurent",
					DeliveryAddress02 = "Montréal",
					DeliveryAddress03 = "Québec",
					DeliveryAddress04 = "H1J 1C3",
					DeliveryAddress05 = "Canada",
					Telephone = "(514) 555-9022",
					Fax = ""
				},
				new Supplier
				{
					Name = "Pasta Buttini s.r.l.",
					ContactName = "Giovanni Giudici",
					DeliveryAddress01 = "Via dei Gelsomini, 153",
					DeliveryAddress02 = "Salerno",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "84100",
					DeliveryAddress05 = "Italy",
					Telephone = "(089) 6547665",
					Fax = "(089) 6547667"
				},
				new Supplier
				{
					Name = "Escargots Nouveaux",
					ContactName = "Marie Delamare",
					DeliveryAddress01 = "22, rue H. Voiron",
					DeliveryAddress02 = "Montceau",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "71300",
					DeliveryAddress05 = "France",
					Telephone = "85.57.00.07",
					Fax = ""
				},
				new Supplier
				{
					Name = "Gai pâturage",
					ContactName = "Eliane Noz",
					DeliveryAddress01 = "Bat. B 3, rue des Alpes",
					DeliveryAddress02 = "Annecy",
					DeliveryAddress03 = "",
					DeliveryAddress04 = "74000",
					DeliveryAddress05 = "France",
					Telephone = "38.76.98.06",
					Fax = "38.76.98.58"
				},
				new Supplier
				{
					Name = "Forêts d'érables",
					ContactName = "Chantal Goulet",
					DeliveryAddress01 = "148 rue Chasseur",
					DeliveryAddress02 = "Ste-Hyacinthe",
					DeliveryAddress03 = "Québec",
					DeliveryAddress04 = "J2S 7S8",
					DeliveryAddress05 = "Canada",
					Telephone = "(514) 555-2955",
					Fax = "(514) 555-2921"
				},

			};
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);

			foreach (var supplier in suppliers)
			{
				supplier.PostalAddress01 = supplier.DeliveryAddress01;
				supplier.PostalAddress02 = supplier.DeliveryAddress02;
				supplier.PostalAddress03 = supplier.DeliveryAddress03;
				supplier.PostalAddress04 = supplier.DeliveryAddress04;
				supplier.PostalAddress05 = supplier.DeliveryAddress05;
			}

			suppliers.ForEach(supplier => api.SupplierRequest.Save(supplier));
		}

		#endregion
		
		#region Items / Item Categories

		[TestMethod]
		public void CreateItemCategories()
		{
			var itemCategories = new List<ItemCategory>
			{
				new ItemCategory {Description = "Beverages"},
				new ItemCategory {Description = "Condiments"},
				new ItemCategory {Description = "Confections"},
				new ItemCategory {Description = "Dairy Products"},
				new ItemCategory {Description = "Grains/Cereals"},
				new ItemCategory {Description = "Meat/Poultry"},
				new ItemCategory {Description = "Produce"},
				new ItemCategory {Description = "Seafood"}
			};

			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			itemCategories.ForEach(cat => api.ItemCategoryRequest.Save(cat));
		}

		#endregion

	}
}
