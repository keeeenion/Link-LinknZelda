namespace Link.Models {
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;
	using System.Data.Entity.ModelConfiguration.Conventions;

	public partial class FormDbContext : DbContext {
		public FormDbContext()
			: base("name=FormDbContext") {
			//Database.SetInitializer(new FormDbInitializer()); //Disabled in production environment
		}

		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<Website> Website { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
