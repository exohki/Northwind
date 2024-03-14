// 1) Every Product
//Products

// 2) The first Product
//Products.First()
//Products.FirstOrDefault()

// 3) The first 5 products
//Products.Take(5)

// 4) Every Product except the first 5
//Products.Skip(5)

// 5) Products 5-10
//Products.Skip(5).Take(5)

// 6) The last product
//Products.Skip(Products.Count() - 1)

// 7) Sum of all Products prices
//Products.Sum(p => p.UnitPrice)

// 8) Average price of Products
//Products.Average(p => p.UnitPrice)

// 9) Lowest price of Product
//Products.Min(p => p.UnitPrice)

// 10) Highest priced Product
//Products.Max(p => p.UnitPrice)

// 11) Every Product with price < 5
//Products.Where(p => p.UnitPrice < 5)

// 12) Any discontinued products?
//Products.Any(p => p.Discontinued)

// 13) How many discontinued products?
//Products.Count(p => p.Discontinued)

// 14) Are all products discontinued
//Products.All(p => p.Discontinued)

// 15) Are more than 10 products discontinued?
//Products.Count(p => p.Discontinued) > 10

// 16) Every Product sorted by price
//Products.OrderBy(p => p.UnitPrice)

// 17) Every Product in Seafood category
//Products.Where(p => p.Category.CategoryName == "Seafood")

// 18) Every Product in Seafood or Beverages category
//Products.Where(p => p.Category.CategoryName == "Seafood" || p.Category.CategoryName == "Beverages")

// 19) Every ProductName in Seafood or Beverages category
//Products.Where(p => p.Category.CategoryName == "Seafood" || p.Category.CategoryName == "Beverages").Select(p => p.ProductName)

// 20) Every CategoryName, ProductName in Seafood or Beverages category
//Products.Where(p => p.Category.CategoryName == "Seafood" || p.Category.CategoryName == "Beverages").Select(p => new { p.Category.CategoryName, p.ProductName })

// 21) Every CategoryName, ProductName sorted by category name
//Products.OrderBy(p => p.Category.CategoryName).Select(p => new { p.Category.CategoryName, p.ProductName })

// 22) Every CategoryName, ProductName sorted by category name, then by product name
//Products.OrderBy(p => p.Category.CategoryName).ThenBy(p => p.ProductName).Select(p => new { p.Category.CategoryName, p.ProductName })

// 23) Every Product that needs to be reordered sorted by units in stock
//Products.Where(p => p.UnitsInStock < p.ReorderLevel).Select(p => new { p.ProductName, p.UnitsInStock, p.ReorderLevel }).OrderBy(p => p.UnitsInStock)

// 24) Every Category, Product sorted by Category Name, then by Product Name
//Products.OrderBy(p => p.Category.CategoryName).ThenByDescending(p => p.ProductName).Select(p => new { p.Category.CategoryName, p.ProductName })

// 25) Every Product converted to uppercase
//Products.Select(p => p.ProductName.ToUpper())

// 26) Length of ProductName
//Products.Select(p => p.ProductName.Length)

// 27) ProductName(s) less than 6 characters
//Products.Where(p => p.ProductName.Length < 6).Select(p => p.ProductName)

// 28) Shortest ProductName
//Products.OrderBy(p => p.ProductName.Length).Select(p => new { product = p.ProductName, name_length = p.ProductName.Length }).First()

// 29) Longest ProductName
//Products.OrderByDescending(p => p.ProductName.Length).Select(p => new { p.ProductName, p.ProductName.Length }).First()

// 30) Every CategoryName, ProductName in a category that starts with the letter 'C' sorted by CategoryName, then ProductName
//Products.OrderBy(p => p.Category.CategoryName).ThenBy(p => p.ProductName).Where(p => p.Category.CategoryName[0] == 'C').Select(p => new { p.Category.CategoryName, p.ProductName })

// 31) Beverages that are under $8
//Products.Where(p => p.Category.CategoryName == "Beverages" && p.UnitPrice < 8).Select(p => new { p.ProductName, p.UnitPrice })

// 32) The most expensive Condiment price
//Products.Where(p => p.Category.CategoryName == "Condiments").Max(p => p.UnitPrice)
