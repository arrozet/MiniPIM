# MiniPIM for Product Management

This project is a MiniPIM (Product Information Management) system developed for the Requirements Engineering course at ETSII, UMA. It facilitates the management of products, categories, and relationships in a database.

## Features

- **Product Management**: create, edit, delete, and view products.
- **Custom Attributes**: configure and associate custom attributes with products.
- **Categories**: create and manage categories to organize products.
- **Product Relationships**: establish and manage relationships between products for advanced structures.
- **Data Export**: export products to JSON and CSV formats for integration with other systems.
- **UML Data Model**: UML diagrams to enhance the understanding of the system’s design.

## Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/arrozet/MiniPIM.git
   cd MiniPIM
   ```

2. **Open the solution in Visual Studio**:

   Open `MiniPIM.sln` in Visual Studio (Version 17 or higher is recommended).

3. **Set up the database**:

   - Ensure the database connection in `App.config` is configured properly.
   - Use the SQL scripts in the `database/` folder to create and populate the necessary tables.

4. **Build and Run**:

   - Build the solution in Visual Studio.
   - Run the application.

## Usage

1. **Account Management**: create accounts to store product and category information.
2. **Add Products**: use the form interface to add new products and associate custom attributes and categories.
3. **Relationships**: create relationships between products for structured management.
4. **Export**: export product data to external formats via the provided options.

## Configuration

The system’s configuration is handled through the `App.config` file, which includes:

- **Database Connection**: connection string for the MySQL database.
- **Entity Framework Settings**: version settings for compatibility.

## Dependencies

- **.NET Framework (4.8 or above)**: required as the runtime environment for the application.
- **Entity Framework (5.0.0.0 or above)**: used for data access and object-relational mapping (ORM).
- **MySQL**: database system for storing product and account information.

## License

This project is intended for educational purposes only. The author is not responsible for any misuse of the software.

## Acknowledgments

- Special thanks to the instructors who helped with the development of this project.
