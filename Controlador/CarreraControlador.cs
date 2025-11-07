using Newtonsoft.Json;
using SistemaUNI.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUNI.Controlador
{
    public class CarreraControlador
    {
        private List<Carrera> listaCarrera = new List<Carrera>();

        public Boolean Agregar(string nombre, string codigo, double precio)
        {
            Boolean resultado = false;

            try
            {
                Carrera Carrera = new Carrera();
                Carrera.Nombre = nombre;
                Carrera.Codigo = codigo;
                Carrera.Precio = precio;
                listaCarrera.Add(Carrera);
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public List<Carrera> GetCarreras()
        {
            return listaCarrera;
        }
        public bool GuardarJson(string rutaArchivo)
        {
            try
            {
                var json = JsonConvert.SerializeObject(listaCarrera, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
