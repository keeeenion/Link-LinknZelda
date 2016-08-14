using Link.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Link.Controllers {
	public class FormController : Controller {
		[HttpPost]
		public ActionResult Add(FormCollection form) {

			string message = "";

			Credentials c = new Credentials(form["firstname"], form["surname"], new Date(Convert.ToDateTime(form["birthdate" + ""]).Date));
			Website[] w = new Website[10];

			Boolean hit = false;
			for (int x = 10; x>=1; x--) {
				if (form["owner-"+x].Length > 0 &
					form["title-" + x].Length > 0 &
					form["desc-" + x].Length > 0 &
					form["url-" + x].Length > 0 &
					form["cat-" + x].Length > 0 &
					form["score-" + x].Length > 0) {
					if (!hit) {
						hit = true;
						w = new Website[x];
					} else {

					}
				} else {
					if (hit) { message += "<li>" + "Paar veebilehe vormi on täitmata." + "</li>"; }
				}
			}

			if (message.Length > 0) { return Content("<h1Miskit juhtus!<h1><h3>Paar välja jäi täitmata.</h3><br><ul>" + message + "</ul>"); }

			FilledForm fform = new FilledForm(c, w);
			return Content("<h1>Hurraa! Tehtud.<h1>");
		}
	}
}