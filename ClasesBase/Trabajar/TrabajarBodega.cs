using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ClasesBase.Trabajar
{
    public class TrabajarBodega
    {
        public ObservableCollection<Bodega> TraerBodegas()
        {
            ObservableCollection<Bodega> listaBodegas = new ObservableCollection<Bodega>();

            listaBodegas.Add(new Bodega("41.387015, 2.169918", "Bodega familiar fundada en 1985, especializada en la producción de vinos tintos de alta calidad", "La Vendimia se ha destacado por su tradición vitivinícola centenaria y su compromiso con la sostenibilidad", "Bodega La Vendimia", 1, new DateTime(2024, 5,10)));
            listaBodegas.Add(new Bodega("38.722252, -9.139337", "Moderna bodega ubicada en el Valle del Duero, conocida por sus vinos blancos frescos y afrutados", "Del Valle se fundó en 1998 y ha ganado reconocimiento internacional por sus técnicas innovadoras de vinificación", "Bodega Del Valle", 2, new DateTime(2024, 3, 30)));
            listaBodegas.Add(new Bodega("-33.437830, -70.650449", "Bodega boutique con viñedos en la Cordillera de los Andes, especializada en vinos de autor", "Los Viñedos nació en 2003 de la pasión de un enólogo por crear vinos únicos que reflejen su terruño", "Bodega Los Viñedos", 3, new DateTime(2024, 1, 20)));
            listaBodegas.Add(new Bodega("38.923806, -1.425586", "Bodega histórica fundada en 1880, reconocida por sus vinos envejecidos en barricas de roble centenario", "El Roble Centenario es un emblema en la región por su legado enológico y la calidad de sus vinos añejos", "Bodega El Roble Centenario", 4, new DateTime(2024, 2,25)));
            return listaBodegas;
        }
    }
}
