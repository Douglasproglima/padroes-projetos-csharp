using System.Collections.Generic;
using System.Web.Mvc;

namespace FactoryMethod
{
    public sealed class FactoryController : Controller
    {
        public ActionResult Manually()
        {
            var car = new Car();
            var truck = new Truck();
            var bus = new Bus();

            var transports = new List<ITransport>();
            transports.Add(car);
            transports.Add(truck);
            transports.Add(bus);

            foreach (var transport in transports)
                transport.Build();

            return Content("Fábrica Manual");
        }

        public ActionResult Dinamically()
        {
            var types = new List<string>() { "Carro", "Caminhão", "Onibus" };
            var transports = new List<ITransport>();
            types.ForEach(x => transports.Add(TransportFactory.CreateInstance(x)));

            foreach (var transport in transports)
                transport.Build();

            return Content("Fábrica Dinâmica");
        }
    }

}