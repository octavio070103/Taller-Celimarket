using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public static class ContenidoHTML
    {
        public static string ObtenerContenidoHTML()
        {
            string encabezado = "Factura-Cliente";
            string contenidoHTML = $@"
           
<!DOCTYPE html>
<html lang=""en"">
<head>
    <title>Factura de Venta</title>
</head>
<body style="" font-family: Arial, background-color: #E9EBF7;,sans-serif;margin: 20px;"">

    <div class=""header"" style=""display: flex; justify-content: space-between; align-items: center;"">
    <div class=""logo"">
        <img src=""@imgBase64"" alt=""Logo"" style=""max-width: 80%;margin-right: 10px;"" height=""auto"">
    </div>
    <div class=""title"" style=""text-align: center; margin-right:10%;"">
        <h1>Factura Tipo @tipoFac</h1>
    </div>
    <div class=""info-factura"" style=""text-align: left; margin-right: 4%;"">
        <p>Factura Original</p>
        <p>Factura: @numFactura</p>
        <p>Fecha: @fechaFactura</p>
    </div>
</div>


    <div class=""info-Negocio"" style=""display: flex; justify-content: space-between; border: 1px solid #000;"">
        <div class=""columna"" style=""width: 48%; margin-right: 2%; margin-left: 2%;"">
            <p><strong>Razon Social: </strong>@nombre_negocio</p>
            <p><strong>Domicilio Comercial: </strong>@direccion</p>
            <p>Corrientes Capital (CP 3400) - Corrientes</p>
            <span>Telefono: @telefono_negocio</span> <span>@email_negocio</span>
            <p>I.V.A RESPONSABLE INSCRIPTO</p>
        </div>

        <div class=""columna2"" style=""width: 30%; margin-right: 2%; margin-left: 2%;"">
            <p><strong>CUIT: </strong>@CUIT</p>
            <p><strong>Ing. brutos: </strong>906-292414-1</p>
            <p>Inicio de Actividades: 07/2023</p>
        </div>
    </div>

    <div class=""info-cliente"" style=""margin-top: 10px; text-align: center; border: 1px solid #000;"">
        <h3>Datos De La Venta</h3>
        <div class=""row-info-cliente"" style=""display: flex;"">
            <div class=""columna"" style=""width: 50%; text-align: left; margin-left: 10%;"">
                <p><strong>Cliente: </strong>@Nombre</p>
                <p><strong>Dni: </strong>@dniCliente</p>
                <p><strong>Telefono: </strong>@telefono_cliente</p>
            </div>
            <div class=""columna2"" style=""width: 50%; text-align: left; margin-left: 10%;"">
                <p><strong>Vendedor: </strong>@nombreVendedor</p>
                <p><strong>Metodo de pago: </strong>@metPago</p>
                <p><strong>Fecha Venta: </strong>@fechaVenta</p>
            </div>
        </div>
    </div>

    <table class=""table-product"" style=""width:100%; margin-top: 20px; border: 1px solid #000;"">
        <thead style=""background-color: #D8D8D8;"">
            <tr>
                <th>Articulo</th>
                <th>Cantidad</th>
                <th>Marca</th>
                <th>Precio Unit</th>
                <th>Importe</th>
            </tr>
        </thead>
        <tbody  style=""text-align: center;"">
            <tr>
                @FILAS
            </tr class =""tr-filas"">
            <tr>
                <td ></td>
                <td style=""text-align: center;padding-top:30px;"">Subtotal</td>
                <td style=""text-align: center;padding-top:30px;"">Descuento</td>
                <td style=""text-align: center;padding-top:30px;"">IVA</td>
                <td style=""text-align: center;padding-top:30px;"">Total</td>
            </tr>
            <tr>
                <td ></td>
                <td style=""text-align: center;"">@Subtotal</td>
                <td style=""text-align: center;"">@Descuento</td>
                <td style=""text-align: center;"">@IVA</td>
                <td style=""text-align: center;"">@Total</td>
            </tr>
        </tbody>
    </table>

</body>
</html>

";

            return contenidoHTML;
        }
    }
}
