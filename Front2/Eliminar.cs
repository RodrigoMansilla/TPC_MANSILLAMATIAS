﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

// EL CODIGO DEL FORMULARIO PARA ELIMINAR PRODUCTOS 

namespace Front2
{
    public partial class Eliminar : Form
    {
        private Producto ProductoLocal = null;

        public Eliminar()
        {
            InitializeComponent();
        }


        public Eliminar(Producto producto) //creo constructor
        {
            InitializeComponent();
            ProductoLocal = producto;
        }

        // CIERRO LA VENTANA Y CANCELO LA OPERACION

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // ACEPT0 LA ELIMINACION.

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            negocio.EliminarProducto(ProductoLocal);
            Visible = false; // aca oculto el form(ELIMINAR) una vez que elijo la opcion 
            
        }
    }
}
