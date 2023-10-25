// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Data.SqlClient;
using System;
using System.Data;

// AddDisconnect();
ShowDisconnect();
//Connected Architecture
// Console.WriteLine("Hello");
// AddRecord();
// Show();

void ShowDisconnect()
{
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=MyDatabaseNY;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext = "insert into product values(@id,@name,@price,@stock)";
    SqlConnection connection = null;
    SqlDataAdapter adapter = null;
    DataSet ds = null;
    DataTable prodTable = null;
    try
    {
        ds = new DataSet();
        connection = new SqlConnection(connectionString);
        adapter = new SqlDataAdapter("select * from product", connection); //only select commands can be given in adapter
        adapter.Fill(ds,"Prods");
        prodTable = ds.Tables["Prods"];
        Console.WriteLine($"Rows = {prodTable.Rows.Count}");
        Console.WriteLine($"Columns = {prodTable.Columns.Count}");
        foreach(DataRow row in prodTable.Rows)
        {
            Console.WriteLine($"{row["id"]} -- {row["name"]} -- {row["price"]} -- {row["stock"]}");
        }

    }
    catch (Exception ex)
    {
        
        Console.WriteLine(ex.Message);
    }
}

void AddDisconnect()
{
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=MyDatabaseNY;trusted_connection=false;Persist Security Info=False;Encrypt=False";

    string cmdtext = "insert into product values(@id,@name,@price,@stock)";
    Console.WriteLine("Enter ID");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Price");
    int price = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Stock");
    int stock = int.Parse(Console.ReadLine());
    SqlConnection connection = null;
    SqlDataAdapter adapter = null;
    DataSet ds = null;
    DataTable prodTable = null;

    try
    {
        ds = new DataSet();
        connection = new SqlConnection(connectionString);
        adapter = new SqlDataAdapter("select * from product",connection);
        adapter.Fill(ds,"Prods");
        prodTable = ds.Tables["Prods"];
        DataRow prodrow = prodTable.NewRow();
        prodrow["id"] = id;
        prodrow["name"] = name;
        prodrow["price"] = price;
        prodrow["stock"] = stock;
        prodTable.Rows.Add(prodrow);
        SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
        Console.WriteLine(scb.GetInsertCommand().CommandText);
        // adapter.Update(prodTable);
        Console.WriteLine("Row Added");
    }
    catch (Exception ex)
    {
        
        Console.WriteLine(ex.Message);
    }

}

void AddRecord()
{
    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=MyDatabaseNY;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext = "insert into product values(@id,@name,@price,@stock)";
    Console.WriteLine("Enter ID");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Price");
    int price = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Stock");
    int stock = int.Parse(Console.ReadLine());
    SqlConnection con = null;
    SqlCommand command = null;

    try
    {
        con = new SqlConnection(connectionString);
        command = new SqlCommand(cmdtext,con);
        command.Parameters.AddWithValue("@id",id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@price",price);
        command.Parameters.AddWithValue("@stock",stock);
        con.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("Record Added");
    }
    catch (Exception ex)
    {
        
        Console.WriteLine(ex.Message);
    }
    finally
    {
        con.Close();
    }

}

void Show()
{

    string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=MyDatabaseNY;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext = "select * from product";

    try
    {
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        Console.WriteLine("Connection Opened Successfully");
        SqlCommand command = new SqlCommand(cmdtext, con);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader["id"]} --- {reader["Name"]} --- {reader["price"]} --- {reader["stock"]}");
        }

        con.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}