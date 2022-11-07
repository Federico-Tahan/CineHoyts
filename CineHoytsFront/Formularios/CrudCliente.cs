using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine_Hoyts.Datos;
using Cine_Hoyts.Dominio;
using CineHoytsBack.DataApi.Interfaces;
using Cine_Hoyts.Datos.Implementacion;
using CineHoytsBack.Datos.Implementacion;
using CineHoytsBack.Dominio;
using Newtonsoft.Json;
using CineHoytsFront.Servicio;

namespace Cine_Hoyts.Formularios
{
    public partial class CrudCliente : Form
    {

        List<Cliente> clientes = new List<Cliente>();
        Cliente clienteselect;


        public CrudCliente()
        {
            InitializeComponent();
            pnlCrud.Visible = false;
            this.toolTip1.SetToolTip(this.picdesplegar, "Ocultar detalle");

        }

        private async Task cargar_provincia()
        {
            string url = "https://localhost:7271/api/Tablas/GetProvincia";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Provincia> lst = JsonConvert.DeserializeObject<List<Provincia>>(data);
            cboProv.DataSource = lst;
            cboProv.ValueMember = "codigo_provincia";
            cboProv.DisplayMember = "nombre_provincia";
            cboProv.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProv.SelectedIndex = -1;
        }
        private async Task Cargar_Localidad(Parametro pm)
        {
            string url = "https://localhost:7271/api/Tablas/GetLocalidad";
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            var data = await ClaseSingleton.GetInstance().PostAsync(url,FiltrosJson);
            List<Localidad> lst =  JsonConvert.DeserializeObject<List<Localidad>>(data);
            CboLocalidad.DataSource = lst;
            CboLocalidad.ValueMember = "codigo_localidad";
            CboLocalidad.DisplayMember = "nombre_localidad";
            CboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            CboLocalidad.SelectedIndex = -1;
        }
        private async Task Cargar_barrio(int p)
        {
            string url = "https://localhost:7271/api/Tablas/GetBarrio?p=" + p.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Barrio> lst = JsonConvert.DeserializeObject<List<Barrio>>(data);
            CboBarrio.DataSource = lst;
            CboBarrio.ValueMember = "codigo_barrio";
            CboBarrio.DisplayMember = "nombre_barrio";
            CboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            CboBarrio.SelectedIndex = -1;
        }
        private async void CrudCliente_Load(object sender, EventArgs e)
        {
            limpiar();
            await cargar_provincia();
            habilitar_todo_btn(true);
            btnMod.Enabled = false;
            BtnGuardar.Enabled = false;
            btnBorrar.Enabled = false;
            await CargarComboAsyncTipoDoc();
            await cargar_Clientes();
            CargarDgv();
        }
        private async Task CargarComboAsyncTipoDoc()
        {
            string url = "https://localhost:7271/api/Tablas/GetDocumentos";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<TipoDoc> lst = JsonConvert.DeserializeObject<List<TipoDoc>>(data);
            cboTipoDoc.DataSource = lst;
            cboTipoDoc.ValueMember = "IdTipoDoc";
            cboTipoDoc.DisplayMember = "TipoDocumento";
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.SelectedIndex = -1;

        }
        private void picdesplegar_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = false;
            habilitar_todo_btn(true);
            btnMod.Enabled = false;
            BtnGuardar.Enabled = false;
            btnBorrar.Enabled = false;
            limpiar();

        }
        private void picLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txbDireccion.Clear();
            txbDocumento.Clear();
            txbNombre.Clear();
            TxbApellido.Clear();
            dtpFechaNac.Value = DateTime.Now;
            numDireccion.Value = 0;
            rbtMasculino.Checked = true;
            clienteselect = new Cliente();
            txbNro_cliente.Clear();
            cboProv.SelectedIndex = -1;
            CboLocalidad.SelectedIndex = -1;
            CboBarrio.SelectedIndex = -1;

        }
        private void abstraer_cliente(Cliente c)
        {
            Persona p = new Persona();
            p.Nombre = txbNombre.Text;
            p.Apellido = TxbApellido.Text;
            p.Id_tipo_documento = cboTipoDoc.SelectedIndex + 1;
            p.id_barrio = Convert.ToInt32(CboBarrio.SelectedValue);
            p.Nro_Documento = Convert.ToInt64(txbDocumento.Text);
            if (rbtFemenino.Checked)
            {
                p.Sexo = 0;
            }
            else
            {
                p.Sexo = 1;
            }
            p.Direccion = txbDireccion.Text;
            p.Fecha_Nac = dtpFechaNac.Value.ToShortDateString();
            p.Nro_Direccion = Convert.ToInt32(numDireccion.Value);
            c.per = p;

        }
        private void CargarDgv()
        {
            dgvCliente.Rows.Clear();
            if (clientes is null)
            {
            }
            else
            {
                foreach (Cliente client in clientes)
                {
                    string sex = " ";
                    if (client.per.Sexo == 1)
                    {
                        sex = "Masculino";
                    }
                    else
                    {
                        sex = "Femenino";

                    }
                    try
                    {
                        dgvCliente.Rows.Add(client.Id_Cliente.ToString(), client.per.Nombre + " " + client.per.Apellido, client.per.Nro_Documento.ToString(),
                        client.per.Tipo_doc, client.per.Direccion + " " + client.per.Nro_Direccion, client.per.Fecha_Nac, sex);
                    }
                    catch (Exception)
                    {

                    }

                }
            }         
        }
        private async void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await cargar_provincia();
            clienteselect = new Cliente();
            clienteselect.Id_Cliente = clientes[dgvCliente.CurrentRow.Index].Id_Cliente;
            clienteselect.per = clientes[dgvCliente.CurrentRow.Index].per;
            clienteselect.per.id_barrio = clientes[dgvCliente.CurrentRow.Index].per.id_barrio;


            txbNro_cliente.Text = clienteselect.Id_Cliente.ToString();
            txbNombre.Text = clienteselect.per.Nombre;
            TxbApellido.Text = clienteselect.per.Apellido;
            txbDireccion.Text = clienteselect.per.Direccion;
            txbDocumento.Text = clienteselect.per.Nro_Documento.ToString();
            numDireccion.Value = clienteselect.per.Nro_Direccion;
            cboTipoDoc.SelectedValue = clienteselect.per.Id_tipo_documento;
            dtpFechaNac.Value = Convert.ToDateTime(clienteselect.per.Fecha_Nac);
            cboProv.SelectedValue = clienteselect.per.id_provincia;

            await Cargar_Localidad(new Parametro("@id_provincia", clienteselect.per.id_provincia));

            CboLocalidad.SelectedValue = clienteselect.per.id_localidad;
            await Cargar_barrio(clienteselect.per.id_localidad);

            CboBarrio.SelectedValue = clienteselect.per.id_barrio;
            if (CboBarrio.Text == "")
            {
                await Cargar_barrio(clienteselect.per.id_localidad);

                CboBarrio.SelectedValue = clienteselect.per.id_barrio;
            }

            if (clienteselect.per.Sexo == 0)
            {
                rbtFemenino.Checked = true;
            }
            else
            {
                rbtMasculino.Checked = true;
            }

            pnlCrud.Visible = true;
            picLimpiar.Visible = false;
            habilitar_todo_btn(false);
            btnMod.Enabled = true;
            btnBorrar.Enabled = true;

            habilitar_todo_campo(false);
        }
        private bool validar_campos()
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show("Debe cargar el nombre del cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txbNombre.Focus();
                return false;
            }
            else if (TxbApellido.Text == "")
            {
                MessageBox.Show("Debe cargar el apellido del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxbApellido.Focus();
                return false;
            }
            else if (rbtFemenino.Checked == false && rbtMasculino.Checked == false)
            {
                MessageBox.Show("Debe cargar el sexo del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtMasculino.Focus();
                return false;
            }
            else if (txbDireccion.Text == "")
            {
                MessageBox.Show("Debe cargar la direccion del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDireccion.Focus();
                return false;
            }
            else if (numDireccion.Value == 0)
            {
                MessageBox.Show("Debe cargar el numero de direccion del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numDireccion.Focus();
                return false;
            }
            else if (txbDocumento.Text == "")
            {
                MessageBox.Show("Debe cargar el documento del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDocumento.Focus();
                return false;
            }
            else if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el tipo de documento del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoDoc.Focus();
                return false;
            }
            else if (dtpFechaNac.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Debe cargar la fecha de nacimiento del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNac.Focus();
                return false;
            }

            try
            {
                Convert.ToInt64(txbDocumento.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Debe cargar un documento valido para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDocumento.Focus();
                return false;
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = false;
            limpiar();
        }
        /*HABILITAR Y DESHABILITAR CAMPOS Y BOTONES*/
        private void habilitar_todo_campo(bool a)
        {
            txbDireccion.Enabled = a;
            txbDocumento.Enabled = a;
            txbNombre.Enabled = a;
            TxbApellido.Enabled = a;
            cboProv.Enabled = a;
            cboTipoDoc.Enabled = a;
            CboBarrio.Enabled = a;
            CboLocalidad.Enabled = a;
            dtpFechaNac.Enabled = a;
            rbtFemenino.Enabled = a;
            rbtMasculino.Enabled = a;
            numDireccion.Enabled = a;
        }
        private void habilitar_todo_btn(bool a)
        {
            btnNuevo.Enabled = a;
            btnMod.Enabled = a;
            btnBorrar.Enabled = a;
            BtnGuardar.Enabled = a;
        }
        public void hab_localidad(bool v)
        {
            cboProv.Enabled = true;
            CboLocalidad.Enabled = true;
            CboBarrio.Enabled = false;
        }
        public void hab_barrio(bool v)
        {
            cboProv.Enabled = true;
            CboLocalidad.Enabled = true;
            CboBarrio.Enabled = true;
        }
        private async void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiar();
            await cargar_provincia();
            picLimpiar.Visible = true;
            habilitar_todo_campo(true);
            habilitar_todo_btn(false);
            BtnGuardar.Enabled = true;
            pnlCrud.Visible = true;
        }
        private void btnMod_Click_1(object sender, EventArgs e)
        {
            btnMod.Enabled = false;
            habilitar_todo_campo(true);
            BtnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
            txbNombre.Enabled = false;
            TxbApellido.Enabled = false;
            dtpFechaNac.Enabled = false;
            rbtFemenino.Enabled = false;
            rbtMasculino.Enabled = false;
        }
        private async void btnBorrar_Click_1(object sender, EventArgs e)
        {
            
            await Baja(new Parametro("@id_cliente", clienteselect.Id_Cliente));
            await cargar_Clientes();
            CargarDgv();
            limpiar();
            pnlCrud.Visible = false;
            habilitar_todo_btn(true);
            btnMod.Enabled = false;
            BtnGuardar.Enabled = false;
            btnBorrar.Enabled = false;
        }
        private async void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                Cliente c = new Cliente();
                abstraer_cliente(c);
                if (await Buscar_Cliente(clienteselect.Id_Cliente))
                {
                    c.Id_Cliente = clienteselect.Id_Cliente;
                    c.per.Id_Persona = clienteselect.per.Id_Persona;
                    if (await Update_Cliente(c))
                    {
                        MessageBox.Show("Modificado Correctamente");
                    }else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
                else
                {
                    if (await alta_Cliente(c))
                    {
                        MessageBox.Show("Cargado Correctamente");

                    }
                    else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
                await cargar_Clientes();
                CargarDgv();
                pnlCrud.Visible = false;
                habilitar_todo_btn(true);
                btnMod.Enabled = false;
                BtnGuardar.Enabled = false;
                btnBorrar.Enabled = false;
                limpiar();
            }
        }
        private async Task Baja(Parametro pm)
        {
            bool ban = false;
            string url = "https://localhost:7271/api/CRUDcliente/PutBajaCliente";
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            ban = JsonConvert.DeserializeObject<bool>(data);
            if (ban)
            {
                MessageBox.Show("Bajado con exito");
            }
            else
            {
                MessageBox.Show("No se ha podido bajar");

            }
        }
        private async Task<bool> Update_Cliente(Cliente c)
        {
            string url = "https://localhost:7271/api/CRUDcliente/PutModificarCliente";
            string FiltrosJson = JsonConvert.SerializeObject(c);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);

        }
        private async Task<bool> alta_Cliente(Cliente c)
        {
            string url = "https://localhost:7271/api/CRUDcliente/PostAltaCliente";
            string FiltrosJson = JsonConvert.SerializeObject(c);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);

        }
        private async Task cargar_Clientes()
        {
            string url = "https://localhost:7271/api/CRUDcliente/GetCliente";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
            if (clientes is null)
            {
                MessageBox.Show("Demasiadas solicitudes, Intentelo de nuevo más tarde");
            }
        }
        private async Task<bool> Buscar_Cliente(int C)
        {
            bool bandera = false;
            string url = "https://localhost:7271/api/CRUDcliente/GetExisteCliente?c=" + C.ToString(); ;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return  JsonConvert.DeserializeObject<bool>(data);
        }
        private async void cboProv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CboLocalidad.SelectedIndex = -1;
            CboBarrio.SelectedIndex = -1;
            Provincia Prov = (Provincia)cboProv.SelectedItem;
            Parametro p = new Parametro("@id_provincia", Prov.codigo_provincia);
            await Cargar_Localidad(p);
        }
        private async void CboLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CboBarrio.SelectedIndex = -1;

            Localidad Locselected = (Localidad)CboLocalidad.SelectedItem;
            await Cargar_barrio(Locselected.codigo_localidad);
        }
    }
}