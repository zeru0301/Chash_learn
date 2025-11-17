using MySql.Data.MySqlClient;

// 1. 接続文字列
string connStr = "server=localhost;user=root;password=password;database=zeru_db;";

// 2. 接続
using (var conn = new MySqlConnection(connStr))
{
    conn.Open();

    // 3. SQL文
    string sql = "SELECT product_id, name, price FROM products";

    using (var cmd = new MySqlCommand(sql, conn))
    using (var reader = cmd.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine($"{reader["product_id"]} {reader["name"]} {reader["price"]}");
        }
    }
}
