//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kodimax_web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int id_ticket { get; set; }
        public int id_movie { get; set; }
        public int id_room { get; set; }
        public string butaca { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual Room Room { get; set; }
    }
}
