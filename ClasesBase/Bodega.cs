using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Bodega
    {
        private string coordenadasUbicacion;
        private string descripcion;
        private string historia;
        private string nombre;
        private int periodoActualizacion;
        private DateTime fechaUltimaActualizacion;

        public Bodega()
        {

        }
        public Bodega(string coordenadasUbicacion, string descripcion, string historia, string nombre, int periodoActualizacion, DateTime fechaUltimaActualizacion)
        {
            CoordenadasUbicacion = coordenadasUbicacion;
            Descripcion = descripcion;
            Historia = historia;
            Nombre = nombre;
            PeriodoActualizacion = periodoActualizacion;
            FechaUltimaActualizacion = fechaUltimaActualizacion;
        }

        public string CoordenadasUbicacion
        {
            get
            {
                return coordenadasUbicacion;
            }

            set
            {
                coordenadasUbicacion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Historia
        {
            get
            {
                return historia;
            }

            set
            {
                historia = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int PeriodoActualizacion
        {
            get
            {
                return periodoActualizacion;
            }

            set
            {
                periodoActualizacion = value;
            }
        }

        public DateTime FechaUltimaActualizacion
        {
            get
            {
                return fechaUltimaActualizacion;
            }

            set
            {
                fechaUltimaActualizacion = value;
            }
        }

        public bool existeActualizacionDisponibleDeVinos()
        {
            //obtiene fecha actual con la cual comparar
            DateTime fechaActual = DateTime.Now;
            //calcular cantidad de meses
            int cantMeses = ((fechaActual.Year - fechaUltimaActualizacion.Year)*12) + fechaActual.Month - fechaUltimaActualizacion.Month;
            // Ajuste adicional para considerar el día del mes
            if (fechaActual.Day < fechaUltimaActualizacion.Day)
            {
                cantMeses--;
            }
            //comparacion para saber si es elegible para la comparacion
            return cantMeses >= periodoActualizacion;
        }
    }
}