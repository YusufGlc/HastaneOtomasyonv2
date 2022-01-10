using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace HastaneOtomasyon
{
    class Sqlİslemler
    {

        internal SqlConnection connection = new SqlConnection("Data Source=Exponental-4224;Initial Catalog=HastaneOtomasyonDB;Integrated Security=True");
        
        
        internal void degisiklikYap(string command)
        {
            try
            {
                baglantiKes();
                baglan();
                SqlCommand command1 = new SqlCommand(command, connection);
                command1.ExecuteNonQuery();
                baglantiKes();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        internal void goruntule(string sorgu,ComboBox comboBox)
        {
            try
            {
                baglantiKes();
                baglan();

                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader[0].ToString().TrimEnd());
                }

                baglantiKes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        internal string goruntule(string sorgu)
        {
            try
            {
                baglantiKes();
                baglan();

                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader[0].ToString().TrimEnd();
                }
                
                baglantiKes();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            return string.Empty;
        }

        internal void goruntule(string sorgu,DataGridView dataGridView)
        {
            try
            {
                baglantiKes();
                baglan();

                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;

                baglantiKes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }


        internal void baglan()
        {
            connection.Open();
        }

        internal void baglantiKes()
        {
            connection.Close();
        }


    }
}
