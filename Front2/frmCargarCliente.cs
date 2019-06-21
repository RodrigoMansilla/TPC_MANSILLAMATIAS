﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Front2
{
    public partial class frmCargarCliente : Form
    {
        public frmCargarCliente()
        {
            InitializeComponent();
        }

        private void frmCargarCliente_Load(object sender, EventArgs e)
        {
            CPNegocio negocio = new CPNegocio();
            try
            {
                comboPartidos.DataSource = negocio.listarCp();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
