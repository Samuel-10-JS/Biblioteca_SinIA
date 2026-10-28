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
            Console.WriteLine("2. Listar libros...");
            Console.WriteLine("3. Ver detalle de libro");
            Console.WriteLine("4. Actualizar libro...");
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
        Console.WriteLine("[INFO] Funcionalidad de registro de libro (se implementara con POO).");
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
        Console.WriteLine("[INFO] Mostrando todos los libros registrados...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListBooksAvailable() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Libros Disponibles ---");
        Console.WriteLine("[INFO] Mostrando libros disponibles...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListBooksBorrowed() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Libros Prestados ---");
        Console.WriteLine("[INFO] Mostrando libros actualmente prestados...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ViewBookDetail() 
    { 
        Console.Clear();
        Console.WriteLine("--- Ver Detalle de Libro ---");
        Console.WriteLine("[INFO] Ingrese ID/ISBN para ver detalles del libro...");
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
        Console.WriteLine("[INFO] Actualizando titulo del libro...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void EditBookAuthor() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Autor de Libro ---");
        Console.WriteLine("[INFO] Actualizando autor del libro...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void EditBookYearCategory() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Año / Categoria de Libro ---");
        Console.WriteLine("[INFO] Actualizando año y/o categoria del libro...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void DeleteBook() 
    { 
        Console.Clear();
        Console.WriteLine("--- Eliminar Libro ---");
        Console.WriteLine("[INFO] Validando que el libro no este prestado para proceder a eliminarlo...");
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
        Console.WriteLine("[INFO] Registrando nuevo usuario con validaciones de datos...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListUsers() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Usuarios ---");
        Console.WriteLine("[INFO] Listando todos los usuarios registrados...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ViewUserDetail() 
    { 
        Console.Clear();
        Console.WriteLine("--- Ver Detalle de Usuario ---");
        Console.WriteLine("[INFO] Buscando usuario por ID/documento...");
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
        Console.WriteLine("[INFO] Modificando nombre del usuario...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void EditUserContact() 
    { 
        Console.Clear();
        Console.WriteLine("--- Editar Contacto de Usuario ---");
        Console.WriteLine("[INFO] Modificando telefono/email del usuario...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ToggleUserActiveStatus() 
    { 
        Console.Clear();
        Console.WriteLine("--- Activar / Desactivar Usuario ---");
        Console.WriteLine("[INFO] Cambiando estado activo/inactivo del usuario...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void DeleteUser() 
    { 
        Console.Clear();
        Console.WriteLine("--- Eliminar Usuario ---");
        Console.WriteLine("[INFO] Validando que el usuario no tenga prestamos activos...");
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
        Console.WriteLine("[VALIDACIONES] Verificando: usuario existe y esta activo; libro existe y esta disponible...");
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
        Console.WriteLine("[INFO] Mostrando historial completo de prestamos...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListLoansActive() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Prestamos Activos ---");
        Console.WriteLine("[INFO] Mostrando prestamos activos...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ListLoansClosed() 
    { 
        Console.Clear();
        Console.WriteLine("--- Listar Prestamos Cerrados ---");
        Console.WriteLine("[INFO] Mostrando prestamos devueltos/cerrados...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ViewLoanDetail() 
    { 
        Console.Clear();
        Console.WriteLine("--- Ver Detalle de Prestamo ---");
        Console.WriteLine("[INFO] Consultando detalle del prestamo por ID...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void RegisterReturn() 
    { 
        Console.Clear();
        Console.WriteLine("--- Registrar Devolucion ---");
        Console.WriteLine("[INFO] Cambiando estado de prestamo a 'devuelto' y libro a 'disponible'...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void DeleteLoan() 
    { 
        Console.Clear();
        Console.WriteLine("--- Eliminar Prestamo ---");
        Console.WriteLine("[INFO] Eliminando prestamo (si esta activo, se devolvera el libro automaticamente)...");
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
        Console.WriteLine("[INFO] Buscando por titulo, autor, ID/ISBN o categoria...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void SearchUser() 
    { 
        Console.Clear();
        Console.WriteLine("--- Buscar Usuario ---");
        Console.WriteLine("[INFO] Buscando por nombre o ID/documento...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportsMenu()
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
        Console.WriteLine("[INFO] Generando reporte de prestamos del usuario...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportByBook() 
    { 
        Console.Clear();
        Console.WriteLine("--- Reporte por Libro ---");
        Console.WriteLine("[INFO] Generando historial de prestamos del libro...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportOverdue() 
    { 
        Console.Clear();
        Console.WriteLine("--- Reporte de Prestamos Vencidos ---");
        Console.WriteLine("[INFO] Listando prestamos vencidos segun fecha limite...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ReportSummary() 
    { 
        Console.Clear();
        Console.WriteLine("--- Resumen General ---");
        Console.WriteLine("[INFO] Total libros / disponibles / prestados...");
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
        Console.WriteLine("[INFO] Guardando libros, usuarios y prestamos...");
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void LoadData() 
    { 
        Console.Clear();
        Console.WriteLine("--- Cargar Datos ---");
        Console.WriteLine("[INFO] Cargando datos del sistema...");
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
            Console.WriteLine("\n[INFO] Datos reiniciados con exito.");
        }
        else
        {
            Console.WriteLine("\n[INFO] Operacion cancelada.");
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
