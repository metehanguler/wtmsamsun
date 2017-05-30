using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for esqlbaglantisi
/// </summary>
public class esqlbaglantisi
{
    public SqlConnection baglan()
    {
        try
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=wtmsamsun; Integrated Security=true");
            baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();
            return (baglanti);
        }
        catch (Exception)
        {
            
            throw;
        }
       
    }
}