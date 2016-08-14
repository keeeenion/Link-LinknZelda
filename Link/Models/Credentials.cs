using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Link.Models {
	public class Credentials {

		public String firstname { get; set; }
		public String surname { get; set; }
		public Date birthdate { get; set; }

		public Credentials(String firstname, String surname, Date birthdate) {
			this.firstname = firstname;
			this.surname = surname;
			this.birthdate = birthdate;
		}
	}
}