using EtiquetasProduccion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EtiquetasProduccion.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet]
        public ActionResult CrearOrden()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearOrden(
            string OrderNumber,
            float Height,
            float Width,
            int Line,
            int PcsOrder,
            string Address,
            string Customer
        )
        {
            using (EtiquetasProduccionContext db = new EtiquetasProduccionContext())
            {
                Order_ orden = new Order_();
                orden.OrderNumber = OrderNumber;
                orden.Height = Height;
                orden.Width = Width;
                orden.Line_ = Line;
                orden.Pcs_Order = PcsOrder;
                orden.Address_ = Address;
                orden.Customer = Customer;
                orden.Pcs_Box = 0;
                orden.Status_ = "Open";
                db.Order_.Add(orden);
                db.SaveChanges();
                return View();
            }
        }

        [HttpGet]
        public ActionResult VerOrdenes()
        {
            using (EtiquetasProduccionContext db = new EtiquetasProduccionContext())
            {
                var ordenes = db.Order_.OrderBy(x => x.OrderNumber).ToList();
                return View(ordenes);
            }
        }
    }
}