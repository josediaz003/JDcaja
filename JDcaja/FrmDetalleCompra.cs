using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDcaja
{
    public partial class FrmDetalleCompra : Form
    {
        public FrmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtbusqueda.Text);
            if (oCompra.IdCompra != 0)
            {
                txtnumeroDocumento.Text = oCompra.NumeroDocumento;

                txtfecha.Text = oCompra.FechaRegistro;
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.oUsuario.NombreCompleto;
                txtdocProveedor.Text = oCompra.oProveedor.Documento;
                txtnombreProveedor.Text = oCompra.oProveedor.RazonSocial;

                dgvdata.Rows.Clear();

                foreach (Detalle_Compra dc in oCompra.oDetalle_Compra)
                {
                    dgvdata.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }
                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocProveedor.Text = "";
            txtnombreProveedor.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumeroDocumento.Text.ToUpper());

            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocProveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreProveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Compra_{0}.pdf", txtnumeroDocumento.Text);
            saveFile.Filter = "Pdf Files| *.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}