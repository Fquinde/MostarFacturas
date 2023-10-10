using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class mostrar : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable datos = new DataTable("Facturas");
        DataColumn datoscolumnas;
        DataRow dtRow;

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "numero";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "fecha";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "cif_cliente";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "nombre_cliente";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "importe";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "importe_iva";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "moneda";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "fecha_cobro";
        datos.Columns.Add(datoscolumnas);

        datoscolumnas = new DataColumn();
        datoscolumnas.DataType = typeof(String);
        datoscolumnas.ColumnName = "estado";
        datos.Columns.Add(datoscolumnas);


        DataSet tabla = new DataSet();
        tabla.Tables.Add(datos);


        DataSet datosXml = new DataSet();
        datosXml.ReadXml(Server.MapPath("~/datos/Facturas.xml"));
        

        // Recorrer los datos
        for (int x = 0; x <= datosXml.Tables.Count - 1; x++)
        {
            // recorre las filas 
            for (int y = 0; y <= datosXml.Tables[x].Rows.Count - 1; y++)
            {
                
                    dtRow = datos.NewRow();
                    dtRow["numero"] = datosXml.Tables[x].Rows[y].ItemArray[0];
                    dtRow["fecha"] = datosXml.Tables[x].Rows[y].ItemArray[1];
                    dtRow["cif_cliente"] = datosXml.Tables[x].Rows[y].ItemArray[2];
                    dtRow["nombre_cliente"] = datosXml.Tables[x].Rows[y].ItemArray[3];
                    dtRow["importe"] = datosXml.Tables[x].Rows[y].ItemArray[4];
                    dtRow["importe_iva"] = datosXml.Tables[x].Rows[y].ItemArray[5];
                    dtRow["moneda"] = datosXml.Tables[x].Rows[y].ItemArray[6];
                    dtRow["fecha_cobro"] = datosXml.Tables[x].Rows[y].ItemArray[7];
                    dtRow["estado"] = datosXml.Tables[x].Rows[y].ItemArray[8];

                    datos.Rows.Add(dtRow);
            }
        }   

        mostrarfacturas.DataSource = tabla;
        mostrarfacturas.DataBind();


    }


}