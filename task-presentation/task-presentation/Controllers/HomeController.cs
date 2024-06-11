using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task_presentation.Controllers
{
    public class HomeController : Controller
    {
        public void ConnectToDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoBanco"]
                                            .ConnectionString.Replace("--password--", Environment.GetEnvironmentVariable("DB_PASSWORD"));

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}