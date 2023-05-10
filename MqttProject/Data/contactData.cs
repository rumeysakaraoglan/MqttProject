using Microsoft.EntityFrameworkCore;
using MqttProject.Models;
using System.Collections.Generic;
using static MqttProject.Models.contact;

namespace MqttProject.Data
{
    public class contactData : DbContext
    {
        public contactData(DbContextOptions options):base(options)
        {

        }

        public DbSet<ModemGorev> ModemGorevs { get; set; }
        public DbSet<contact> Contacts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Komut> Komuts { get; set; }

    }
}

 
