using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Link.Models;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Link.Controllers {
	public class HomeController : Controller {

		[HttpGet]
		public ActionResult Form() {
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Form(Form f) {
			ViewBag.count = f.count;
			if (f.done) {
				return Save(f);
			} else {
				return Form();
			}
		}

		[HttpGet]
		public ActionResult Save() {
			return Form();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Save(Form f) {

			FormDbContext db = new FormDbContext();
			List<String> errors = new List<string>();

			if (!(ModelState.IsValid)) {
				ViewBag.feedback = "Miskit läks viltu!";
				ViewBag.feedbackStyle = "color: red;";
				return Form();
			}

			// Websites count check
			if (f.Website.Count < 5 || f.Website.Count > 10) { errors.Insert(errors.Count+1, "Veebilehtede arv peab jääma 1 ja 10 vahele"); }
			// User existing exception check
			var query = db.User.Where(q => q.FirstName.ToLower() == f.User.FirstName.ToLower() &&
										   q.SurName.ToLower() == f.User.SurName.ToLower() &&
										   q.Birthdate == f.User.Birthdate);
			if (query.Count() != 0) { errors.Insert(errors.Count, "Selline kasutaja on juba enda lehed lisanud"); }
			// Website URL unique validation
			List<String> links = new List<string>();
			List<String> duplicates = new List<string>();
			foreach (var y in f.Website) {
				if (y.URL != null) {
					var host = new Uri(y.URL).Host.ToString();
					if (links.Contains(host) & !(duplicates.Contains(host))) {
						errors.Insert(errors.Count, "Domeen: '" + host + "' kordub");
						duplicates.Insert(duplicates.Count, host);
					} else {
						links.Insert(links.Count, host);
					}
				}
			}

			// Only take this path if no errors occure
			if (errors.Count == 0) {

				db.User.Add(new User {
					FirstName = f.User.FirstName,
					SurName = f.User.SurName,
					Birthdate = f.User.Birthdate
				});

				foreach (var x in f.Website) {
					var host = new Uri(x.URL).Host.ToString();
					db.Website.Add(new Website {
						Title = x.Title,
						Owner = x.Owner,
						URL = "http://"+host, // uri://domain.TLD
						Description = x.Description,
						Score = x.Score,
						Category = x.Category
					});
				}

				db.SaveChanges();
				ModelState.Clear(); // clearing form inputs
				ViewBag.feedback = "Super! Veebilehed on lisatud";
				ViewBag.feedbackStyle = "color: green;";
				return Form();
			} else {
				ViewBag.feedback = "Miskit läks viltu!";
				ViewBag.feedbackStyle = "color: red;";
				ViewBag.feedbackErrors = errors;
				return Form();
			}
		}

		public ActionResult Display() {
			/*return View(DeserializeXml(WebRequest.Create("http://localhost:56642/api/display")
				.GetResponse().GetResponseStream().ToString(), typeof(CombinedWebsite)));*/

			List<CombinedWebsite> output = JsonConvert.DeserializeObject<List<CombinedWebsite>>(
					new WebClient().DownloadString("http://localhost:56642/api/display")
				);
			return View(output);
		}
	}
}