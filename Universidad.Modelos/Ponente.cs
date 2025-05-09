using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
public class Ponente
{
    [Key] public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    // Relación muchos a uno con Evento
    public int EventoId { get; set; }
    public Evento? Evento { get; set; }
}
}