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

        [HttpGet]
        public ActionResult BuscarOrden()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IngresarOrden(string OrderNumber)
        {
            using (EtiquetasProduccionContext db = new EtiquetasProduccionContext())
            {
                var orden = db.Order_.Where(x => x.OrderNumber == OrderNumber).ToList();
                return View(orden);
            }
        }

        [HttpPost]
        public ActionResult GenerarFolio(IEnumerable<Lineas> data)
        {
            using (EtiquetasProduccionContext db = new EtiquetasProduccionContext())
            {
                DateTime now = DateTime.Now;
                Folio folio = new Folio();
                Line_Made lineaHechas = new Line_Made();
                Order_ orden = new Order_();
                folio.OrderNumber = data.First().OrderNumber;
                folio.Date_ = now;
                db.Folio.Add(folio);
                db.SaveChanges();
                foreach (var item in data)
                {
                    lineaHechas.Folio = folio.Id;
                    lineaHechas.OrderNumber = item.OrderNumber;
                    lineaHechas.Height = item.Height;
                    lineaHechas.Width = item.Width;
                    lineaHechas.Line_ = item.Line;
                    lineaHechas.Pcs_Order = item.Pcs_Order;
                    lineaHechas.Pcs_Box = item.Input;
                    orden.Pcs_Box = item.Input;
                    db.Line_Made.Add(lineaHechas);
                    db.SaveChanges();
                }
                return View();
            }
        }
    }
    public class Lineas
    {
        public string OrderNumber { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Line { get; set; }
        public int Pcs_Order { get; set; }
        public int Input { get; set; }
    }
}