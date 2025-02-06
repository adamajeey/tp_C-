using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestionLocationEtudiants.Model
{
    public class Profil
    {
        [Key]
        public int IdProfil { get; set; }
        [Required, MaxLength(50)]

        public string libelleProfil { get; set; }
    }
}
