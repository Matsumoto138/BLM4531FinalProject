using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace Customer_Management_System3
{
    public partial class Home : System.Web.UI.Page
    {
        
        SqlConnection connection;
        SqlCommand komut;
        //SqlDataAdapter data;

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-3QDOLQ10; Initial Catalog=Customer;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.Attributes["style"] = "display:none";
            //LabelShow.Attributes["style"] = "displat:none";
            Label1.Attributes["style"] = "display:none";
            Label2.Attributes["style"] = "display:none";
            Label3.Attributes["style"] = "display:none";
            Label4.Attributes["style"] = "display:none";
            Label5.Attributes["style"] = "display:none";
            Label6.Attributes["style"] = "display:none";
            Label7.Attributes["style"] = "display:none";
            Label8.Attributes["style"] = "display:none";
            Label9.Attributes["style"] = "display:none";
            Label10.Attributes["style"] = "display:none";
            Label11.Attributes["style"] = "display:none";
            TextBox2.Attributes["style"] = "display:none";
            TextBox3.Attributes["style"] = "display:none";
            TextBox4.Attributes["style"] = "display:none";
            TextBox5.Attributes["style"] = "display:none";
            TextBox6.Attributes["style"] = "display:none";
            TextBox7.Attributes["style"] = "display:none";
            TextBox8.Attributes["style"] = "display:none";
            TextBox9.Attributes["style"] = "display:none";
            CheckBox1.Attributes["style"] = "display:none";
            CheckBox2.Attributes["style"] = "display:none";
            CheckBox3.Attributes["style"] = "display:none";
            CheckBox4.Attributes["style"] = "display:none";
            DropDownList1.Attributes["style"] = "display:none";
            DropDownList2.Attributes["style"] = "display:none";
            Button2.Attributes["style"] = "display:none";
            Button3.Attributes["style"] = "display:none";
            Button4.Attributes["style"] = "display:none";
            Button5.Attributes["style"] = "display:none";
            Button6.Attributes["style"] = "display:none";
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Attributes["style"] = "display:none";
            GridView2.Attributes["style"] = "display:block";
            baglanti.Open();

           
            string sql = "select * from info where Name Like '%'+@Name+'%' ";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("Name", TextBox1.Text);
            SqlDataReader data = komut.ExecuteReader();

            GridView2.DataSource = data;
            GridView2.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "insert into info (Name,Product,Price,Payment, Installment) values(@Name,@Product,@Price,@Payment,@Installment)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Name", TextBox2.Text);
            komut.Parameters.AddWithValue("@Product", TextBox3.Text);
            komut.Parameters.AddWithValue("@Price", TextBox4.Text);
            if (CheckBox1.Checked)
            {
                komut.Parameters.AddWithValue("@Payment", CheckBox1.Text);
                komut.Parameters.AddWithValue("@Installment", " ");
            }
            else
            {
                komut.Parameters.AddWithValue("@Payment", CheckBox2.Text);
                komut.Parameters.AddWithValue("@Installment", DropDownList1.SelectedItem.Value);
            }

            komut.ExecuteNonQuery();
            baglanti.Dispose();/*Nesneyi bellekten at*/
            baglanti.Close();
            
            Response.Redirect(Request.RawUrl);
            LabelInfo.Text = "Yeni Müşteri Kaydedildi";


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView2.Attributes["style"] = "display:none";
            GridView1.Attributes["style"] = "display:block";
            baglanti.Open();
            string sql = "Select * from info";
            komut = new SqlCommand(sql, baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update info set Last_debt = Last_debt - @money, Installment = Installment-1  where Name = @Name";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Name", TextBox5.Text);
            komut.Parameters.AddWithValue("@money", TextBox6.Text);

            komut.ExecuteNonQuery();
            baglanti.Dispose();/*Nesneyi bellekten at*/
            baglanti.Close();

            Response.Redirect(Request.RawUrl);
        }

        protected void ButtonNewCustomer_Click(object sender, EventArgs e)
        {
            Label1.Attributes["style"] = "display:block";
            Label2.Attributes["style"] = "display:block";
            Label3.Attributes["style"] = "display:block";
            Label4.Attributes["style"] = "display:block";
            TextBox2.Attributes["style"] = "display:block";
            TextBox3.Attributes["style"] = "display:block";
            TextBox4.Attributes["style"] = "display:block";
            CheckBox1.Attributes["style"] = "display:block";
            CheckBox2.Attributes["style"] = "display:block";
            DropDownList1.Attributes["style"] = "display:block";
            Button2.Attributes["style"] = "display:block";
            Button3.Attributes["style"] = "display:block";
            Button4.Attributes["style"] = "display:block";
        }

        protected void PaidUpdate_Click(object sender, EventArgs e)
        {
            Label5.Attributes["style"] = "display:block";
            Label6.Attributes["style"] = "display:block";
            Label7.Attributes["style"] = "display:block";
            TextBox5.Attributes["style"] = "display:block";
            TextBox6.Attributes["style"] = "display:block";
            Button5.Attributes["style"] = "display:block";
        }

        protected void UpdateCustomer_Click(object sender, EventArgs e)
        {
            Label8.Attributes["style"] = "display:block";
            Label9.Attributes["style"] = "display:block";
            Label10.Attributes["style"] = "display:block";
            Label11.Attributes["style"] = "display:block";
            TextBox7.Attributes["style"] = "display:block";
            TextBox8.Attributes["style"] = "display:block";
            TextBox9.Attributes["style"] = "display:block";
            CheckBox3.Attributes["style"] = "display:block";
            CheckBox4.Attributes["style"] = "display:block";
            DropDownList2.Attributes["style"] = "display:block";
            Button6.Attributes["style"] = "display:block";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update info set Name=@Name, Product=@Product, Price=@Price, Payment=@Payment, Installment=@Installment, Last_debt=@Last_debt where Name=@Name";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Name", TextBox7.Text);
            if (TextBox8.Text != "")
            {
                komut.Parameters.AddWithValue("@Product", TextBox8.Text);
            }

            if(TextBox9.Text != "")
            {
                komut.Parameters.AddWithValue("@Price", TextBox9.Text);
            }

            if(CheckBox3.Checked || CheckBox4.Checked)
            {
                if (CheckBox3.Checked)
                {
                    komut.Parameters.AddWithValue("@Payment", CheckBox3.Text);
                    komut.Parameters.AddWithValue("@Installment", " ");
                }
                else
                {
                    komut.Parameters.AddWithValue("@Payment", CheckBox4.Text);
                    komut.Parameters.AddWithValue("@Installment", DropDownList2.SelectedItem.Value);
                }
            }
            
            
            komut.ExecuteNonQuery();
            baglanti.Dispose();/*Nesneyi bellekten at*/
            baglanti.Close();

            Response.Redirect(Request.RawUrl);
        }
    }
}