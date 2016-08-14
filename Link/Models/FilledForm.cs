using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Link.Models {
	public class FilledForm {

		public Credentials cred { get; set; }
		public Website[] websites { get; set; }

		public FilledForm(Credentials cred, Website[] websites) {
			this.cred = cred;
			this.websites = websites;
		}
	}
}