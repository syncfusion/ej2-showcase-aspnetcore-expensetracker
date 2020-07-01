using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.startDate = new DateTime(2017, 05, 31);
            ViewBag.endDate = new DateTime(2017, 11, 30);
            return View();
        }
        [HttpGet]
        public PartialViewResult Dashboard()
        {
            ViewBag.startDate = new DateTime(2017, 05, 31);
            ViewBag.endDate = new DateTime(2017, 11, 30);
            ViewBag.dataLabel = new
            {
                name = "x",
                visible = true,
                position = "Outside",
                connectorStyle = new { length = "10%" },
                font = new
                {
                    color = "Black",
                    size = "14px",
                    fontFamily = "Roboto"
                }
            };
            AccumulationChartAnimation animation = new AccumulationChartAnimation();
            animation.Enable = false;
            ViewBag.animation = animation;
            ViewBag.palettes = new string[] { "#61EFCD", "#CDDE1F", "#FEC200", "#CA765A", "#2485FA", "#F57D7D", "#C152D2",
                    "#8854D9", "#3D4EB8", "#00BCD7" };
            ViewBag.legentSettings = new
            {
                visible = true
            };
            ViewBag.chartarea = new ChartBorder
            {
                Width = 0
            };
            ViewBag.content = "<p style='font-family:Roboto;font-size: 16px;font-weight: 400;font-weight: 400;letter-spacing: 0.02em;line-height: 16px;color: #797979 !important;'>Account - Balance</p>";
            ViewBag.border = new ChartBorder { Width = 0.5, Color = "#0470D8" };
            ViewBag.margin = new ChartMargin { Top = 90 };
            ViewBag.accBalancecontent = "<p style='font-family:Roboto;font-size: 16px;font-weight: 400;font-weight: 400;letter-spacing: 0.02em;line-height: 16px;color: #797979 !important;'>Income - Expense</p>";
            ViewBag.accBalanceborder = new ChartBorder { Width = 0.5, Color = "#A16EE5" };
            ViewBag.gridToolbar = new object[] { new { text = "Recent Transactions" } };
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult Expense()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult About()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult Dialog()
        {
            return PartialView();
        }
    }
}