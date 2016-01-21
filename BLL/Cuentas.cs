using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Cuentas
    {
        public int CuentaId;
        public string Descripcion { get; set; }
        public float Balance { get; set; }

        public Conexion con = new Conexion();

        public Cuentas()
        {

            this.CuentaId = 0;
            this.Descripcion = Descripcion;
            this.Balance = Balance;

        }

        public bool insertar()
        {
            return con.EjecutarDB("insert into Cuentas (Descripcion, Balance) values('" + this.Descripcion + "', '" + this.Balance + "')");
        }

        public bool modificar(int id)
        {
            return con.EjecutarDB("update Cuentas set Descripcion = '" + this.Descripcion + "', Balance = '" + this.Balance + "' where CuentaId = '" + id + "'");
        }
        public bool eliminar(int id)
        {
            return con.EjecutarDB("delete from Cuentas where CuentaId =" + id);
        }
        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("select * from Cuentas where CuentaId = " + id);
            if (dt.Rows.Count > 0)
            {

                this.CuentaId = (int)dt.Rows[0]["CuentaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Balance = (float)dt.Rows[0]["Balance"];

            }
            return dt;
        }

        public bool BuscarL(int id)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("select * from Cuentas where CuentaId = " + id);
            if (dt.Rows.Count > 0)
            {

                this.CuentaId = (int)dt.Rows[0]["CuentaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Balance = Convert.ToSingle(dt.Rows[0]["Balance"]);
            }
            return true;
        }

        public DataTable BuscarLista(String sql)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb(sql);
            return dt;
        }



    }
}
