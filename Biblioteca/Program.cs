using System;

class Program
{
    static void Main() 
    { 
        ShowMainMenu();
    } 

    static void ShowMainMenu()
    {
        byte opcion; 
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Prestamos");
            Console.WriteLine("4. Busquedas y reportes");
            Console.WriteLine("5. Guardar y cargar datos");
            Console.WriteLine("6. Salir");
            Console.Write("\nSelecciona una opcion (1-6): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: ShowBooksMenu(); break;
                case 2: ShowUsersMenu(); break;
                case 3: ShowLoansMenu(); break;
                case 4: ShowSearchReportsMenu(); break;
                case 5: ShowPersistenceMenu(); break;
                case 6: ConfirmExitAndSave(); break;
                default: 
                    Console.WriteLine("\nOpcion no valida. Presiona una tecla para intentar de nuevo...");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 6); 
    }

    static void ShowBooksMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle de libro");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver al Menu Principal");
            Console.Write("\nSelecciona una opcion (1-6): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: RegisterBook(); break;
                case 2: ListBooksMenu(); break;
                case 3: ViewBookDetail(); break;
                case 4: UpdateBookMenu(); break;
                case 5: DeleteBook(); break;
            }
        } while (opcion != 6);
    }

    static void RegisterBook() 
    { 
        Console.Clear();
        Console.WriteLine("--- Registrar Libro ---");
        Console.Write("Ingrese ISBN: ");
        Console.ReadLine();
        Console.Write("Ingrese Titulo: ");
        Console.ReadLine();
        Console.Write("Ingrese Autor: ");
        Console.ReadLine();
        Console.Write("Ingrese Categoria: ");
        Console.ReadLine();
        Console.Write("Ingrese Año: ");
        Console.ReadLine();
        Console.WriteLine("\nLibro registrado exitosamente.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListBooksMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("--- Submenu Listar Libros ---");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("4. Volver atras");
            Console.Write("\nSelecciona una opcion (1-4): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: ListBooksAll(); break;
                case 2: ListBooksAvailable(); break;
                case 3: ListBooksBorrowed(); break;
            }
        } while (opcion != 4);
    }

    static void ListBooksAll() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Todos los Libros ---");
        Console.WriteLine("ISBN: 978-013, Titulo: C# Guia Definitiva, Autor: Juan Perez, Categoria: Programacion, Anio: 2022, Disponible: True");
        Console.WriteLine("ISBN: 978-014, Titulo: Clean Code, Autor: Robert Martin, Categoria: Ingenieria, Anio: 2008, Disponible: False");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListBooksAvailable() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Libros Disponibles ---");
        Console.WriteLine("ISBN: 978-013, Titulo: C# Guia Definitiva, Autor: Juan Perez, Categoria: Programacion, Anio: 2022, Disponible: True");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListBooksBorrowed() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Libros Prestados ---");
        Console.WriteLine("ISBN: 978-014, Titulo: Clean Code, Autor: Robert Martin, Categoria: Ingenieria, Anio: 2008, Disponible: False");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ViewBookDetail() 
    { 
        Console.Clear();
        Console.WriteLine("--- Ver Detalle de Libro ---");
        Console.Write("Ingrese ISBN del libro a consultar: ");
        string isbn = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"\nDetalles del libro [{isbn}]:");
        Console.WriteLine("Titulo: Clean Code");
        Console.WriteLine("Autor: Robert Martin");
        Console.WriteLine("Categoria: Ingenieria");
        Console.WriteLine("Anio: 2008");
        Console.WriteLine("Disponible: False");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void UpdateBookMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("--- Submenu Actualizar Libro ---");
            Console.WriteLine("1. Editar titulo");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoria");
            Console.WriteLine("4. Volver atras");
            Console.Write("\nSelecciona una opcion (1-4): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: EditBookTitle(); break;
                case 2: EditBookAuthor(); break;
                case 3: EditBookYearCategory(); break;
            }
        } while (opcion != 4);
    }

    static void EditBookTitle() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Titulo de Libro ---");
        Console.Write("Ingrese ISBN del libro: ");
        Console.ReadLine();
        Console.Write("Ingrese nuevo titulo: ");
        Console.ReadLine();
        Console.WriteLine("\nTitulo actualizado con exito.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void EditBookAuthor() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Autor de Libro ---");
        Console.Write("Ingrese ISBN del libro: ");
        Console.ReadLine();
        Console.Write("Ingrese nuevo autor: ");
        Console.ReadLine();
        Console.WriteLine("\nAutor actualizado con exito.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void EditBookYearCategory() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Año / Categoria de Libro ---");
        Console.Write("Ingrese ISBN del libro: ");
        Console.ReadLine();
        Console.Write("Ingrese nuevo año: ");
        Console.ReadLine();
        Console.Write("Ingrese nueva categoria: ");
        Console.ReadLine();
        Console.WriteLine("\nAño y categoria actualizados con exito.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void DeleteBook() 
    { 
        Console.Clear();
        Console.WriteLine("--- Eliminar Libro ---");
        Console.Write("Ingrese ISBN del libro a eliminar: ");
        Console.ReadLine();
        Console.WriteLine("[Validacion] El libro esta prestado actualmente. No se puede eliminar.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ShowUsersMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE USUARIOS ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle de usuario");
            Console.WriteLine("4. Actualizar usuario...");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("6. Volver al Menu Principal");
            Console.Write("\nSelecciona una opcion (1-6): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: RegisterUser(); break;
                case 2: ListUsers(); break;
                case 3: ViewUserDetail(); break;
                case 4: UpdateUserMenu(); break;
                case 5: DeleteUser(); break;
            }
        } while (opcion != 6);
    }

    static void RegisterUser() 
    { 
        Console.Clear();
        Console.WriteLine("--- Registrar Usuario ---");
        Console.Write("Ingrese ID/Documento: ");
        Console.ReadLine();
        Console.Write("Ingrese Nombre: ");
        Console.ReadLine();
        Console.Write("Ingrese Telefono/Email: ");
        Console.ReadLine();
        Console.WriteLine("\nUsuario registrado exitosamente.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListUsers() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Usuarios ---");
        Console.WriteLine("ID: 1001, Nombre: Maria Gomez, Contacto: maria@mail.com, Activo: True");
        Console.WriteLine("ID: 1002, Nombre: Carlos Ruiz, Contacto: carlos@mail.com, Activo: True");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ViewUserDetail() 
    { 
        Console.Clear();
        Console.WriteLine("--- Ver Detalle de Usuario ---");
        Console.Write("Ingrese ID/Documento del usuario: ");
        string id = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"\nDetalles del usuario [{id}]:");
        Console.WriteLine("Nombre: Maria Gomez");
        Console.WriteLine("Telefono/Email: maria@mail.com");
        Console.WriteLine("Activo: True");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void UpdateUserMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("--- Submenu Actualizar Usuario ---");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar estado");
            Console.WriteLine("4. Volver atras");
            Console.Write("\nSelecciona una opcion (1-4): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: EditUserName(); break;
                case 2: EditUserContact(); break;
                case 3: ToggleUserActiveStatus(); break;
            }
        } while (opcion != 4);
    }

    static void EditUserName() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Nombre de Usuario ---");
        Console.Write("Ingrese ID/Documento: ");
        Console.ReadLine();
        Console.Write("Ingrese nuevo nombre: ");
        Console.ReadLine();
        Console.WriteLine("\nNombre actualizado con exito.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void EditUserContact() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Contacto de Usuario ---");
        Console.Write("Ingrese ID/Documento: ");
        Console.ReadLine();
        Console.Write("Ingrese nuevo telefono/email: ");
        Console.ReadLine();
        Console.WriteLine("\nContacto actualizado con exito.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ToggleUserActiveStatus() 
    { 
        Console.Clear();
        Console.WriteLine("--- Activar / Desactivar Usuario ---");
        Console.Write("Ingrese ID/Documento: ");
        Console.ReadLine();
        Console.WriteLine("\nEstado del usuario cambiado (Activo/Inactivo).");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void DeleteUser() 
    { 
        Console.Clear();
        Console.WriteLine("--- Eliminar Usuario ---");
        Console.Write("Ingrese ID/Documento: ");
        Console.ReadLine();
        Console.WriteLine("[Validacion] El usuario tiene prestamos activos. No se puede eliminar.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ShowLoansMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE PRESTAMOS ===");
            Console.WriteLine("1. Crear prestamo");
            Console.WriteLine("2. Listar prestamos...");
            Console.WriteLine("3. Ver detalle de prestamo");
            Console.WriteLine("4. Registrar devolucion");
            Console.WriteLine("5. Eliminar prestamo");
            Console.WriteLine("6. Volver al Menu Principal");
            Console.Write("\nSelecciona una opcion (1-6): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: CreateLoan(); break;
                case 2: ListLoansMenu(); break;
                case 3: ViewLoanDetail(); break;
                case 4: RegisterReturn(); break;
                case 5: DeleteLoan(); break;
            }
        } while (opcion != 6);
    }

    static void CreateLoan() 
    { 
        Console.Clear();
        Console.WriteLine("--- Crear Prestamo ---");
        Console.Write("Ingrese ID de Usuario: ");
        Console.ReadLine();
        Console.Write("Ingrese ISBN de Libro: ");
        Console.ReadLine();
        Console.WriteLine("[Validacion] Usuario existe y esta activo.");
        Console.WriteLine("[Validacion] Libro existe y esta disponible.");
        Console.WriteLine("Prestamo creado exitosamente.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListLoansMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("--- Submenu Listar Prestamos ---");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Cerrados (devueltos)");
            Console.WriteLine("4. Volver atras");
            Console.Write("\nSelecciona una opcion (1-4): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: ListLoansAll(); break;
                case 2: ListLoansActive(); break;
                case 3: ListLoansClosed(); break;
            }
        } while (opcion != 4);
    }

    static void ListLoansAll() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Todos los Prestamos ---");
        Console.WriteLine("ID: L01, Usuario: 1001, Libro: 978-014, Fecha: 2026-10-01, Limite: 2026-10-15, Devolucion: , Estado: Activo");
        Console.WriteLine("ID: L02, Usuario: 1002, Libro: 978-013, Fecha: 2026-09-10, Limite: 2026-09-24, Devolucion: 2026-09-20, Estado: Cerrado");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListLoansActive() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Prestamos Activos ---");
        Console.WriteLine("ID: L01, Usuario: 1001, Libro: 978-014, Fecha: 2026-10-01, Limite: 2026-10-15, Estado: Activo");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListLoansClosed() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Prestamos Cerrados ---");
        Console.WriteLine("ID: L02, Usuario: 1002, Libro: 978-013, Fecha: 2026-09-10, Limite: 2026-09-24, Devolucion: 2026-09-20, Estado: Cerrado");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ViewLoanDetail() 
    { 
        Console.Clear();
        Console.WriteLine("--- Ver Detalle de Prestamo ---");
        Console.Write("Ingrese ID de prestamo: ");
        string id = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"\nDetalles del prestamo [{id}]:");
        Console.WriteLine("IdUsuario: 1001");
        Console.WriteLine("IdLibro: 978-014");
        Console.WriteLine("FechaPrestamo: 2026-10-01");
        Console.WriteLine("FechaLimite: 2026-10-15");
        Console.WriteLine("FechaDevolucion: null");
        Console.WriteLine("Estado: Activo");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void RegisterReturn() 
    { 
        Console.Clear();
        Console.WriteLine("--- Registrar Devolucion ---");
        Console.Write("Ingrese ID de prestamo a devolver: ");
        Console.ReadLine();
        Console.WriteLine("Prestamo cambiado a 'devuelto'. Libro marcado como 'disponible'.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void DeleteLoan() 
    { 
        Console.Clear();
        Console.WriteLine("--- Eliminar Prestamo ---");
        Console.Write("Ingrese ID de prestamo a eliminar: ");
        Console.ReadLine();
        Console.WriteLine("Prestamo eliminado. Libro devuelto automaticamente (si estaba activo).");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ShowSearchReportsMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== BUSQUEDAS Y REPORTES ===");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Menu de reportes...");
            Console.WriteLine("4. Volver al Menu Principal");
            Console.Write("\nSelecciona una opcion (1-4): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: SearchBook(); break;
                case 2: SearchUser(); break;
                case 3: ReportsMenu(); break;
            }
        } while (opcion != 4);
    }

    static void SearchBook() 
    { 
        Console.Clear();
        Console.WriteLine("--- Buscar Libro ---");
        Console.Write("Ingrese termino de busqueda (titulo/autor/isbn/categoria): ");
        string term = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"\nResultados para [{term}]:");
        Console.WriteLine("ISBN: 978-013, Titulo: C# Guia Definitiva, Autor: Juan Perez, Categoria: Programacion, Anio: 2022, Disponible: True");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void SearchUser() 
    { 
        Console.Clear();
        Console.WriteLine("--- Buscar Usuario ---");
        Console.Write("Ingrese termino de busqueda (nombre/documento): ");
        string term = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"\nResultados para [{term}]:");
        Console.WriteLine("ID: 1001, Nombre: Maria Gomez, Contacto: maria@mail.com, Activo: True");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportsMenu()
    {
        ShowReportsMenu();
    }

    static void ShowReportsMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("--- Submenu de Reportes ---");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Reporte de prestamos vencidos");
            Console.WriteLine("4. Resumen general");
            Console.WriteLine("5. Volver atras");
            Console.Write("\nSelecciona una opcion (1-5): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: ReportByUser(); break;
                case 2: ReportByBook(); break;
                case 3: ReportOverdue(); break;
                case 4: ReportSummary(); break;
            }
        } while (opcion != 5);
    }

    static void ReportByUser() 
    { 
        Console.Clear();
        Console.WriteLine("--- Reporte por Usuario ---");
        Console.Write("Ingrese ID de usuario: ");
        Console.ReadLine();
        Console.WriteLine("Prestamos del usuario: 1 activo, 2 cerrados.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportByBook() 
    { 
        Console.Clear();
        Console.WriteLine("--- Reporte por Libro ---");
        Console.Write("Ingrese ISBN de libro: ");
        Console.ReadLine();
        Console.WriteLine("Historial del libro: Prestado 3 veces en total.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportOverdue() 
    { 
        Console.Clear();
        Console.WriteLine("--- Reporte de Prestamos Vencidos ---");
        Console.WriteLine("No hay prestamos vencidos actualmente.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportSummary() 
    { 
        Console.Clear();
        Console.WriteLine("--- Resumen General ---");
        Console.WriteLine("Total libros: 10");
        Console.WriteLine("Libros disponibles: 7");
        Console.WriteLine("Libros prestados: 3");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ShowPersistenceMenu()
    {
        byte opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("=== REPOSITORIO DE DATOS ===");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos (vaciar todo)");
            Console.WriteLine("4. Volver al Menu Principal");
            Console.Write("\nSelecciona una opcion (1-4): ");
            
            if (!byte.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: SaveData(); break;
                case 2: LoadData(); break;
                case 3: ResetData(); break;
            }
        } while (opcion != 4);
    }

    static void SaveData() 
    { 
        Console.Clear();
        Console.WriteLine("--- Guardar Datos ---");
        Console.WriteLine("Datos de libros, usuarios y prestamos guardados correctamente.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void LoadData() 
    { 
        Console.Clear();
        Console.WriteLine("--- Cargar Datos ---");
        Console.WriteLine("Datos cargados correctamente desde el almacenamiento.");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ResetData() 
    { 
        ConfirmResetData();
    }

    static void ConfirmResetData()
    {
        Console.Clear();
        Console.WriteLine("--- Reiniciar Datos ---");
        Console.Write("¿Está seguro de reiniciar/vaciar todos los datos? (S/N): ");
        string? resp = Console.ReadLine()?.Trim().ToUpper();
        if (resp == "S")
        {
            Console.WriteLine("\nDatos reiniciados con exito.");
        }
        else
        {
            Console.WriteLine("\nOperacion cancelada.");
        }
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ConfirmExitAndSave()
    {
        Console.Clear();
        Console.WriteLine("--- Salir ---");
        Console.Write("¿Guardar antes de salir? (S/N): ");
        string? resp = Console.ReadLine()?.Trim().ToUpper();
        if (resp == "S")
        {
            SaveData();
        }
        Console.WriteLine("\nSaliendo del sistema. ¡Hasta luego!");
    }
}
