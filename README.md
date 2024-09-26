##Sistema de registro de reservas
Arquitectura de alto nivel 
![image](https://github.com/user-attachments/assets/648bca2c-ba0a-4d60-aab3-68dbeb36c433)


##Base de datos SQlite
Se escogio debido a la opcion de tener una base de datos en memoria para poder hacer pruebas del proyecto y su respuesta, se tiene el siguiente esquema de datos 
![image](https://github.com/user-attachments/assets/9fc287e8-821a-4e7f-a377-fe4d07d737f5)

##Servicio WCF soap .net framework 4.7
Se creó un servicio SOAP que permite la manipulación de datos y la inicialización de la base de datos en memoria a través de la biblioteca SQLite. Este servicio es responsable de:

Autenticación de Usuario: Verifica las credenciales del usuario y devuelve un token de sesión.
Operaciones CRUD de Reservas: Permite a los usuarios crear, leer, actualizar y eliminar reservas.
La arquitectura de este servicio se divide en:

Entidades: Clases que representan los modelos de datos (Usuarios, Reservas, Vuelos).
Interfaces: Definiciones de métodos que el servicio debe implementar, garantizando una separación de preocupaciones.
Implementación de Interfaces: Clases concretas que implementan las interfaces definidas, interactuando con la base de datos para realizar operaciones específicas.
Capa de Datos: Responsable de la comunicación directa con la base de datos SQLite.

Imagen wcf servicios 
![image](https://github.com/user-attachments/assets/303d199e-0738-4dcf-9c9a-bc2914503fdd)


##Api .net 6
Se desarrolló una API RESTful en .NET 6 que gestiona la seguridad y autenticación de usuarios. Esta API genera un JWT (JSON Web Token) para validar la información del cliente. Los componentes clave de la API incluyen:

Generación de Token JWT: Al autenticar a un usuario, se genera un token que permite realizar solicitudes autenticadas a la API.
Validación de Sesiones Activas: Mientras el token esté activo, el usuario puede realizar diversas consultas relacionadas con sus reservas.
Consumo del Servicio WCF: La API actúa como un cliente para el servicio WCF, obteniendo y manipulando entidades existentes a través de contratos de servicio.
Imagen swagger
![image](https://github.com/user-attachments/assets/e393d84f-d78b-4afe-b1e5-62dbe8842d3b)






