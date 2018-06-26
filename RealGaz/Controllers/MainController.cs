using RealGaz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealGaz.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }



        public ActionResult TopSlider()
        {
            return View();
        }

        public ActionResult WhatWeDo()
        {
            return View();
        }

        public ActionResult NavigationMenu()
        {
            return View();
        }

        public ActionResult NavigationMenuWithBackground()
        {
            return View();
        }

        public ActionResult NavigationMenuWithoutBackground()
        {
            return View();
        }

        public ActionResult Product_Details(string tag)
        {
            if (string.IsNullOrEmpty(tag))
                return HttpNotFound();

            var model = new ProductDetailViewModel();

            switch (tag)
            {
                case "oxygen":
                    model.ImageUrl = "/site/templates/images/oxy_bg.jpg";
                    model.ProductName = Resources.Translator.Products_Oxygen_Header;
                    model.Description = Resources.Translator.Products_Oxygen_Large_Content;
                    break;
                case "nitrogen":
                    model.ImageUrl = "/site/templates/images/n2_bg.jpg";
                    model.ProductName = Resources.Translator.Products_Nitrogen_Header;
                    model.Description = Resources.Translator.Products_Nitrogen_Large_Content;
                    break;
                case "argon":
                    model.ImageUrl = "/site/templates/images/ar_bg.jpg";
                    model.ProductName = Resources.Translator.Products_Argon_Header;
                    model.Description = Resources.Translator.Products_Argon_Large_Content;
                    break;
                case "carbon-dioxide":
                    model.ImageUrl = "/site/templates/images/co2_bg-1.jpg";
                    model.ProductName = Resources.Translator.Products_CarbonDioxide_Header;
                    model.Description = Resources.Translator.Products_CarbonDioxide_Large_Content;
                    break;
                case "propane":
                    model.ImageUrl = "/site/templates/images/prop_bg.jpg";
                    model.ProductName = Resources.Translator.Products_Propane_Header;
                    model.Description = Resources.Translator.Products_Propane_Large_Content;
                    break;
                case "helium":
                    model.ImageUrl = "/site/templates/images/he_bg.jpg";
                    model.ProductName = Resources.Translator.Products_Helium_Header;
                    model.Description = Resources.Translator.Products_Helium_Large_Content;
                    break;
                case "argon-carbon-dioxide":
                    model.ImageUrl = "/site/templates/images/ar_mix_bg.jpg";
                    model.ProductName = Resources.Translator.Products_ArgonCarbonDioxide_Header;
                    model.Description = Resources.Translator.Products_ArgonCarbonDioxide_Large_Content;
                    break;
                case "acetylene":
                    model.ImageUrl = "/site/templates/images/ace_bg.jpg";
                    model.ProductName = Resources.Translator.Products_Acetylene_Header;
                    model.Description = Resources.Translator.Products_Acetylene_Large_Content;
                    break;
                default:
                    return HttpNotFound();
            }

            return View(model);
        }
    }
}