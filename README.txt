ANTES DE CORRER EL PROGRAMA:
-Correr Base de Datos scriptAlgranati.sql (mySql)
-En caso de haber instalado la base de datos con contraseña, cambiarla en la clase ConexionBD.cs dentro de la carpeta Logica.
-En la linea "conexion = new MySqlConnection("server=127.0.0.1; port=3306; database= AlgranatiGroup; Uid=root; pwd='';");"   cambiar "pwd='contraseñaBD'.
-Lo mismo para el usuario en caso que no sea root.
-Crear una carpeta llamada Ticket para guardar los tickets generados por cada venta.
-Abrir el proyecto, buscar la carpeta Logica y dentro de esa la clase CrearTicket.cs
-Dentro de esa clase buscar la funcion ImprimirTicket.
-Cambiar la linea de codigo "string nombreArchivo = "E:\\AlgranatiGroupLTDA\\Tickets\\" + Persistencia.numeroTicket + ".txt";"
-Colocar la ruta de la carpeta Ticket y remplzarlo por "E:\\AlgranatiGroupLTDA\\Tickets\\" (recordar que deben ir doble \\ para
 separar los directorios en windows). 
-Guardar los cambios.
-Fijarse en las impresoras del sistema que este creada la imp "Microsoft XPS Document Writer" (esta imp se utilizara para generar
 el ticket en un archivo txt simulando una impresora termina de tickets.)
-Correr el programa normalmente.


---------------------------------------------------------------------------------------------------------------------------------
						Modulos faltantes y errores
---------------------------------------------------------------------------------------------------------------------------------
-