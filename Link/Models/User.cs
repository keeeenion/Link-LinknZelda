namespace Link.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	[Table("User")]
    public partial class User {

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public short Id { get; set; }

        [Required(ErrorMessage = "Väli ei tohi olla tühi")]
        [StringLength(50, ErrorMessage = "Eesnimi ei tohi olla pikem kui 50 karakterit")]
		[DisplayName("Eesnimi")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Sisaldab keelatud karaktereid")]
		public string FirstName { get; set; }

        [Required(ErrorMessage = "Väli ei tohi olla tühi")]
        [StringLength(50, ErrorMessage = "Eesnimi ei tohi olla pikem kui 50 karakterit")]
		[DisplayName("Perekonnanimi")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Sisaldab keelatud karaktereid")]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Väli ei tohi olla tühi")]
		[DisplayName("Sünnikuupäev")]
		[Column(TypeName = "date")]
		public DateTime Birthdate { get; set; }
    }
}
