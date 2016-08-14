using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Link.Models {
	public class Website {

		public String owner { get; set; }
		public String title { get; set; }
		public String desc { get; set; }
		public String url { get; set; }
		public String cat { get; set; }
		public int score { get; set; }

		public Website(String owner, String title, String desc, String url, String cat, int score) {
			this.owner = owner;
			this.title = title;
			this.desc = desc;
			this.url = url;
			this.cat = cat;
			this.score = score;
		}
	}
}