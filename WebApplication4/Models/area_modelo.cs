using datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Models
{
   
    public class area_modelo : sql
    {
        pruebaEntities1 otablas = new pruebaEntities1();

        public List<tarea> listaareas()
        {
            SqlParameter param = new SqlParameter();

            List<ArrayList> coleccionlista = Lista("select cast(car_cod as nvarchar),car_des from  cargos order by car_des", "2");
            List<tarea> careas = new List<tarea>();
            foreach (ArrayList listas in coleccionlista)
            {
                careas.Add(new tarea(listas[0].ToString(), listas[1].ToString()  ));
            }
          
            return careas;
        }

    }


}













//List<parametros> coleccion_parametros = new List<parametros>();
//parametros opara = new parametros();
//opara.tipo = "@id";
//opara.valor = "1";
//coleccion_parametros.Add(opara);

//List<ArrayList> coleccionlista = Lista("prclistaareas", "1", coleccion_parametros);