using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace Link.Models {
	public class CombinedWebsite {

		[DisplayName("Omanik")]
		public String[] Owner { get; set; }
		[DisplayName("URL")]
		public string URL { get; set; }
		[DisplayName("Kirjeldus")]
		public string[] Description { get; set; }
		[DisplayName("Skoor")]
		public int Score { get; set; }
		[DisplayName("Peakiri")]
		public string[] Title { get; set; }
		[DisplayName("kategooria")]
		public Categories?[] Category { get; set; }
	}
}