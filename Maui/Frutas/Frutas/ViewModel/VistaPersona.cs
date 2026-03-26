using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Maui.Toolkit.Hosting;

namespace Frutas.ViewModel
{
    public class VistaPersona { 
    public List<Persona> ListaPersonas { get; set; }
    
        public VistaPersona() {
            ListaPersonas = new List<Persona>();
            ListaPersonas.Add(new Persona { Nombre = "Juan", altura = 1.75 });
            ListaPersonas.Add(new Persona { Nombre = "Maria", altura = 1.65 });
            ListaPersonas.Add(new Persona { Nombre = "Pedro", altura = 1.80 }); }

        
    }
}
