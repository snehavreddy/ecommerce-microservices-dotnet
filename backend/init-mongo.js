db = db.getSiblingDB('EcommerceDB');

db.products.insertMany([
  {
    name: "Laptop",
    description: "High-performance laptop for professionals",
    price: 1299.99,
    imageUrl: "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=400",
    category: "Electronics",
    stock: 15
  },
  {
    name: "Smartphone",
    description: "Latest smartphone with advanced features",
    price: 899.99,
    imageUrl: "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=400",
    category: "Electronics",
    stock: 25
  },
  {
    name: "Headphones",
    description: "Noise-cancelling wireless headphones",
    price: 299.99,
    imageUrl: "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=400",
    category: "Accessories",
    stock: 50
  },
  {
    name: "Smart Watch",
    description: "Fitness tracking smartwatch",
    price: 399.99,
    imageUrl: "https://images.unsplash.com/photo-1523275335684-3789b6baf30e?w=400",
    category: "Wearables",
    stock: 30
  }
]);

printjson("Database initialized with sample products");