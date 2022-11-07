using Cine_Hoyts;
using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineHoytsFront.Formularios
{
    public partial class CrudVendedor : Form
    {
        List<Vendedor> lvendedor = new List<Vendedor>();
        Vendedor venSelected = new Vendedor();
        public CrudVendedor()
        {
            InitializeComponent();
        }

        private async void CrudVendedor_Load(object sender, EventArgs e)
        {
            await cargar_provincia();
            await cargar_Vendedores();
            await CargarComboAsyncTipoDoc();
            Cargar_Dgv();
        }

        private async Task cargar_Vendedores()
        {
            string url = "https://localhost:7271/api/CRUDvendedor/GetVendedor";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            lvendedor = JsonConvert.DeserializeObject<List<Vendedor>>(data);
            if (lvendedor is null)
            {
                MessageBox.Show("Demasiadas solicitudes, Intentelo de nuevo más tarde");
            }
        }

        private void Cargar_Dgv()
        {
            dgvCliente.Rows.Clear();
            if (lvendedor is null)
            {
            }
            else
            {
                foreach (Vendedor client in lvendedor)
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
                        dgvCliente.Rows.Add(client.Id_Vendedor.ToString(), client.per.Nombre + " " + client.per.Apellido, client.per.Nro_Documento.ToString(),
                        client.per.Tipo_doc, client.per.Direccion + " " + client.per.Nro_Direccion, client.per.Fecha_Nac, sex);
                    }
                    catch (Exception)
                    {

                    }

                }
            }
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
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            List<Localidad> lst = JsonConvert.DeserializeObject<List<Localidad>>(data);
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

        private async void dgvCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await cargar_provincia();


            venSelected = new Vendedor();
            venSelected.Id_Vendedor = lvendedor[dgvCliente.CurrentRow.Index].Id_Vendedor;
            venSelected.per = lvendedor[dgvCliente.CurrentRow.Index].per;
            venSelected.Usuario = lvendedor[dgvCliente.CurrentRow.Index].Usuario;
            venSelected.Contraseña = lvendedor[dgvCliente.CurrentRow.Index].Contraseña;
            venSelected.admin = lvendedor[dgvCliente.CurrentRow.Index].admin;






            txbNroVendedor.Text = venSelected.Id_Vendedor.ToString();
            txbNombre.Text = venSelected.per.Nombre;
            TxbApellido.Text = venSelected.per.Apellido;
            txbDireccion.Text = venSelected.per.Direccion;
            txbDocumento.Text = venSelected.per.Nro_Documento.ToString();
            numDireccion.Value = venSelected.per.Nro_Direccion;
            cboTipoDoc.SelectedValue = venSelected.per.Id_tipo_documento;
            dtpFechaNac.Value = Convert.ToDateTime(venSelected.per.Fecha_Nac);
            cboProv.SelectedValue = venSelected.per.id_provincia;
            txbUsuario.Text = venSelected.Usuario;
            txbcontra.Text = venSelected.Contraseña;

            if (venSelected.admin == 1)
            {
                chkAdmin.Checked = true;
            }
            else
            {
                chkAdmin.Checked = false;
            }

            await Cargar_Localidad(new Parametro("@id_provincia", venSelected.per.id_provincia));

            CboLocalidad.SelectedValue = venSelected.per.id_localidad;
            await Cargar_barrio(venSelected.per.id_localidad);

            CboBarrio.SelectedValue = venSelected.per.id_barrio;
            if (CboBarrio.Text == "")
            {
                await Cargar_barrio(venSelected.per.id_localidad);

                CboBarrio.SelectedValue = venSelected.per.id_barrio;
            }

            if (venSelected.per.Sexo == 0)
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
            chkAdmin.Enabled = a;
            txbcontra.Enabled = a;
            txbUsuario.Enabled = a;
        }
        private void habilitar_todo_btn(bool a)
        {
            btnNuevo.Enabled = a;
            btnMod.Enabled = a;
            btnBorrar.Enabled = a;
            BtnGuardar.Enabled = a;
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

        private void limpiar()
        {
            txbDireccion.Clear();
            txbDocumento.Clear();
            txbNombre.Clear();
            TxbApellido.Clear();
            dtpFechaNac.Value = DateTime.Now;
            numDireccion.Value = 0;
            rbtMasculino.Checked = true;
            venSelected = new Vendedor();
            txbNroVendedor.Clear();
            cboProv.SelectedIndex = -1;
            CboLocalidad.SelectedIndex = -1;
            CboBarrio.SelectedIndex = -1;
            txbUsuario.Clear();
            txbcontra.Clear();
            chkAdmin.Checked = false;

        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void btnMod_Click(object sender, EventArgs e)
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

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if(await Baja(venSelected.Id_Vendedor))
            {
                MessageBox.Show("El vendedor se dio de baja con exito");
            }
            else
            {
                MessageBox.Show("Problema al dar de baja al vendedor");
            };
            await cargar_Vendedores();
            Cargar_Dgv();
            limpiar();
            pnlCrud.Visible = false;
            habilitar_todo_btn(true);
            btnMod.Enabled = false;
            BtnGuardar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private async Task<bool> Baja(int a)
        {
            string url = "https://localhost:7271/api/CRUDvendedor/BajaVendedor?a=" + a.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<bool>(data);

        }

        private async Task<bool> Update_Ven(Vendedor c)
        {
            string url = "https://localhost:7271/api/CRUDvendedor/PutModificarVendedor";
            string FiltrosJson = JsonConvert.SerializeObject(c);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);

        }

        private async Task<bool> AltaVen(Vendedor c)
        {
            string url = "https://localhost:7271/api/CRUDvendedor/PostAltaVendedor";
            string FiltrosJson = JsonConvert.SerializeObject(c);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                Vendedor c = new Vendedor();
                abstraer_vendedor(c);
                if (await Buscar_Vendedor(venSelected.Id_Vendedor))
                {
                    c.Id_Vendedor = venSelected.Id_Vendedor;
                    c.per.Id_Persona = venSelected.per.Id_Persona;
                    if (await Update_Ven(c))
                    {
                        MessageBox.Show("Modificado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
                else
                {
                    if (await AltaVen(c))
                    {
                        MessageBox.Show("Cargado Correctamente");

                    }
                    else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
                await cargar_Vendedores();
                Cargar_Dgv();
                pnlCrud.Visible = false;
                habilitar_todo_btn(true);
                btnMod.Enabled = false;
                BtnGuardar.Enabled = false;
                btnBorrar.Enabled = false;
                limpiar();
            }
        }

        private void abstraer_vendedor(Vendedor c)
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
            c.Usuario = txbUsuario.Text;
            c.Contraseña = txbcontra.Text;
            if (chkAdmin.Checked == true)
            {
                c.admin = 1;
            }
            else
            {
                c.admin = 0;
            }

        }

        private bool validar_campos()
        {
            if (txbNombre.Text == "")
            {
                MessageBox.Show("Debe cargar el nombre del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNombre.Focus();
                return false;
            }
            else if (TxbApellido.Text == "")
            {
                MessageBox.Show("Debe cargar el apellido del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxbApellido.Focus();
                return false;
            }
            else if (txbUsuario.Text == "")
            {
                MessageBox.Show("Debe cargar usuario del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtMasculino.Focus();
                return false;
            }
            else if (txbcontra.Text == "")
            {
                MessageBox.Show("Debe cargar la contrasela del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtMasculino.Focus();
                return false;
            }
            else if (rbtFemenino.Checked == false && rbtMasculino.Checked == false)
            {
                MessageBox.Show("Debe cargar el sexo del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbtMasculino.Focus();
                return false;
            }
            else if (txbDireccion.Text == "")
            {
                MessageBox.Show("Debe cargar la direccion del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDireccion.Focus();
                return false;
            }
            else if (numDireccion.Value == 0)
            {
                MessageBox.Show("Debe cargar el numero de direccion del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numDireccion.Focus();
                return false;
            }
            else if (txbDocumento.Text == "")
            {
                MessageBox.Show("Debe cargar el documento del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDocumento.Focus();
                return false;
            }
            else if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el tipo de documento del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoDoc.Focus();
                return false;
            }
            else if (dtpFechaNac.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Debe cargar la fecha de nacimiento del vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNac.Focus();
                return false;
            }

            try
            {
                Convert.ToInt64(txbDocumento.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Debe cargar un documento valido para el vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDocumento.Focus();
                return false;
            }
            return true;
        }

        private async Task<bool> Buscar_Vendedor(int C)
        {
            string url = "https://localhost:7271/api/CRUDvendedor/GetExisteVendedor?c=" + C.ToString(); ;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<bool>(data);
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            await cargar_provincia();
            picLimpiar.Visible = true;
            habilitar_todo_campo(true);
            habilitar_todo_btn(false);
            BtnGuardar.Enabled = true;
            pnlCrud.Visible = true;
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
