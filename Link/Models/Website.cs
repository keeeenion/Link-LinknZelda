namespace Link.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public enum Categories {
		Sotsiaalmeedia,
		Sport,
		Huumor,
		Uudised,
		Otsingumootor,
		Muu
	}

    [Table("Website")]
    public partial class Website {

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public short Id { get; set; }
		
		[StringLength(50, ErrorMessage = "Väli ei tohi ületada 50 karakterit")]
		[DisplayName("Omanik")]
		public String Owner { get; set; }

        [Required(ErrorMessage = "Väli ei tohi olla tühi")]
        [StringLength(50, ErrorMessage = "Väli ei tohi ületada 50 karakterit")]
		[DataType(DataType.Url, ErrorMessage = "Antud väli peab sisaldama URL-i")]
		[DisplayName("URL")]
		[Url(ErrorMessage = "Näide: http://foo.bar")]
		public string URL { get; set; }
		
		[DisplayName("Kirjeldus")]
		[MaxLength(250, ErrorMessage = "Väli ei tohi olla pikem kui 250 karakterit")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Väli ei tohi olla tühi")]
		[Range(1,10, ErrorMessage = "Skoor peab jääma 1 ja 10 vahele")]
		[DisplayName("Skoor")]
		public int Score { get; set; }

        [Required(ErrorMessage = "Väli ei tohi olla tühi")]
        [StringLength(50, ErrorMessage = "Väli ei tohi ületada 50 karakterit")]
		[DisplayName("Pealkiri")]
		public string Title { get; set; }

        [Required(ErrorMessage = "Väli ei tohi olla tühi")]
		[DisplayName("Kategooria")]
		public Categories? Category { get; set; }
    }
}
