using CRUDEquipos.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDEquipos
{
    public partial class _Default : Page
    {
        private DAO d;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DAO();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            Equipo equipo = d.buscarEquipoPorId(id);
            //Equipo e = equipo;

            if (e != null)
            {
                lblMsg.Text = "Equipo encontrado";
                txtNombre.Text = equipo.nombre;
                txtEstado.Text = equipo.estado;

                txtNombre.Enabled = true;
                txtEstado.Enabled = true;
                txtId.Enabled = false;

                btnBuscar.Enabled = false;
                btnActualizar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCrear.Enabled = false;
            }
            else
            {
                lblMsg.Text = "Equipo no encontrada..";
                txtNombre.Enabled = true;
                txtEstado.Enabled = true;
                txtId.Enabled = false;

                btnBuscar.Enabled = false;
                btnActualizar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCrear.Enabled = true;
            }

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();

            equipo.nombre = txtNombre.Text;
            equipo.estado = txtEstado.Text;
            equipo.id = Convert.ToInt32(txtId.Text);

            d.crearEquipo(equipo);

            volverNormalidad();
            lblMsg.Text = "Equipo creado!!!";

            ActualizarEquipo();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();

            
            equipo.nombre = txtNombre.Text;
            equipo.estado = txtEstado.Text;
            equipo.id = Convert.ToInt32(txtId.Text);

            d.actualizarEquipo(equipo);

            volverNormalidad();
            lblMsg.Text = "Equipo actualizado";
            ActualizarEquipo();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            d.excluirEquipo(id);

            volverNormalidad();
            lblMsg.Text = "Equipo excluido";
            ActualizarEquipo();
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            volverNormalidad();
        }

        private void volverNormalidad()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";

            btnBuscar.Enabled = true;
            btnActualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCrear.Enabled = false;

            txtId.Enabled = true;
            txtNombre.Enabled = false;
            txtEstado.Enabled = false;
            txtId.Focus();

            lblMsg.Text = "...";
        }

        private void ActualizarEquipo()
        {
            dsEquipos.DataBind();
            tablaEquipos.DataBind();
        }

    }
}