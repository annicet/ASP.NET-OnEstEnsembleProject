using OnEstEnsemble.Core.Business.Model;
using OnEstEnsemble.Core.Data;
using System;
using System.Data.Entity;
using System.Configuration;

namespace OnEstEnsemble.Data
{

    // le contexte me permet de créer un objet qui va me permettre de faire le lien
    //les tables de la BD et les classes entités
    public partial class OESContext:DbContext,IOESContext
    {
        public  OESContext() :base("name=OESContext")
        {
        }

        public virtual DbSet<OES_Events> Evenements { get; set; }


        // Aide à configurer les liaisons entre les tables, comme one to one, many to one, many to many,...
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          modelBuilder.HasDefaultSchema(ConfigurationManager.AppSettings["defaultSchema"]);
        }


  }

}
