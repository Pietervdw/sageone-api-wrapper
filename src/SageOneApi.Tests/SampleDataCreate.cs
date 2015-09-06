using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
				new Supplier{Name = "Exotic Liquids",ContactName = "Charlotte Cooper",DeliveryAddress01 = "49 Gilbert St.",DeliveryAddress02 = "London",DeliveryAddress03 = "",DeliveryAddress04 = "EC1 4SD",DeliveryAddress05 = "UK",Telephone = "(171) 555-2222",Fax = ""},
				new Supplier{Name = "New Orleans Cajun Delights",ContactName = "Shelley Burke",DeliveryAddress01 = "P.O. Box 78934",DeliveryAddress02 = "New Orleans",DeliveryAddress03 = "LA",DeliveryAddress04 = "70117",DeliveryAddress05 = "USA",Telephone = "(100) 555-4822",Fax = ""},
				new Supplier{Name = "Grandma Kelly's Homestead",ContactName = "Regina Murphy",DeliveryAddress01 = "707 Oxford Rd.",DeliveryAddress02 = "Ann Arbor",DeliveryAddress03 = "MI",DeliveryAddress04 = "48104",DeliveryAddress05 = "USA",Telephone = "(313) 555-5735",Fax = "(313) 555-3349"},
				new Supplier{Name = "Tokyo Traders",ContactName = "Yoshi Nagase",DeliveryAddress01 = "9-8 Sekimai Musashino-shi",DeliveryAddress02 = "Tokyo",DeliveryAddress03 = "",DeliveryAddress04 = "100",DeliveryAddress05 = "Japan",Telephone = "(03) 3555-5011",Fax = ""},
				new Supplier{Name = "Cooperativa de Quesos 'Las Cabras'",ContactName = "Antonio del Valle Saavedra",DeliveryAddress01 = "Calle del Rosal 4",DeliveryAddress02 = "Oviedo",DeliveryAddress03 = "Asturias",DeliveryAddress04 = "33007",DeliveryAddress05 = "Spain",Telephone = "(98) 598 76 54",Fax = ""},
				new Supplier{Name = "Mayumi's",ContactName = "Mayumi Ohno",DeliveryAddress01 = "92 Setsuko Chuo-ku",DeliveryAddress02 = "Osaka",DeliveryAddress03 = "",DeliveryAddress04 = "545",DeliveryAddress05 = "Japan",Telephone = "(06) 431-7877",Fax = ""},
				new Supplier{Name = "Pavlova, Ltd.",ContactName = "Ian Devling",DeliveryAddress01 = "74 Rose St. Moonie Ponds",DeliveryAddress02 = "Melbourne",DeliveryAddress03 = "Victoria",DeliveryAddress04 = "3058",DeliveryAddress05 = "Australia",Telephone = "(03) 444-2343",Fax = "(03) 444-6588"},
				new Supplier{Name = "Specialty Biscuits, Ltd.",ContactName = "Peter Wilson",DeliveryAddress01 = "29 King's Way",DeliveryAddress02 = "Manchester",DeliveryAddress03 = "",DeliveryAddress04 = "M14 GSD",DeliveryAddress05 = "UK",Telephone = "(161) 555-4448",Fax = ""},
				new Supplier{Name = "PB Knäckebröd AB",ContactName = "Lars Peterson",DeliveryAddress01 = "Kaloadagatan 13",DeliveryAddress02 = "Göteborg",DeliveryAddress03 = "",DeliveryAddress04 = "S-345 67",DeliveryAddress05 = "Sweden",Telephone = "031-987 65 43",Fax = "031-987 65 91"},
				new Supplier{Name = "Refrescos Americanas LTDA",ContactName = "Carlos Diaz",DeliveryAddress01 = "Av. das Americanas 12.890",DeliveryAddress02 = "Sao Paulo",DeliveryAddress03 = "",DeliveryAddress04 = "5442",DeliveryAddress05 = "Brazil",Telephone = "(11) 555 4640",Fax = ""},
				new Supplier{Name = "Heli Süßwaren GmbH & Co. KG",ContactName = "Petra Winkler",DeliveryAddress01 = "Tiergartenstraße 5",DeliveryAddress02 = "Berlin",DeliveryAddress03 = "",DeliveryAddress04 = "10785",DeliveryAddress05 = "Germany",Telephone = "(010) 9984510",Fax = ""},
				new Supplier{Name = "Plutzer Lebensmittelgroßmärkte AG",ContactName = "Martin Bein",DeliveryAddress01 = "Bogenallee 51",DeliveryAddress02 = "Frankfurt",DeliveryAddress03 = "",DeliveryAddress04 = "60439",DeliveryAddress05 = "Germany",Telephone = "(069) 992755",Fax = ""},
				new Supplier{Name = "Nord-Ost-Fisch Handelsgesellschaft mbH",ContactName = "Sven Petersen",DeliveryAddress01 = "Frahmredder 112a",DeliveryAddress02 = "Cuxhaven",DeliveryAddress03 = "",DeliveryAddress04 = "27478",DeliveryAddress05 = "Germany",Telephone = "(04721) 8713",Fax = "(04721) 8714"},
				new Supplier{Name = "Formaggi Fortini s.r.l.",ContactName = "Elio Rossi",DeliveryAddress01 = "Viale Dante, 75",DeliveryAddress02 = "Ravenna",DeliveryAddress03 = "",DeliveryAddress04 = "48100",DeliveryAddress05 = "Italy",Telephone = "(0544) 60323",Fax = "(0544) 60603"},
				new Supplier{Name = "Norske Meierier",ContactName = "Beate Vileid",DeliveryAddress01 = "Hatlevegen 5",DeliveryAddress02 = "Sandvika",DeliveryAddress03 = "",DeliveryAddress04 = "1320",DeliveryAddress05 = "Norway",Telephone = "(0)2-953010",Fax = ""},
				new Supplier{Name = "Bigfoot Breweries",ContactName = "Cheryl Saylor",DeliveryAddress01 = "3400 - 8th Avenue Suite 210",DeliveryAddress02 = "Bend",DeliveryAddress03 = "OR",DeliveryAddress04 = "97101",DeliveryAddress05 = "USA",Telephone = "(503) 555-9931",Fax = ""},
				new Supplier{Name = "Svensk Sjöföda AB",ContactName = "Michael Björn",DeliveryAddress01 = "Brovallavägen 231",DeliveryAddress02 = "Stockholm",DeliveryAddress03 = "",DeliveryAddress04 = "S-123 45",DeliveryAddress05 = "Sweden",Telephone = "08-123 45 67",Fax = ""},
				new Supplier{Name = "Aux joyeux ecclésiastiques",ContactName = "Guylène Nodier",DeliveryAddress01 = "203, Rue des Francs-Bourgeois",DeliveryAddress02 = "Paris",DeliveryAddress03 = "",DeliveryAddress04 = "75004",DeliveryAddress05 = "France",Telephone = "(1) 03.83.00.68",Fax = "(1) 03.83.00.62"},
				new Supplier{Name = "New England Seafood Cannery",ContactName = "Robb Merchant",DeliveryAddress01 = "Order Processing Dept. 2100 Paul Revere Blvd.",DeliveryAddress02 = "Boston",DeliveryAddress03 = "MA",DeliveryAddress04 = "2134",DeliveryAddress05 = "USA",Telephone = "(617) 555-3267",Fax = "(617) 555-3389"},
				new Supplier{Name = "Leka Trading",ContactName = "Chandra Leka",DeliveryAddress01 = "471 Serangoon Loop, Suite #402",DeliveryAddress02 = "Singapore",DeliveryAddress03 = "",DeliveryAddress04 = "512",DeliveryAddress05 = "Singapore",Telephone = "555-8787",Fax = ""},
				new Supplier{Name = "Lyngbysild",ContactName = "Niels Petersen",DeliveryAddress01 = "Lyngbysild Fiskebakken 10",DeliveryAddress02 = "Lyngby",DeliveryAddress03 = "",DeliveryAddress04 = "2800",DeliveryAddress05 = "Denmark",Telephone = "43844108",Fax = "43844115"},
				new Supplier{Name = "Zaanse Snoepfabriek",ContactName = "Dirk Luchte",DeliveryAddress01 = "Verkoop Rijnweg 22",DeliveryAddress02 = "Zaandam",DeliveryAddress03 = "",DeliveryAddress04 = "9999 ZZ",DeliveryAddress05 = "Netherlands",Telephone = "(12345) 1212",Fax = "(12345) 1210"},
				new Supplier{Name = "Karkki Oy",ContactName = "Anne Heikkonen",DeliveryAddress01 = "Valtakatu 12",DeliveryAddress02 = "Lappeenranta",DeliveryAddress03 = "",DeliveryAddress04 = "53120",DeliveryAddress05 = "Finland",Telephone = "(953) 10956",Fax = ""},
				new Supplier{Name = "G'day, Mate",ContactName = "Wendy Mackenzie",DeliveryAddress01 = "170 Prince Edward Parade Hunter's Hill",DeliveryAddress02 = "Sydney",DeliveryAddress03 = "NSW",DeliveryAddress04 = "2042",DeliveryAddress05 = "Australia",Telephone = "(02) 555-5914",Fax = "(02) 555-4873"},
				new Supplier{Name = "Ma Maison",ContactName = "Jean-Guy Lauzon",DeliveryAddress01 = "2960 Rue St. Laurent",DeliveryAddress02 = "Montréal",DeliveryAddress03 = "Québec",DeliveryAddress04 = "H1J 1C3",DeliveryAddress05 = "Canada",Telephone = "(514) 555-9022",Fax = ""},
				new Supplier{Name = "Pasta Buttini s.r.l.",ContactName = "Giovanni Giudici",DeliveryAddress01 = "Via dei Gelsomini, 153",DeliveryAddress02 = "Salerno",DeliveryAddress03 = "",DeliveryAddress04 = "84100",DeliveryAddress05 = "Italy",Telephone = "(089) 6547665",Fax = "(089) 6547667"},
				new Supplier{Name = "Escargots Nouveaux",ContactName = "Marie Delamare",DeliveryAddress01 = "22, rue H. Voiron",DeliveryAddress02 = "Montceau",DeliveryAddress03 = "",DeliveryAddress04 = "71300",DeliveryAddress05 = "France",Telephone = "85.57.00.07",Fax = ""},
				new Supplier{Name = "Gai pâturage",ContactName = "Eliane Noz",DeliveryAddress01 = "Bat. B 3, rue des Alpes",DeliveryAddress02 = "Annecy",DeliveryAddress03 = "",DeliveryAddress04 = "74000",DeliveryAddress05 = "France",Telephone = "38.76.98.06",Fax = "38.76.98.58"},
				new Supplier{Name = "Forêts d'érables",ContactName = "Chantal Goulet",DeliveryAddress01 = "148 rue Chasseur",DeliveryAddress02 = "Ste-Hyacinthe",DeliveryAddress03 = "Québec",DeliveryAddress04 = "J2S 7S8",DeliveryAddress05 = "Canada",Telephone = "(514) 555-2955",Fax = "(514) 555-2921"}
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

		#region Item Categories

		[TestMethod]
		public void CreateItemCategories()
		{
			var itemCategories = new List<Category>
			{
				new Category { Description = "Beverages" },
				new Category { Description = "Condiments" },
				new Category { Description = "Confections" },
				new Category { Description = "Dairy Products" },
				new Category { Description = "Grains/Cereals" },
				new Category { Description = "Meat/Poultry" },
				new Category { Description = "Produce" },
				new Category { Description = "Seafood" }
			};

			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			itemCategories.ForEach(cat => api.ItemCategoryRequest.Save(cat));
		}

		#endregion
		
		#region Items

		[TestMethod]
		public void CreateItems()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);

			var categories = api.ItemCategoryRequest.Get().Results;
			var beverages = categories.Find(r => r.Description == "Beverages");
			var condiments = categories.Find(r => r.Description == "Condiments");
			var confections = categories.Find(r => r.Description == "Confections");
			var dairyProducts = categories.Find(r => r.Description == "Dairy Products");
			var grainsCereals = categories.Find(r => r.Description == "Grains/Cereals");
			var meatPoultry = categories.Find(r => r.Description == "Meat/Poultry");
			var produce = categories.Find(r => r.Description == "Produce");
			var seafood = categories.Find(r => r.Description == "Seafood");

			var items = new List<Item>
			{
				new Item { Code = "Chai", Description = "Chai - 10 boxes x 20 bags",PriceInclusive  = 180,PriceExclusive = 180, QuantityOnHand = 39, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Chang", Description = "Chang - 24 - 12 oz bottles",PriceInclusive  = 190,PriceExclusive = 190, QuantityOnHand = 17, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Aniseed Syrup", Description = "Aniseed Syrup - 12 - 550 ml bottles",PriceInclusive  = 100,PriceExclusive = 100, QuantityOnHand = 13, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Chef Anton's Cajun Seasoning", Description = "Chef Anton's Cajun Seasoning - 48 - 6 oz jars",PriceInclusive  = 220,PriceExclusive = 220, QuantityOnHand = 53, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Chef Anton's Gumbo Mix", Description = "Chef Anton's Gumbo Mix - 36 boxes",PriceInclusive  = 213.5m,PriceExclusive = 213.5m, QuantityOnHand = 0, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Grandma's Boysenberry Spread", Description = "Grandma's Boysenberry Spread - 12 - 8 oz jars",PriceInclusive  = 250,PriceExclusive = 250, QuantityOnHand = 120, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Uncle Bob's Organic Dried Pears", Description = "Uncle Bob's Organic Dried Pears - 12 - 1 lb pkgs.",PriceInclusive  = 300,PriceExclusive = 300, QuantityOnHand = 15, Category = produce, Active = true, Physical = true},
				new Item { Code = "Northwoods Cranberry Sauce", Description = "Northwoods Cranberry Sauce - 12 - 12 oz jars",PriceInclusive  = 400,PriceExclusive = 400, QuantityOnHand = 6, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Mishi Kobe Niku", Description = "Mishi Kobe Niku - 18 - 500 g pkgs.",PriceInclusive  = 970,PriceExclusive = 970, QuantityOnHand = 29, Category = meatPoultry, Active = true, Physical = true},
				new Item { Code = "Ikura", Description = "Ikura - 12 - 200 ml jars",PriceInclusive  = 310,PriceExclusive = 310, QuantityOnHand = 31, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Queso Cabrales", Description = "Queso Cabrales - 1 kg pkg.",PriceInclusive  = 210,PriceExclusive = 210, QuantityOnHand = 22, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Queso Manchego La Pastora", Description = "Queso Manchego La Pastora - 10 - 500 g pkgs.",PriceInclusive  = 380,PriceExclusive = 380, QuantityOnHand = 86, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Konbu", Description = "Konbu - 2 kg box",PriceInclusive  = 60,PriceExclusive = 60, QuantityOnHand = 24, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Tofu", Description = "Tofu - 40 - 100 g pkgs.",PriceInclusive  = 232.5m,PriceExclusive = 232.5m, QuantityOnHand = 35, Category = produce, Active = true, Physical = true},
				new Item { Code = "Genen Shouyu", Description = "Genen Shouyu - 24 - 250 ml bottles",PriceInclusive  = 155,PriceExclusive = 155, QuantityOnHand = 39, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Pavlova", Description = "Pavlova - 32 - 500 g boxes",PriceInclusive  = 174.5m,PriceExclusive = 174.5m, QuantityOnHand = 29, Category = confections, Active = true, Physical = true},
				new Item { Code = "Alice Mutton", Description = "Alice Mutton - 20 - 1 kg tins",PriceInclusive  = 390,PriceExclusive = 390, QuantityOnHand = 0, Category = meatPoultry, Active = true, Physical = true},
				new Item { Code = "Carnarvon Tigers", Description = "Carnarvon Tigers - 16 kg pkg.",PriceInclusive  = 625,PriceExclusive = 625, QuantityOnHand = 42, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Teatime Chocolate Biscuits", Description = "Teatime Chocolate Biscuits - 10 boxes x 12 pieces",PriceInclusive  = 92,PriceExclusive = 92, QuantityOnHand = 25, Category = confections, Active = true, Physical = true},
				new Item { Code = "Sir Rodney's Marmalade", Description = "Sir Rodney's Marmalade - 30 gift boxes",PriceInclusive  = 810,PriceExclusive = 810, QuantityOnHand = 40, Category = confections, Active = true, Physical = true},
				new Item { Code = "Sir Rodney's Scones", Description = "Sir Rodney's Scones - 24 pkgs. x 4 pieces",PriceInclusive  = 100,PriceExclusive = 100, QuantityOnHand = 3, Category = confections, Active = true, Physical = true},
				new Item { Code = "Gustaf's Knäckebröd", Description = "Gustaf's Knäckebröd - 24 - 500 g pkgs.",PriceInclusive  = 210,PriceExclusive = 210, QuantityOnHand = 104, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Tunnbröd", Description = "Tunnbröd - 12 - 250 g pkgs.",PriceInclusive  = 90,PriceExclusive = 90, QuantityOnHand = 61, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Guaraná Fantástica", Description = "Guaraná Fantástica - 12 - 355 ml cans",PriceInclusive  = 45,PriceExclusive = 45, QuantityOnHand = 20, Category = beverages, Active = true, Physical = true},
				new Item { Code = "NuNuCa Nuß-Nougat-Creme", Description = "NuNuCa Nuß-Nougat-Creme - 20 - 450 g glasses",PriceInclusive  = 140,PriceExclusive = 140, QuantityOnHand = 76, Category = confections, Active = true, Physical = true},
				new Item { Code = "Gumbär Gummibärchen", Description = "Gumbär Gummibärchen - 100 - 250 g bags",PriceInclusive  = 312.3m,PriceExclusive = 312.3m, QuantityOnHand = 15, Category = confections, Active = true, Physical = true},
				new Item { Code = "Schoggi Schokolade", Description = "Schoggi Schokolade - 100 - 100 g pieces",PriceInclusive  = 439,PriceExclusive = 439, QuantityOnHand = 49, Category = confections, Active = true, Physical = true},
				new Item { Code = "Rössle Sauerkraut", Description = "Rössle Sauerkraut - 25 - 825 g cans",PriceInclusive  = 456,PriceExclusive = 456, QuantityOnHand = 26, Category = produce, Active = true, Physical = true},
				new Item { Code = "Thüringer Rostbratwurst", Description = "Thüringer Rostbratwurst - 50 bags x 30 sausgs.",PriceInclusive  = 1237.9m,PriceExclusive = 1237.9m, QuantityOnHand = 0, Category = meatPoultry, Active = true, Physical = true},
				new Item { Code = "Nord-Ost Matjeshering", Description = "Nord-Ost Matjeshering - 10 - 200 g glasses",PriceInclusive  = 258.9m,PriceExclusive = 258.9m, QuantityOnHand = 10, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Gorgonzola Telino", Description = "Gorgonzola Telino - 12 - 100 g pkgs",PriceInclusive  = 125,PriceExclusive = 125, QuantityOnHand = 0, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Mascarpone Fabioli", Description = "Mascarpone Fabioli - 24 - 200 g pkgs.",PriceInclusive  = 320,PriceExclusive = 320, QuantityOnHand = 9, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Geitost", Description = "Geitost - 500 g",PriceInclusive  = 25,PriceExclusive = 25, QuantityOnHand = 112, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Sasquatch Ale", Description = "Sasquatch Ale - 24 - 12 oz bottles",PriceInclusive  = 140,PriceExclusive = 140, QuantityOnHand = 111, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Steeleye Stout", Description = "Steeleye Stout - 24 - 12 oz bottles",PriceInclusive  = 180,PriceExclusive = 180, QuantityOnHand = 20, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Inlagd Sill", Description = "Inlagd Sill - 24 - 250 g  jars",PriceInclusive  = 190,PriceExclusive = 190, QuantityOnHand = 112, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Gravad lax", Description = "Gravad lax - 12 - 500 g pkgs.",PriceInclusive  = 260,PriceExclusive = 260, QuantityOnHand = 11, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Côte de Blaye", Description = "Côte de Blaye - 12 - 75 cl bottles",PriceInclusive  = 2635,PriceExclusive = 2635, QuantityOnHand = 17, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Chartreuse verte", Description = "Chartreuse verte - 750 cc per bottle",PriceInclusive  = 180,PriceExclusive = 180, QuantityOnHand = 69, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Boston Crab Meat", Description = "Boston Crab Meat - 24 - 4 oz tins",PriceInclusive  = 184,PriceExclusive = 184, QuantityOnHand = 123, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Jack's New England Clam Chowder", Description = "Jack's New England Clam Chowder - 12 - 12 oz cans",PriceInclusive  = 96.5m,PriceExclusive = 96.5m, QuantityOnHand = 85, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Singaporean Hokkien Fried Mee", Description = "Singaporean Hokkien Fried Mee - 32 - 1 kg pkgs.",PriceInclusive  = 140,PriceExclusive = 140, QuantityOnHand = 26, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Ipoh Coffee", Description = "Ipoh Coffee - 16 - 500 g tins",PriceInclusive  = 460,PriceExclusive = 460, QuantityOnHand = 17, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Gula Malacca", Description = "Gula Malacca - 20 - 2 kg bags",PriceInclusive  = 194.5m,PriceExclusive = 194.5m, QuantityOnHand = 27, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Rogede sild", Description = "Rogede sild - 1k pkg.",PriceInclusive  = 95,PriceExclusive = 95, QuantityOnHand = 5, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Spegesild", Description = "Spegesild - 4 - 450 g glasses",PriceInclusive  = 120,PriceExclusive = 120, QuantityOnHand = 95, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Zaanse koeken", Description = "Zaanse koeken - 10 - 4 oz boxes",PriceInclusive  = 95,PriceExclusive = 95, QuantityOnHand = 36, Category = confections, Active = true, Physical = true},
				new Item { Code = "Chocolade", Description = "Chocolade - 10 pkgs.",PriceInclusive  = 127.5m,PriceExclusive = 127.5m, QuantityOnHand = 15, Category = confections, Active = true, Physical = true},
				new Item { Code = "Maxilaku", Description = "Maxilaku - 24 - 50 g pkgs.",PriceInclusive  = 200,PriceExclusive = 200, QuantityOnHand = 10, Category = confections, Active = true, Physical = true},
				new Item { Code = "Valkoinen suklaa", Description = "Valkoinen suklaa - 12 - 100 g bars",PriceInclusive  = 162.5m,PriceExclusive = 162.5m, QuantityOnHand = 65, Category = confections, Active = true, Physical = true},
				new Item { Code = "Manjimup Dried Apples", Description = "Manjimup Dried Apples - 50 - 300 g pkgs.",PriceInclusive  = 530,PriceExclusive = 530, QuantityOnHand = 20, Category = produce, Active = true, Physical = true},
				new Item { Code = "Filo Mix", Description = "Filo Mix - 16 - 2 kg boxes",PriceInclusive  = 70,PriceExclusive = 70, QuantityOnHand = 38, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Perth Pasties", Description = "Perth Pasties - 48 pieces",PriceInclusive  = 328,PriceExclusive = 328, QuantityOnHand = 0, Category = meatPoultry, Active = true, Physical = true},
				new Item { Code = "Tourtière", Description = "Tourtière - 16 pies",PriceInclusive  = 74.5m,PriceExclusive = 74.5m, QuantityOnHand = 21, Category = meatPoultry, Active = true, Physical = true},
				new Item { Code = "Pâté chinois", Description = "Pâté chinois - 24 boxes x 2 pies",PriceInclusive  = 240,PriceExclusive = 240, QuantityOnHand = 115, Category = meatPoultry, Active = true, Physical = true},
				new Item { Code = "Gnocchi di nonna Alice", Description = "Gnocchi di nonna Alice - 24 - 250 g pkgs.",PriceInclusive  = 380,PriceExclusive = 380, QuantityOnHand = 21, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Ravioli Angelo", Description = "Ravioli Angelo - 24 - 250 g pkgs.",PriceInclusive  = 195,PriceExclusive = 195, QuantityOnHand = 36, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Escargots de Bourgogne", Description = "Escargots de Bourgogne - 24 pieces",PriceInclusive  = 132.5m,PriceExclusive = 132.5m, QuantityOnHand = 62, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Raclette Courdavault", Description = "Raclette Courdavault - 5 kg pkg.",PriceInclusive  = 550,PriceExclusive = 550, QuantityOnHand = 79, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Camembert Pierrot", Description = "Camembert Pierrot - 15 - 300 g rounds",PriceInclusive  = 340,PriceExclusive = 340, QuantityOnHand = 19, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Sirop d'érable", Description = "Sirop d'érable - 24 - 500 ml bottles",PriceInclusive  = 285,PriceExclusive = 285, QuantityOnHand = 113, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Tarte au sucre", Description = "Tarte au sucre - 48 pies",PriceInclusive  = 493,PriceExclusive = 493, QuantityOnHand = 17, Category = confections, Active = true, Physical = true},
				new Item { Code = "Vegie-spread", Description = "Vegie-spread - 15 - 625 g jars",PriceInclusive  = 439,PriceExclusive = 439, QuantityOnHand = 24, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Wimmers gute Semmelknödel", Description = "Wimmers gute Semmelknödel - 20 bags x 4 pieces",PriceInclusive  = 332.5m,PriceExclusive = 332.5m, QuantityOnHand = 22, Category = grainsCereals, Active = true, Physical = true},
				new Item { Code = "Louisiana Fiery Hot Pepper Sauce", Description = "Louisiana Fiery Hot Pepper Sauce - 32 - 8 oz bottles",PriceInclusive  = 210.5m,PriceExclusive = 210.5m, QuantityOnHand = 76, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Louisiana Hot Spiced Okra", Description = "Louisiana Hot Spiced Okra - 24 - 8 oz jars",PriceInclusive  = 170,PriceExclusive = 170, QuantityOnHand = 4, Category = condiments, Active = true, Physical = true},
				new Item { Code = "Laughing Lumberjack Lager", Description = "Laughing Lumberjack Lager - 24 - 12 oz bottles",PriceInclusive  = 140,PriceExclusive = 140, QuantityOnHand = 52, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Scottish Longbreads", Description = "Scottish Longbreads - 10 boxes x 8 pieces",PriceInclusive  = 125,PriceExclusive = 125, QuantityOnHand = 6, Category = confections, Active = true, Physical = true},
				new Item { Code = "Gudbrandsdalsost", Description = "Gudbrandsdalsost - 10 kg pkg.",PriceInclusive  = 360,PriceExclusive = 360, QuantityOnHand = 26, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Outback Lager", Description = "Outback Lager - 24 - 355 ml bottles",PriceInclusive  = 150,PriceExclusive = 150, QuantityOnHand = 15, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Flotemysost", Description = "Flotemysost - 10 - 500 g pkgs.",PriceInclusive  = 215,PriceExclusive = 215, QuantityOnHand = 26, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Mozzarella di Giovanni", Description = "Mozzarella di Giovanni - 24 - 200 g pkgs.",PriceInclusive  = 348,PriceExclusive = 348, QuantityOnHand = 14, Category = dairyProducts, Active = true, Physical = true},
				new Item { Code = "Röd Kaviar", Description = "Röd Kaviar - 24 - 150 g jars",PriceInclusive  = 150,PriceExclusive = 150, QuantityOnHand = 101, Category = seafood, Active = true, Physical = true},
				new Item { Code = "Longlife Tofu", Description = "Longlife Tofu - 5 kg pkg.",PriceInclusive  = 100,PriceExclusive = 100, QuantityOnHand = 4, Category = produce, Active = true, Physical = true},
				new Item { Code = "Rhönbräu Klosterbier", Description = "Rhönbräu Klosterbier - 24 - 0.5 l bottles",PriceInclusive  = 77.5m,PriceExclusive = 77.5m, QuantityOnHand = 125, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Lakkalikööri", Description = "Lakkalikööri - 500 ml",PriceInclusive  = 180,PriceExclusive = 180, QuantityOnHand = 57, Category = beverages, Active = true, Physical = true},
				new Item { Code = "Original Frankfurter grüne Soße", Description = "Original Frankfurter grüne Soße - 12 boxes",PriceInclusive  = 130,PriceExclusive = 130, QuantityOnHand = 32, Category = condiments, Active = true, Physical = true}
			};

			items.ForEach(item => api.ItemRequest.Save(item));
		}

		#endregion

		#endregion

	}
}
