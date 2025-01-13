using Bunit;
using ServiceRecordFrontend.Components.Records;
using ServiceRecordFrontend.Models;

namespace Tests
{
    public class RecordListtest : TestContext
    {
        [Fact]
        public void RecordListShouldDisplayRecords()
        {
            var records = new List<ServiceRecordFrontend.Models.Record>
            {
                new()
                {
                    Id = new Guid("1a869396-f637-4ac1-86e6-894a76554a93"),
                    Owner = "Christian Hopf",
                    Date = DateTime.Parse("2025-01-07T20:15:07.251035Z"),
                    Make = "Audi",
                    Model = "A4",
                    Year = 1999,
                    VIN = "ABCDEFGHIJKLMNOPQ",
                    License = "DBZ171",
                    Mileage = 160000,
                    Service = "Alignment",
                    Charge = 85.00,
                },
                new()
                {
                    Id = new Guid("a8e96233-1efa-4e56-85a8-9a3cbd91a2d3"),
                    Owner = "Eric Seiffert",
                    Date = DateTime.Parse("2025-01-07T20:19:08.736053Z"),
                    Make = "Volkswagen",
                    Model = "Golf GTI",
                    Year = 2017,
                    VIN = "JKLMNOPQRSTUVWXYZ",
                    License = "ABC123",
                    Mileage = 65000,
                    Service = "Oil change",
                    Charge = 92.00,
                },
            };
            var comp = RenderComponent<RecordList>(parameters =>
                parameters.Add(p => p.Records, records)
            );

            Assert.Contains("ABCDEFGHIJKLMNOPQ", comp.Markup);
            Assert.Contains("Audi", comp.Markup);
            Assert.Contains("A4", comp.Markup);
            Assert.Contains("1999", comp.Markup);
            Assert.Contains("Christian Hopf", comp.Markup);
            Assert.Contains("JKLMNOPQRSTUVWXYZ", comp.Markup);
            Assert.Contains("Volkswagen", comp.Markup);
            Assert.Contains("Golf GTI", comp.Markup);
            Assert.Contains("2017", comp.Markup);
            Assert.Contains("Eric Seiffert", comp.Markup);
        }
    }
}
