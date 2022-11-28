using Microsoft.Extensions.Configuration;

namespace MvcDemo.Models.DAL
{
    public class CustomersDAL
    {
        private readonly IConfiguration configuration;
        SqlConnection con;
        SqlDataReader dr;
        SqlCommnd cmd;

        public CustomersDAL(IConfiguration configuration)
        {
            this.configuration = configuration;
            con = new SqlConnection(this.configuration.GetConnectionString("defaultConnection"));

        }
        public int CustomerRegister(Customers cust)
        {
            string qry = "insert into Customers values(@name,@email,@contact,@pass)";
            cmd = new SqlCommnd(qry, con);
            cmd.Parameters.AddWithValue("@name",cust.Name);
            cmd.Parameters.AddWithValue("@email", cust.Email);
            cmd.Parameters.AddWithValue("@contact", cust.Contact);
            cmd.Parameters.AddWithValue("@pass", cust.Password);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
