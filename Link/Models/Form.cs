using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Link.Models {
	public class Form {

		public IList<Website> Website { get; set; }
		public User User { get; set; }

		public int count { get; set; }
		public Boolean done { get; set; }
	}
}