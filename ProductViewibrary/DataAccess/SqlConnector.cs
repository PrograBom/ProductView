using ProductViewLibrary.Models;
using System.Data;
using Dapper;

namespace ProductViewLibrary.DataAccess;

public class SqlConnector
{
    string? cnnString = GlobalConfig.CnnString("ProductView");

    public List<Product> GetProduct_All()
    {
        List<Product> products = new List<Product>();
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(cnnString))
        {
            connection.Open();

            products = connection.Query<Product, Author, Category, Product>(
                @"SELECT 
                    P.*,
                    A.*,
                    C.*
                  FROM 
                    Products P
                    INNER JOIN Authors A ON P.AuthorId = A.Id
                    INNER JOIN Categories C ON P.CategoryId = C.Id",
                (product, author, category) =>
                {
                    product.Author = author;
                    product.Category = category;
                    return product;
                },
                splitOn: "Id,Id"
            ).ToList();
        }
        return products;
    }
}