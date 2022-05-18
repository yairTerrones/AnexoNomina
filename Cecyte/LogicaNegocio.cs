using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cecyte
{
    public class LogicaNegocio
    {
        private AccesoDatos _AccesoDatos;

        public LogicaNegocio()
        {
            _AccesoDatos = new AccesoDatos();
        }

        public Puestos SaveContact(Puestos puestos)
        {
            if (puestos.Id == 0)
                _AccesoDatos.InsertContact(puestos);
            else
                _AccesoDatos.UpdateContact(puestos);

            return puestos;
        }

        public Prestacion SavePrestacion(Prestacion prestacion)
        {
            if (prestacion.Id == 0)
                _AccesoDatos.InsertPrestacion(prestacion);
            else
               _AccesoDatos.UpdatePrestacion(prestacion);

                return prestacion;
        }

        public List<Puestos> GetContacts(string searchText = null)
        {
            return _AccesoDatos.GetContacts(searchText);
        }

        public List<Prestacion> GetPrestacion(string searchText = null)
        {
            return _AccesoDatos.GetPrestacion(searchText);
        }

        public void DeleteContact(int id)
        {
            _AccesoDatos.DeleteContact(id);
        }

        public void DeletePrestacion(int id)
        {
            _AccesoDatos.DeletePrestacion(id);
        }
    }
}
