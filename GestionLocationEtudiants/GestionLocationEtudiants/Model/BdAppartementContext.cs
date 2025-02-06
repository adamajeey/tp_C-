using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace GestionLocationEtudiants.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdAppartementContext : DbContext
    {
        public BdAppartementContext() : base("bdAppartementContext")
        {
        }

        public DbSet<Profil> profils { get; set; }

        public DbSet<Locataire> locataire { get; set; }

        public DbSet<Appartement> appartements { get; set; }


        public DbSet<Personne> personnes { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }

    }
}
