﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para PantallaImportadorDeVinos.xaml
    /// </summary>
    public partial class PantallaImportadorDeVinos : UserControl
    {
        private CollectionViewSource vistaColeccionFiltrada;
        public PantallaImportadorDeVinos()
        {
            InitializeComponent();
            vistaColeccionFiltrada = Resources["VISTA_BODEGA"] as CollectionViewSource;
        }
    }
}
