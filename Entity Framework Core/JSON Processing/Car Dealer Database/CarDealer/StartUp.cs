using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            string jsonText = File.ReadAllText("../../../Datasets/sales.json");

            Console.WriteLine(GetCarsWithTheirListOfParts(context));
        }



        //Problem 9
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            List<Supplier>? suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);
            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}.";
        }




        //Problem 10
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            List<Part>? parts = JsonConvert.DeserializeObject<List<Part>>(inputJson);

            List<int> validSuppliersIds = context.Suppliers
                .Select(s => s.Id)
                .ToList();

            List<Part> partsWithValidSuppliersIds = parts
                .Where(p => validSuppliersIds.Contains(p.SupplierId))
                .ToList();

            context.Parts.AddRange(partsWithValidSuppliersIds);
            context.SaveChanges();

            return $"Successfully imported {partsWithValidSuppliersIds.Count}.";
        }




        //Problem 11
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            List<CarDTO> carsDTOs = JsonConvert.DeserializeObject<List<CarDTO>>(inputJson);

            HashSet<Car> cars = new HashSet<Car>();
            HashSet<PartCar> partsCars = new HashSet<PartCar>();

            foreach (var carDTO in carsDTOs)
            {
                Car newCar = new Car()
                {
                    Make = carDTO.Make,
                    Model = carDTO.Model,
                    TraveledDistance = carDTO.TraveledDistance
                };

                cars.Add(newCar);

                foreach (var partId in carDTO.PartsId.Distinct())
                {
                    partsCars.Add(new PartCar()
                    {
                        Car = newCar,
                        PartId = partId
                    });
                }
            }

            context.Cars.AddRange(cars);
            context.PartsCars.AddRange(partsCars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }




        //Problem 12
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(inputJson);
            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}.";
        }



        //Problem 13
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            List<Sale> sales = JsonConvert.DeserializeObject<List<Sale>>(inputJson);
            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";
        }




        //Problem 14
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
                    c.IsYoungDriver
                })
                .ToList();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }




        //Problem 15
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .Select(c => new { c.Id, c.Make, c.Model, c.TraveledDistance })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .ToList();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }





        //Problem 16
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => !s.IsImporter)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }





        //Problem 17
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        c.Make,
                        c.Model,
                        c.TraveledDistance
                    },

                    parts = c.PartsCars
                        .Select(p => new
                        {
                            p.Part.Name,
                            Price = $"{p.Part.Price:f2}"
                        })
                })
                .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }





        //Problem 18
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customersSales = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count(),
                    salePrices = c.Sales.SelectMany(s => s.Car.PartsCars.Select(pc => pc.Part.Price))
                })
                .ToArray();

            var totalSales = customersSales
                .Select(t => new
                {
                    fullName = t.fullName,
                    boughtCars = t.boughtCars,
                    spentMoney = t.salePrices.Sum()
                })
                .OrderByDescending(t => t.spentMoney)
                .ThenByDescending(t => t.boughtCars)
                .ToArray();

            return JsonConvert.SerializeObject(totalSales, Formatting.Indented);
        }




        //Problem 19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Take(10)
                .Select(s=>new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    customerName = s.Customer.Name,
                    discount = $"{s.Discount:f2}",
                    price = $"{s.Car.PartsCars.Sum(pc => pc.Part.Price):f2}",
                    priceWithDiscount = $"{s.Car.PartsCars.Sum(pc => pc.Part.Price) * (1-s.Discount/100):f2}"
                })
                .ToArray();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }
    }
}