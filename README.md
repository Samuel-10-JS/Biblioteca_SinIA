# Sistema de Gestión de Biblioteca (Consola en C# - .NET 10)

Este documento ofrece una explicación detallada y paso a paso del diseño, arquitectura, evolución y funcionalidades del proyecto de consola para la gestión de una biblioteca, implementado en C# (.NET 10.0).

---

## 📖 Explicación General del Proyecto

### ¿Qué es este proyecto?
Es una aplicación de consola desarrollada en C# orientada a simular un **Sistema de Gestión de Biblioteca** completo. Permite administrar de forma estructurada e interactiva los recursos bibliográficos, los usuarios inscritos, los préstamos de libros, la realización de búsquedas, generación de reportes y la persistencia de datos, todo desde una interfaz de comandos limpia y amigable en la terminal.

### Arquitectura y Diseño Técnico
- **Lenguaje y Framework:** Desarrollado en C# utilizando .NET 10.0 (`net10.0`).
- **Estructura Modular:** El código fuente se encuentra centralizado en `Program.cs`, organizado mediante funciones estáticas (`static void`) especializadas para cada menú, submenú y operación CRUD o de negocio.
- **Flujo de Interacción:** 
  - Se emplea un patrón de bucles de control (`do-while`) combinados con estructuras de selección (`switch`) para mantener la navegación activa entre los diferentes menús sin cerrar la aplicación de forma imprevista.
  - Se utiliza `Console.Clear()` para limpiar la pantalla en cada transición de menú y `Console.ReadKey()` para pausar la ejecución y permitir al usuario leer los resultados antes de regresar.
  - Validación robusta de entradas numéricas con `byte.TryParse` para evitar excepciones por ingresos inválidos del usuario.

---

## 🏗️ Módulos del Sistema y Explicación Detallada

### 1. Módulo de Menú Principal (`ShowMainMenu`)
Es el punto de entrada de la aplicación. Muestra las 6 opciones principales del sistema y redirige al usuario al submenú correspondiente según su elección:
1. **Libros:** Gestión del inventario de libros.
2. **Usuarios:** Administración de los miembros de la biblioteca.
3. **Préstamos:** Control de la entrega y devolución de material bibliográfico.
4. **Búsquedas y Reportes:** Localización de elementos y estadísticas generales.
5. **Guardar y Cargar Datos:** Gestión del repositorio y persistencia.
6. **Salir:** Cierre seguro del sistema con opción de respaldo.

### 2. Módulo de Libros (`ShowBooksMenu`)
Permite administrar el catálogo de libros:
- **Registro:** Captura datos clave (ISBN, Título, Autor, Categoría, Año de publicación).
- **Listados Filtrados:** Permite ver todos los libros, únicamente los disponibles o los que se encuentran prestados actualmente.
- **Detalle y Actualización:** Consulta información específica por ISBN y permite modificar por separado el título, el autor o la categoría/año.
- **Eliminación con Validación:** Verifica si el libro está vinculado a un préstamo activo antes de permitir su borrado.

### 3. Módulo de Usuarios (`ShowUsersMenu`)
Administra el padrón de socios o lectores:
- **Registro:** Almacena ID/Documento de identidad, Nombre completo y datos de contacto (teléfono o correo electrónico).
- **Consulta y Detalle:** Lista todos los usuarios registrados o detalla la información de un usuario en particular.
- **Actualización de Datos:** Edición de nombres, datos de contacto o alternar el estado del usuario entre activo e inactivo.
- **Eliminación con Restricción:** Impide eliminar usuarios que posean préstamos activos vigentes.

### 4. Módulo de Préstamos (`ShowLoansMenu`)
Controla la circulación de libros:
- **Creación de Préstamos:** Realiza validaciones previas (comprueba que el usuario exista y esté activo, y que el libro exista y esté disponible).
- **Gestión de Estados:** Permite listar todos los préstamos, filtrar los activos o ver los cerrados (devueltos).
- **Devolución:** Registra la devolución de un libro, cambiando el estado del préstamo a cerrado y liberando el libro automáticamente para futuras solicitudes.

### 5. Módulo de Búsquedas y Reportes (`ShowSearchReportsMenu`)
Facilita la consulta rápida de información y auditoría:
- **Búsquedas Dinámicas:** Búsqueda por texto (título, autor, ISBN, categoría para libros; nombre o documento para usuarios).
- **Reportes Especializados:**
  - Historial de préstamos por usuario.
  - Historial de circulación por libro.
  - Detección de préstamos vencidos.
  - Resumen estadístico general (total de libros, disponibles y prestados).

### 6. Módulo de Persistencia y Salida (`ShowPersistenceMenu`)
- Simula operaciones de guardado y carga de datos hacia el almacenamiento.
- Opción de reinicio total de datos con una doble confirmación de seguridad (`S/N`).
- Flujo de salida con consulta interactiva (`¿Guardar antes de salir? (S/N)`).

---

## 🛠️ Evolución y Desarrollo Paso a Paso (Historial Git)

El proyecto fue construido de manera incremental mediante commits y ramas temáticas:
1. **Inicialización (`Comienzo` / `Estructura inicial`):** Creación del proyecto .NET 10 y configuración del entorno.
2. **Estructura Base (`feature/main-menu-navigation`):** Implementación del menú interactivo principal.
3. **Simulación de Funcionalidades (`feature/*-menu`):** Incorporación gradual de los flujos de libros, usuarios, préstamos, búsquedas, reportes y persistencia.

---

## 📊 Tabla de Requisitos Cumplidos

| Módulo | Requisito / Funcionalidad | Estado | Método Asociado (`Program.cs`) | Descripción del Comportamiento |
| :--- | :--- | :---: | :--- | :--- |
| **Menú Principal** | Navegación general entre módulos | ✅ | `ShowMainMenu()` | Menú interactivo con 6 opciones principales y manejo de opciones inválidas. |
| **Libros** | Registrar libro | ✅ | `RegisterBook()` | Captura ISBN, Título, Autor, Categoría y Año. |
| **Libros** | Listar libros (Todos / Disponibles / Prestados) | ✅ | `ListBooksMenu()`, `ListBooksAll()`, `ListBooksAvailable()`, `ListBooksBorrowed()` | Submenú con filtros de disponibilidad. |
| **Libros** | Ver detalle de libro | ✅ | `ViewBookDetail()` | Consulta la información completa de un libro mediante su ISBN. |
| **Libros** | Actualizar libro | ✅ | `UpdateBookMenu()`, `EditBookTitle()`, `EditBookAuthor()`, `EditBookYearCategory()` | Permite modificar título, autor, año o categoría de forma independiente. |
| **Libros** | Eliminar libro | ✅ | `DeleteBook()` | Valida si el libro está prestado antes de permitir la eliminación. |
| **Usuarios** | Registrar usuario | ✅ | `RegisterUser()` | Captura ID/Documento, Nombre y Contacto (Teléfono/Email). |
| **Usuarios** | Listar usuarios | ✅ | `ListUsers()` | Muestra el listado de usuarios registrados y su estado. |
| **Usuarios** | Ver detalle de usuario | ✅ | `ViewUserDetail()` | Consulta datos específicos de un usuario por ID. |
| **Usuarios** | Actualizar usuario | ✅ | `UpdateUserMenu()`, `EditUserName()`, `EditUserContact()`, `ToggleUserActiveStatus()` | Permite editar nombre, contacto o alternar estado activo/inactivo. |
| **Usuarios** | Eliminar usuario | ✅ | `DeleteUser()` | Valida si el usuario tiene préstamos activos antes de eliminar. |
| **Préstamos** | Crear préstamo | ✅ | `CreateLoan()` | Valida existencia/actividad del usuario y disponibilidad del libro. |
| **Préstamos** | Listar préstamos (Todos / Activos / Cerrados) | ✅ | `ListLoansMenu()`, `ListLoansAll()`, `ListLoansActive()`, `ListLoansClosed()` | Filtra los préstamos según su estado actual. |
| **Préstamos** | Ver detalle de préstamo | ✅ | `ViewLoanDetail()` | Muestra fechas de préstamo, límite, devolución y estado. |
| **Préstamos** | Registrar devolución | ✅ | `RegisterReturn()` | Cierra el préstamo y marca el libro como disponible automáticamente. |
| **Préstamos** | Eliminar préstamo | ✅ | `DeleteLoan()` | Elimina el registro del préstamo y libera el libro asociado. |
| **Búsquedas** | Buscar libro | ✅ | `SearchBook()` | Búsqueda por término (título, autor, ISBN o categoría). |
| **Búsquedas** | Buscar usuario | ✅ | `SearchUser()` | Búsqueda por nombre o documento de identidad. |
| **Reportes** | Reporte por usuario | ✅ | `ReportByUser()` | Historial de préstamos de un usuario específico. |
| **Reportes** | Reporte por libro | ✅ | `ReportByBook()` | Historial de veces prestado de un libro. |
| **Reportes** | Reportes de préstamos vencidos | ✅ | `ReportOverdue()` | Lista los préstamos que han excedido su fecha límite. |
| **Reportes** | Resumen general | ✅ | `ReportSummary()` | Estadísticas globales de libros (total, disponibles, prestados). |
| **Persistencia** | Guardar datos | ✅ | `SaveData()` | Simula el guardado de los datos del sistema en almacenamiento. |
| **Persistencia** | Cargar datos | ✅ | `LoadData()` | Simula la carga de datos persistidos. |
| **Persistencia** | Reiniciar datos | ✅ | `ResetData()`, `ConfirmResetData()` | Vacía todos los datos del sistema previa confirmación (`S/N`). |
| **Sistema** | Salir con guardado opcional | ✅ | `ConfirmExitAndSave()` | Pregunta al usuario si desea guardar antes de salir del sistema. |

---

## 🚀 Cómo Ejecutar el Proyecto

1. Asegúrate de tener instalado [.NET 10 SDK](https://dotnet.microsoft.com/) (o superior).
2. Abre una terminal y navega a la carpeta del proyecto (`Biblioteca`).
3. Ejecuta el comando:
   ```bash
   dotnet run
   ```

---

## 📂 Estructura del Repositorio

```text
Biblioteca_SinIA/
├── .gitignore
├── Biblioteca/
│   ├── Biblioteca.csproj
│   ├── Program.cs
│   ├── bin/
│   └── obj/
└── README.md
```
