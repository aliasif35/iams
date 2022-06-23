﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Models;
using Oracle.ManagedDataAccess.Client;

namespace IAMS
{
    public class DBConnection
    {
        private OracleConnection DatabaseConnection()
        {
            try
            {
                // create connection
                OracleConnection con = new OracleConnection();

                // create connection string using builder
                OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
                ocsb.Password = "iamsdev";
                ocsb.UserID = "iamsdev";
                ocsb.DataSource = "10.1.100.222:1521/devdb18c.ztbl.com.pk";

                // connect
                con.ConnectionString = ocsb.ConnectionString;
                con.Open();
                return con;

            }
            catch (Exception e) { return null; }
        }

        public UserModel AutheticateLogin(LoginModel login)
        {
            var con = this.DatabaseConnection();
            UserModel user = new UserModel();
            using (OracleCommand cmd = con.CreateCommand())
            {
                //con.Open();
                cmd.CommandText = "Select * FROM iamsdev.T_USERS u WHERE u.PP_NUMBER='" + login.PPNumber + "' and u.Password ='" + login.Password + "' and u.Status='Active'"; 
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    
                    user.ID = Convert.ToInt32(rdr["Id"]);
                    user.Name = rdr["Name"].ToString();
                    user.Email = rdr["Email"].ToString();
                    user.PPNumber = rdr["PP_Number"].ToString();
                }                
            }
            con.Close();
            return user;
        }
        public List<MenuModel> GetTopMenus()
        {
            var con = this.DatabaseConnection();
            
            List<MenuModel> modelList = new List<MenuModel>();
            using (OracleCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Select * FROM iamsdev.T_MENU m WHERE m.isactive='Y'";
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MenuModel menu = new MenuModel();
                    menu.Menu_Id = Convert.ToInt32(rdr["MENU_ID"]);
                    menu.Menu_Name = rdr["MENU_NAME"].ToString();
                    menu.Menu_Order = rdr["MENU_ORDER"].ToString();
                    menu.Menu_Description = rdr["MENU_DESCRIPTION"].ToString();
                    modelList.Add(menu);
                }
            }
            con.Close();
            return modelList;
        }
        public List<MenuPagesModel> GetTopMenuPages()
        {
            var con = this.DatabaseConnection();

            List<MenuPagesModel> modelList = new List<MenuPagesModel>();
            using (OracleCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "Select * FROM iamsdev.T_MENU_PAGES mp WHERE mp.Status='A'";
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MenuPagesModel menuPage = new MenuPagesModel();
                    menuPage.Id = Convert.ToInt32(rdr["ID"]);
                    menuPage.Menu_Id = Convert.ToInt32(rdr["MENU_ID"]);
                    menuPage.Page_Name = rdr["PAGE_NAME"].ToString();
                    menuPage.Page_Path = rdr["PAGE_PATH"].ToString();
                    menuPage.Page_Order = Convert.ToInt32(rdr["PAGE_ORDER"]);
                    menuPage.Status = rdr["STATUS"].ToString();
                    modelList.Add(menuPage);
                }
            }
            con.Close();
            return modelList;
        }

    }
}