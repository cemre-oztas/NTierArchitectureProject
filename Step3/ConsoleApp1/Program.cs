﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();

        Console.WriteLine("Hello, World!");
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        foreach (var product in productManager.GetProductDetails())
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
}