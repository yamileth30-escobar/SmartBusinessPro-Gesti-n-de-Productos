# SmartBusinessPro-Gestión de Productos 

Una empresa comercial necesita desarrollar un sistema de inventario que permita consultar los productos registrados en SQL Server. Se deberá preparar la estructura de acceso a datos utilizando Entity Framework Core, de modo que la aplicación pueda conectarse a la base de datos sin repetir la configuración en cada formulario.

La base de datos se denomina SmartBusinessPro y contiene una tabla Categorías y una tabla Productos, relacionadas mediante el campo CategoriaId.

La aplicación debe utilizar un contexto centralizado llamado SmartBusinessContext, responsable de establecer la conexión y exponer los conjuntos de entidades que se utilizarán para consultar los registros.
