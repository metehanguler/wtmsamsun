﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class konusmacilar : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand getir = new SqlCommand("Select * from Konusmaci order by konusmaciId desc", baglan.baglan());
        SqlDataReader duyurugetir = getir.ExecuteReader();
        DataList1.DataSource = duyurugetir;
        DataList1.DataBind();
    }
}