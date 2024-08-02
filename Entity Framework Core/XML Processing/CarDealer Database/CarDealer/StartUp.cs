using AutoMapper.QueryableExtensions;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Invoices.Utilities;
using Microsoft.EntityFrameworkCore;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine(GetSalesWithAppliedDiscount(new CarDealerContext()));
        }


        //Problem 9
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlHelper xmlHelper = new XmlHelper();
            ImportSuppliersDto[] suppliersDtos =
                xmlHelper.Deserialize<ImportSuppliersDto[]>(inputXml, "Suppliers");

            List<Supplier> suppliers = new List<Supplier>();

            foreach (var dto in suppliersDtos)
            {
                //all the data will be valid

                Supplier supplier = new Supplier()
                {
                    IsImporter = dto.IsImporter,
                    Name = dto.Name
                };

                suppliers.Add(supplier);
            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();
            return $"Successfully imported {suppliers.Count}";

        }



        //Problem 10
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlHelper xmlHelper = new XmlHelper();
            ImportPartsDto[] partsDtos = xmlHelper.Deserialize<ImportPartsDto[]>(inputXml, "Parts");
            List<Part> parts = new List<Part>();

            foreach (ImportPartsDto partDto in partsDtos)
            {
                if (!context.Suppliers.Any(s => s.Id == partDto.SupplierId))
                {
                    continue;
                }

                //all the data will be valid

                Part part = new Part()
                {
                    Name = partDto.Name,
                    Price = partDto.Price,
                    Quantity = partDto.Quantity,
                    SupplierId = partDto.SupplierId
                };

                parts.Add(part);
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }



        //Problem 11
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlHelper xmlHelper = new XmlHelper();
            ImportCarsDto[] carsDtos = xmlHelper.Deserialize<ImportCarsDto[]>(inputXml, "Cars");
            List<Car> cars = new List<Car>();

            foreach (ImportCarsDto carDto in carsDtos)
            {
                //all the data will be valid

                Car car = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TraveledDistance = carDto.TraveledDistance,
                };


                foreach (ImportPartsForCarsDto partDto in carDto.Parts.DistinctBy(p => p.Id))
                {
                    if (!context.Parts.Any(p => p.Id == partDto.Id))
                    {
                        continue;
                    }

                    PartCar partCar = new PartCar()
                    {
                        PartId = partDto.Id,
                        CarId = car.Id
                    };

                    car.PartsCars.Add(partCar);
                }

                cars.Add(car);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }



        //Problem 12
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlHelper xmlHelper = new XmlHelper();
            ImportCustomersDto[] customersDtos = xmlHelper.Deserialize<ImportCustomersDto[]>(inputXml, "Customers");
            List<Customer> customers = new List<Customer>();

            foreach (var customerDto in customersDtos)
            {
                //all the data will be valid

                Customer customer = new Customer()
                {
                    Name = customerDto.Name,
                    BirthDate = DateTime.Parse(customerDto.BirthDate),
                    IsYoungDriver = customerDto.IsYoungDriver
                };

                customers.Add(customer);
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();
            return $"Successfully imported {customers.Count}";
        }




        //Problem 13
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlHelper xmlHelper = new XmlHelper();
            ImportSalesDto[] salesDtos = xmlHelper.Deserialize<ImportSalesDto[]>(inputXml, "Sales");
            List<Sale> sales = new List<Sale>();

            foreach (var saleDto in salesDtos)
            {
                if (!context.Cars.Any(c => c.Id == saleDto.CarId))
                {
                    continue;
                }

                //all the data will be valid

                Sale sale = new Sale()
                {
                    CarId = saleDto.CarId,
                    CustomerId = saleDto.CustomerId,
                    Discount = saleDto.Discount
                };

                sales.Add(sale);
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();
            return $"Successfully imported {sales.Count}";
        }



        //Problem 14
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            ExportCarsWithDistanceDto[] cars = context.Cars
                .Select(c => new ExportCarsWithDistanceDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .Where(c => c.TraveledDistance > 2_000_000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ToArray();

            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize(cars, "cars");
        }



        //Problem 15
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            ExportBMWCarsDto[] cars = context.Cars
                .Where(c => c.Make == "BMW")
                .Select(c => new ExportBMWCarsDto()
                {
                    Id = c.Id,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .ToArray();

            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize(cars, "cars");
        }



        //Problem 16
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new ExportLocalSuppliersDto()
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize(suppliers, "suppliers");
        }



        //Problem 17
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .Select(c => new ExportCarsWithListOfParts()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars
                        .OrderByDescending(p => p.Part.Price)
                        .Select(pc => new ExportPartsDto()
                        {
                            Name = pc.Part.Name,
                            Price = pc.Part.Price,
                        }).ToArray()
                })
                .ToArray();

            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize(cars, "cars");
        }


        //Problem 18
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var temp = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SalesInfo = c.Sales.Select(s => new
                    {
                        Prices = c.IsYoungDriver
                            ? s.Car.PartsCars.Sum(pc => Math.Round((double)pc.Part.Price * 0.95, 2))
                            : s.Car.PartsCars.Sum(pc => (double)pc.Part.Price)
                    }).ToArray()
                }).ToArray();

            var customerSalesInfo = temp
                .OrderByDescending(x =>
                    x.SalesInfo.Sum(y => y.Prices))
                .Select(a => new ExportTotalSalesByCustomers()
                {
                    FullName = a.FullName,
                    BoughtCars = a.BoughtCars,
                    SpentMoney = a.SalesInfo.Sum(b => (decimal)b.Prices)
                })
                .ToArray();

            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize(customerSalesInfo, "customers");
        }




        //Problem 19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new ExportSalesWithDiscountDto()
                {
                    Car = new CarDto()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    Discount = (int)s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartsCars
                        .Sum(pc => pc.Part.Price),
                    PriceWithDiscount = Math.Round(
                        (double)(s.Car.PartsCars.Sum(p => p.Part.Price)
                                 * (1 - (s.Discount / 100))), 4)
                })
                .ToArray();

            XmlHelper xmlHelper = new XmlHelper();
            return xmlHelper.Serialize(sales, "sales");

        }

    }
}