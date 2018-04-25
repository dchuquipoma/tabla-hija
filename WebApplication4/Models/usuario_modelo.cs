using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace WebApplication4.Models
{
    public class usuario_modelo
    {
        pruebaEntities1 otablas = new pruebaEntities1();

        public List<tusuario> listausuarios(String id)
        {
            List<tusuario> lusuarios = new List<tusuario>();
            var tblusuario = otablas.prclistausuario(id);
           
            
            foreach (var tblusuarios in tblusuario)
            {
                tusuario ousu = new tusuario();
                ousu.usu_cod = tblusuarios.usu_cod.ToString();
                ousu.usu_nom = tblusuarios.usu_nom.ToString();
                ousu.usu_cargo = tblusuarios.car_des.ToString();
                lusuarios.Add(ousu);
            }

            return lusuarios;
        }

        public String guardarusuario(tusuario tusu) {
            String resultado = "";
            try
            {
             
                otablas.prcopeusu(tusu.usu_cod,tusu.usu_nom,tusu.usu_cargo,tusu.usu_tipo);
                resultado = "OK";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

        public String Eliminarusuario(String id)
        {
            String resultado = "";
            try
            {
                tusuario tusu = new tusuario();
                tusu.usu_cod = id;
                tusu.usu_tipo = "3";
                otablas.prcopeusu(tusu.usu_cod, "", "", tusu.usu_tipo);
                resultado = "OK";
            }
            catch (Exception ex)
            {
                resultado = ex.Message;
            }
            return resultado;
        }

    }

}