using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor : Usuario
    {
        protected string nombre;
        protected string apellido;
        protected List<Materia> materiasAsignadas;
        protected static bool cargaListado = false;

        public Profesor(string nombreUsuario, string clave) : base(nombreUsuario, clave)
        {
            materiasAsignadas = new List<Materia>();
        }

        public Profesor(string nombre, string apellido, string nombreUsuario, string clave) : this(nombreUsuario, clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;       
        }
        //public Profesor(string nombre, string apellido, Materia materiasAsignadas) : this(nombre, apellido)
        //{

        //}
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Categoría: Profesor");

            return sb.ToString();
        }

        //public void AgregarProfesorAMateria(Profesor profesor)
        //{
        //    if (profesor is not null)
        //    {
        //        if (materiasAsignadas.Count == 0)
        //        {
        //            materiasAsignadas.Add(profesor);
        //        }
        //        else
        //        {
        //            bool verificar = true;
        //            foreach (Profesor profeItem in materiasAsignadas)
        //            {

        //                if (profeItem.Legajo == profesor.Legajo)
        //                {
        //                    verificar = false;
        //                }
        //            }

        //            if (verificar == true)
        //            {
        //                materiasAsignadas.Add(profesor);
        //            }
        //        }
        //    }
        //}


        //public Profesor(string nombre, string apellido, List<Materia> materiasAsignadas) : this(nombre, apellido)
        //{
        //    this.materiasAsignadas = AgregarMaterias(materiasAsignadas);
        //}

        //private List<Materia> CargarMaterias()
        //{
        //    List<Materia> aux = new List<Materia>();
        //    foreach(Profesor profesor in ListaProfesores.GetListaProfesores)
        //    {
        //        if(profesor.Legajo == base.Legajo)
        //        {
        //            aux = profesor.MateriasAsignadas;
        //        }
        //    }
        //    return aux;
        //}

        //private void AgregarMaterias()
        //{
        //    List<Materia> listaMateriasAux = new List<Materia>();

        //    if (ListaMaterias.GetListaMateria.Count > 0)
        //    {
        //        foreach (var itemMateria in ListaMaterias.GetListaMateria)
        //        {
        //            foreach (var itemProfe in itemMateria.ListaProfesoresAsignados)
        //            {
        //                if (itemProfe.Legajo == this.Legajo)
        //                {
        //                    listaMateriasAux.Add(itemMateria);
        //                }
        //            }
        //        }
        //    }
        //    //this.materiasAsignadas = listaMateriasAux;
        //}


        //public List<Materia> AgregarMaterias(List<Materia> listaMaterias)
        //{
        //    List<Materia> listaMateriasAux = new List<Materia>();

        //    if (inicializador == 0)
        //    {
        //        if (ListaMaterias.GetListaMateria.Count < 1)
        //        {
        //            foreach (var itemMateria in ListaMaterias.GetListaMateria)
        //            {
        //                foreach (var itemProfe in itemMateria.ListaProfesoresAsignados)
        //                {
        //                    if (itemProfe.Legajo == this.Legajo)
        //                    {
        //                        listaMateriasAux.Add(itemMateria);
        //                        inicializador++;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else if(listaMaterias is not null)
        //    {
        //        foreach(var itemMateria in listaMaterias)
        //        {
        //            listaMateriasAux.Add(itemMateria);
        //            inicializador++;
        //        }  
        //    }

        //    return listaMateriasAux;
        //}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<Materia> MateriasAsignadas
        {
            get
            {
                return materiasAsignadas;
            }
            set
            {
                materiasAsignadas = value;
            }
        }
        //public void ReemplazarListaMaterias(List<Materia> nuevaLista)
        //{
        //    this.MateriasAsignadas.Clear();
        //    foreach (Materia materia in this.MateriasAsignadas)
        //    {
        //        this.MateriasAsignadas.Remove(materia);
        //    }
        //    this.MateriasAsignadas = nuevaLista;
        //}


    }
}
