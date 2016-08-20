using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Link.Models {
	public class FormDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FormDbContext> {

		protected override void Seed(FormDbContext context) {
			var users = new List<User> {
			new User{FirstName="Bruce",SurName="Wayne",Birthdate=DateTime.Parse("2005-09-01")},
			new User{FirstName="Clark",SurName="Kent",Birthdate=DateTime.Parse("2002-09-01")},
			new User{FirstName="Lois",SurName="Lane",Birthdate=DateTime.Parse("2003-09-01")},
			new User{FirstName="Lex",SurName="Luther",Birthdate=DateTime.Parse("2002-09-01")},
			new User{FirstName="Super",SurName="Mario",Birthdate=DateTime.Parse("2002-09-01")},
			new User{FirstName="Princess",SurName="Zelda",Birthdate=DateTime.Parse("2001-09-01")},
			new User{FirstName="Max",SurName="Payne",Birthdate=DateTime.Parse("2003-09-01")},
			new User{FirstName="Killer",SurName="Keemstar",Birthdate=DateTime.Parse("2005-09-01")}
			};

			users.ForEach(u => context.User.Add(u));
			context.SaveChanges();

			var websites = new List<Website> {
			new Website{Title="Facebook",Owner="Facebook Corp.",URL="http://facebook.com",
				Description="Sotisaalmeedia",Score=9,Category=Categories.Sotsiaalmeedia},
			new Website{Title="Google",Owner="Google Corp.",URL="http://google.com",
				Description="Number üks otsingu mootor maailmas",Score=9,Category=Categories.Otsingumootor},
			new Website{Title="Yahoo",Owner="eraisik",URL="http://yahoo.com",
				Description="Kuulus leht",Score=5,Category=Categories.Uudised},
			new Website{Title="Facebook",Owner="eraisik",URL="http://bing.com",
				Description="Parim otsingumootor leitav interneti avarustest",Score=3,Category=Categories.Sport},
			new Website{Title="Keeeenioni veebileht",Owner="eraisik",URL="http://keeeenion.me",
				Description="",Score=7,Category=Categories.Muu},
			new Website{Title="Facebook",Owner="eraisik",URL="http://rate.ee",
				Description="Keegi vv-d tahab?",Score=5,Category=Categories.Sport},
			new Website{Title="Testing",Owner="Example Co",URL="http://foo.bar",
				Description="Väga mugavate lahendustega veebikeskond",Score=7,Category=Categories.Huumor},
			new Website{Title="Facebook",Owner="Facebook Corp.",URL="http://facebook.com",
				Description="Sotsiaalmeedia nii noortele kui vanadele",Score=3,Category=Categories.Sport},
			new Website{Title="Facebook",Owner="Keeeenion",URL="http://keeeenion.me",
				Description="Suvakas",Score=3,Category=Categories.Muu},
			new Website{Title="Facebook",Owner="Facebook Corp.",URL="http://keeeenion.me",
				Description="Kvaliteet leht",Score=3,Category=Categories.Sport},
			new Website{Title="Facebook",Owner="Facebook Corp.",URL="http://facebook.com",
				Description="",Score=3,Category=Categories.Sport},
			new Website{Title="Facebook",Owner="eraisik",URL="http://google.com",
				Description="",Score=7,Category=Categories.Muu},
			new Website{Title="Facebook",Owner="eraisik",URL="http://rate.ee",
				Description="Unustatud sollid",Score=5,Category=Categories.Sport},
			new Website{Title="Foo.Bar",Owner="Exmaple Co",URL="http://foo.bar",
				Description="",Score=7,Category=Categories.Huumor},
			new Website{Title="Facebook",Owner="eraisik",URL="http://facebook.com",
				Description="Spam platform",Score=3,Category=Categories.Sport},
			new Website{Title="Facebook",Owner="eraisik",URL="http://bing.com",
				Description="",Score=3,Category=Categories.Muu},
			new Website{Title="Facebook",Owner="eraisik",URL="http://yahoo.com",
				Description="Mailiteenus",Score=3,Category=Categories.Sport},
			new Website{Title="Facebook",Owner="eraisik",URL="http://facebook.com",
				Description="Sotsiaalmeeida number yks",Score=3,Category=Categories.Sport},
			new Website{Title="Google",Owner="eraisik",URL="http://google.com",
				Description="",Score=7,Category=Categories.Muu},
			new Website{Title="Rate",Owner="Rate OU",URL="http://rate.ee",
				Description="Eestlaste facebook",Score=5,Category=Categories.Sport},
			new Website{Title="Example",Owner="Foo",URL="http://foo.bar",
				Description="Test",Score=7,Category=Categories.Huumor},
			new Website{Title="Google",Owner="eraisik",URL="http://google.com",
				Description="",Score=7,Category=Categories.Muu},
			new Website{Title="Rate",Owner="Dunno",URL="http://rate.ee",
				Description="Eestlaste facebook",Score=5,Category=Categories.Sport},
			new Website{Title="Example",Owner="Foo",URL="http://foo.bar",
				Description="Test",Score=7,Category=Categories.Huumor}
			};

			websites.ForEach(w => context.Website.Add(w));
			context.SaveChanges();
		}

	}
}