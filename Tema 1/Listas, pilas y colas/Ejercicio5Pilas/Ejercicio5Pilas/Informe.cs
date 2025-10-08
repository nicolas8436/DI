using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5Pilas
{
    public class Informe
    {
        private  String[] tareas={"administrativo", "empresarial", "personal"};
        private int codigo;
        private String tarea;
        public Informe(int codigo, int indiceTarea)
        {
            this.codigo = codigo;
            this.tarea = this.tareas[indiceTarea];
        }

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public string getTarea()
        {
            return tarea;
        }
        public void setTarea(String tarea)
        {
            this.tarea = tarea;
        }

        public string[] getTareas()
        {
            return tareas;
        }


        public override string ToString()
        {
            return "El informe con codigo " + codigo + " tiene la tarea de " + tarea;
        }
    }
}
