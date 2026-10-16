using System;
using System.Collections.Generic;

// ╰ Simulacion de db uwu ╯
namespace NicaCompare
{
    public static class sesion_actual // variable global para manejar la sesion del usuario actual
    {
        public static string Correo = "";
        public static string Nombre = "";
        public static string TipoUsuario = "";
        public static int Saldo = 0;
        public static int Telefono = 0;
        public static int Busquedas_restantes = 5;
        public static DateTime fecha_registro = DateTime.Today;
        public static string Img = "no hay usuario";
    }

    public static class usuarios_db // guardamos todo los datos de los usuarios en un diccionario en cache
    {
        public static Dictionary<string, (string Nombre, string Password, string TipoUsuario, int Saldo, int Telefono, DateTime fecha_registro, int Busquedas_restantes, string Img)> Usuarios =
            new Dictionary<string, (string Nombre, string Password, string TipoUsuario, int Saldo, int Telefono, DateTime fecha_registro, int Busquedas_restantes, string Img)>
        {
            { "1", ("Skl ◕⩊◕", "1", "Gratis", 90, 81234567, new DateTime(2026, 9, 14), 6, "skl") },
            { "skl@unan.ni", ("Skl ◕⩊◕", "17", "Gratis", 90, 81234567, new DateTime(2026, 9, 14), 6, "skl") },
            { "oto@.unan.ni", ("Oto (๑﹏๑)", "123", "Gratis", 20, 81234567, new DateTime(2026, 9, 14), 4, "") },
            { "jahary@.unan.ni", ("Jahary (✿ᴗ͈ˬᴗ͈)⁾", "123", "Gratis", 30, 81234567, new DateTime(2026, 9, 14), 8, "") },
            { "moises@.unan.ni", ("Moises (•̀ ᗜ •́ )", "123", "Gratis", 50, 81234567, new DateTime(2026, 9, 14), 9, "") }
        };
    }

    public static class GestorUsuario // funcion para verificar inicio de secion
    {
        public static bool ValidarSesion() // veriificamos si hay una sesion iniciada (true), si no hay devuelve false XD
        {
            if (string.IsNullOrEmpty(sesion_actual.Nombre)) { return false; }
            return true;
        }

        public static void Actualizar( // Actializar dts de usuarios y de sesion
            string? correo = null,
            string? Nombre = null,
            string? Password = null,
            string? TipoUsuario = null,
            int? Saldo = null,
            int? Telefono = null,
            int? Busquedas = null,
            string? Img = null)
        {

            if (!ValidarSesion() && Busquedas.HasValue) { sesion_actual.Busquedas_restantes = Busquedas.Value; return; } // si es solo actualizar la busqueda
            

            if (!string.IsNullOrEmpty(correo) && usuarios_db.Usuarios.ContainsKey(correo)) // Si hay Inicio de secion valido. actualizamos en el Diccionario (DB)
            {
                var actual = usuarios_db.Usuarios[correo];

                string nombreFinal = Nombre ?? actual.Nombre;
                string passFinal = Password ?? actual.Password;
                string tipoFinal = TipoUsuario ?? actual.TipoUsuario;
                int saldoFinal = Saldo ?? actual.Saldo;
                int telFinal = Telefono ?? actual.Telefono;
                int busquedasFinal = Busquedas ?? actual.Busquedas_restantes;
                string imgFinal = Img ?? actual.Img;

                // Actualizamos en el diccionario
                usuarios_db.Usuarios[correo] = (nombreFinal, passFinal, tipoFinal, saldoFinal, telFinal, actual.fecha_registro, busquedasFinal, imgFinal);

                // Actualizar Sesion actual si es el mismo usuario
                if (sesion_actual.Correo == correo)
                {
                    sesion_actual.Nombre = nombreFinal;
                    sesion_actual.TipoUsuario = tipoFinal;
                    sesion_actual.Saldo = saldoFinal;
                    sesion_actual.Telefono = telFinal;
                    sesion_actual.Busquedas_restantes = busquedasFinal;
                    sesion_actual.Img = imgFinal;
                }
            }            
            
        }
    }

    }



//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⣉⢏⣖⢤⣀⡠⣀⣀⣀⣀⢀⡀⡱⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣀⣀⡀⣠⣠⠦⣖⢵⣻⣚⣮⡺⡱⡵⣻⣾⢮⣳⢝⣴⡳⢽⢪⢧⡳⡵⣲⣢⡢⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡠⡔⣮⣺⠼⣼⣜⣟⣝⣯⣷⣿⣾⣯⣿⣳⢷⣽⣻⣽⣻⢾⣽⣻⢾⣕⢽⢟⡮⣳⢻⣳⡷⣽⣕⣖⢤⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⡠⣰⣪⢧⢗⢟⣳⣳⣻⣺⡻⡿⡿⣿⣾⣾⣿⣽⣿⣟⣿⣺⣽⢾⡯⣿⣺⣽⢯⣟⣷⣻⢯⣯⣖⡮⢯⣓⠻⢞⣯⡯⣗⣕⢤⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠒⠷⡵⣽⣽⣞⣾⣞⣟⣟⣿⣾⣿⣻⣿⣿⣿⣿⣟⣯⣿⣟⣷⣿⣽⣻⢾⣻⢿⣽⣾⣻⣿⣗⡿⣞⣟⣷⣻⣞⡷⣵⣝⣆⡄⡙⠹⢽⡻⣞⣖⢆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⢖⣽⢾⢗⡽⡽⣻⣻⣿⢿⣿⣾⣷⣿⣿⣯⣿⣽⢿⣟⣿⣻⢯⡿⣽⢯⡿⣽⣯⣟⣿⣿⣟⣿⣽⣿⡽⣞⡷⣯⢿⢽⡲⣕⢷⣟⣶⢤⣈⠙⢾⣻⢾⡱⡄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⣪⡾⡽⣫⢞⢽⣺⣽⣿⣷⣿⣿⣿⣾⣿⣽⣾⣿⣻⣽⣿⣷⢿⣞⣿⢽⡯⣿⢽⣻⣞⣿⣿⣯⣿⣿⡿⣷⡿⣿⡽⣯⣟⢿⡽⣷⣳⡹⣯⣿⣳⢷⡤⡈⠫⡿⣽⣎⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⢺⡫⣝⡮⣷⣿⣿⣿⢿⣿⣾⢿⣷⣿⣷⣿⢿⣻⣿⢿⣿⣟⣽⢯⣗⣟⣯⡿⣽⣻⣽⣻⣽⡷⣿⣻⢷⣿⢿⣟⣷⣻⣗⡯⡷⡿⣽⣫⣟⣮⣻⣽⣿⣽⣻⢦⡌⠑⣟⡾⣝⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣔⡽⡶⡯⠋⣪⢽⣲⡵⣫⣿⣿⣿⣽⣿⢿⣷⣿⢿⣿⡿⣿⣿⢷⣿⣾⣿⣿⣽⣷⣿⣿⣿⡽⣷⢿⣽⢯⣟⣯⢿⡯⣷⣟⣾⢽⡽⡿⣽⣻⢾⣵⣻⡷⣿⢾⣯⡿⣯⣟⣧⣄⠙⣟⣮⢧⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⢺⣼⣻⠝⣠⣺⡞⡧⡯⣾⣿⢿⣯⣿⣽⣟⣿⣻⣽⣿⡿⣿⡿⣿⡿⣿⣻⣽⣿⣽⣿⣽⢿⣞⣯⣿⣻⢾⣻⣽⡽⣯⣟⣷⣻⣞⣯⣟⣿⢽⣟⡿⣾⣳⡻⣟⣿⢷⣿⣻⣽⡷⣗⣧⡈⠺⡯⣯⡢⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⣳⣻⠞⢁⢴⣳⡟⡼⣽⣽⣿⣿⢿⣿⣟⣾⣟⣿⣯⣿⡿⣿⣻⣿⡿⣿⡿⣿⣿⢿⣻⣾⣽⡿⣽⣞⣷⣻⣻⣿⣗⣿⣳⣟⣾⣗⡿⣾⣽⢾⣿⡽⣿⡵⣽⣻⡻⣽⣿⣽⣯⣷⡿⣟⣷⢯⣆⠙⣗⣯⡣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣹⡽⠞⢠⣞⣿⢹⢼⣽⣿⣿⢯⣿⣿⣟⣿⡿⣿⣿⣯⣿⣿⣿⢿⡿⣟⣿⣟⣿⣻⢟⣯⣿⡽⣿⣽⣯⣿⣽⣟⣿⣿⣻⣷⣻⢾⣿⣽⣻⣿⣯⣿⣿⣿⣿⢺⣯⣿⣻⡾⣷⢿⡾⣟⣿⣻⣟⣾⣥⠈⢾⣻⡲⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⡰⣳⢯⠏⣠⢿⡺⡵⣻⣻⣭⢧⢗⣿⣿⣯⣿⣿⣿⣿⣿⡽⠟⠓⣿⣏⠩⡿⢁⣴⣟⡇⢸⣟⣾⢯⣷⢷⣟⣾⡽⣯⡿⣽⣿⣿⣽⣟⣿⣿⣽⣻⣯⣿⣾⣿⣿⡧⣿⡾⣯⣿⣻⣟⣿⣻⣽⣯⣿⣳⣯⢷⡀⢫⣷⣣⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⢰⢽⢯⠏⡠⣷⢷⣻⡿⣽⡷⣟⢾⣝⣾⣿⣯⣿⣿⣽⣷⣿⡁⠺⠿⣽⢿⠀⡀⠺⣯⣟⣇⠐⣯⣟⣯⡿⣯⢿⣞⣿⣽⣻⣯⣟⣿⣽⣾⡷⣟⣿⣯⣷⣿⣽⣗⣿⢿⣺⣟⣯⣿⣽⣻⣾⣻⣽⣾⢯⣿⢾⣟⣶⡀⢻⣞⣖⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⢠⢫⡿⡝⢠⢿⣽⢿⣻⣟⣯⣿⡧⡷⣗⣿⣿⣻⣿⣟⣿⣯⣿⠿⣶⡆⢸⣻⡀⢻⣦⣈⣫⣿⣠⣤⣤⣯⡿⣽⢿⣽⢾⡷⣿⣞⣯⡿⣯⣷⣿⢿⣿⣽⣯⣷⣿⣷⣮⡟⣯⣿⣳⡿⣾⣻⡾⣿⣽⣾⢿⣻⣿⡽⣗⣧⠈⢾⣳⢥⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⣎⣯⡟⢀⡯⣿⢾⡿⣯⣿⣽⢷⣳⢽⣺⣿⣿⡿⣿⡿⣿⣯⣿⣷⣤⣴⣿⣿⢿⣿⣽⣯⣷⡿⡫⠫⠣⠫⠫⣫⣻⣯⣓⡹⢿⢟⣿⣟⣿⣻⣻⡟⢅⡢⡌⡿⣿⡿⣿⣿⣾⢼⣹⢻⣯⣿⣻⡾⣷⢿⣻⡿⣾⣟⣿⣽⢥⠘⣽⡞⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⢐⢷⣳⠃⡼⣽⣟⣿⣻⡿⣞⣿⣻⡞⣮⣿⢿⡺⣿⣿⣿⣿⡿⣾⡻⡝⡝⠬⣿⢿⣯⣷⣟⢿⠑⡈⢌⣨⣼⡾⠏⣋⣐⣄⣂⣙⣬⣿⣽⣽⣯⡟⢠⡺⠊⢞⢸⣽⣿⡿⣿⣾⣿⣿⣷⣶⣭⣫⡻⣟⣿⣻⣟⣿⣞⣿⣞⣯⠆⢳⣻⣕⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⠀⡳⣻⡝⢠⣻⢷⣻⣽⡷⣿⣟⣯⣿⣱⡿⣯⢻⣺⣿⡿⣿⣷⢟⢟⠿⣷⣧⣦⣙⣎⢿⣷⠏⣂⣵⣾⢿⢟⣳⣯⣭⣭⡷⢷⢿⡟⡫⢹⡯⣷⡟⠂⡯⡻⡬⢘⣸⣿⣟⣿⣮⡻⣻⣷⣿⡽⣷⣟⣯⡷⣾⡼⣝⡞⡯⣷⡿⣽⣣⠘⣞⣞⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⢰⣹⣟⠆⣸⡽⣟⣿⣳⣿⣯⣿⣽⣮⡾⣟⣯⢝⣿⡗⣟⣿⣿⣯⢯⣿⢞⢾⣯⣿⣿⣾⢿⢶⣻⡍⡰⡽⢋⢀⣈⡚⡹⠕⠩⢸⠅⢂⠹⠐⡿⠠⠡⡼⣱⢃⣡⣷⡻⣿⣿⣿⣯⡗⣷⣽⡻⣷⣟⡷⣿⢷⣟⣯⣿⣻⣶⣽⣝⣞⢄⢳⡯⡧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⢰⢵⣻⠀⣗⣿⢿⣽⢿⣾⣳⡿⣞⣯⣿⣟⣧⡿⣯⣷⢻⣽⣧⢿⣷⢘⢇⡄⢙⠳⣑⡿⡅⡑⠹⢷⡂⠌⡂⡂⡂⡐⡐⠨⣈⢞⠨⢐⣨⣔⠡⠁⠞⡉⣐⡴⣯⡿⣯⡻⣯⣿⣟⣿⣮⡺⣟⣷⣭⣟⡯⡿⣽⢷⣯⡷⣟⣾⣽⢾⡿⡾⣮⣫⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⡪⣯⢷⢀⢿⡾⣟⣿⢯⣷⢯⣿⣻⣟⣾⣻⣾⣻⣯⡿⣾⢾⣻⣮⢞⡇⢕⠨⢐⠐⣰⣯⣶⡷⣾⢮⣽⣖⣖⣖⣖⣖⣚⣭⡵⣶⢾⣟⣯⣿⡎⣸⣤⣶⣾⣯⣻⣻⣽⢻⣝⢿⣟⣿⣿⣽⣮⡳⡿⣞⣿⣽⣾⣽⢵⣻⢿⣷⣟⣯⣿⣻⣯⢿⣽⣗⣦⣀⠀⠀⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⣝⣽⡳⢨⢿⣽⢿⣽⣟⣿⢯⣷⡿⣽⣯⡿⣾⣻⣾⣻⣽⣟⣿⣺⣝⢿⣾⣯⣽⣽⣿⣿⣯⣿⣻⢿⣽⢯⣿⡽⣯⣿⡽⣷⣟⡿⣯⣿⣻⡾⣿⠣⣿⣿⣽⣾⣿⣷⣿⣽⣗⣷⢝⣿⣻⣽⣾⢿⣮⣛⢷⡿⣾⣽⢿⣻⣟⣾⡽⡿⣿⣷⣿⣯⣷⣟⣷⣻⣶⣢⠀⠀⠀⠀⠀⠀
//⠀⠀⠀⠀⢮⣞⣗⠸⣽⡾⣿⢯⣿⢾⢿⣯⣿⣻⣾⣻⣯⣷⢿⣽⢷⣿⡽⣯⣟⣗⢯⣿⣾⣿⣟⣿⣾⣳⣿⣻⣽⣟⣷⢿⣻⣾⣻⣽⡾⣟⣿⣺⡷⣿⡳⠡⢹⣿⣾⣿⣿⣟⣿⣫⢾⣺⢽⣮⣻⣯⡿⣟⣷⣟⣷⣝⡻⣾⣟⣯⣿⣽⣟⣯⡏⢟⣯⣿⣿⣿⣾⣟⣾⢯⣿⢦⣀⠀⠀⠀
//⠀⠀⠀⠀⢕⣟⣮⠨⣞⣿⣻⡿⣽⣿⣻⡷⣿⣽⡾⣿⣞⣯⣿⣻⣯⣷⢿⡯⣿⢽⣝⢾⣻⣯⣿⣿⢿⣷⢯⡿⣾⣽⡾⣟⣿⣞⣯⣷⢿⣻⣽⢷⣿⢏⢎⠨⢸⣿⡿⣟⡽⣞⡾⣞⡯⡿⣽⢾⡷⣽⡻⣯⡿⣾⢯⣿⣽⣮⡫⡿⣾⢷⣟⣷⡃⢸⢮⣛⢿⣾⣿⡿⣿⣿⣽⣻⢷⡧⡄⠀
//⠀⠀⠀⠀⢸⢺⣳⠀⣗⣿⣽⣟⢿⣾⣻⣽⡿⣞⣯⣷⢿⣽⣯⣷⢷⡷⣗⢟⣮⣷⣿⣿⣯⡿⣿⡿⣿⣿⣻⣯⢿⣞⡿⣯⡷⣿⣽⢾⣿⣻⣽⣿⢯⠪⢐⣨⡾⡯⣟⣗⡿⡽⣝⣗⣯⡯⣿⡽⣟⣯⣿⣽⡻⣽⣟⣷⢷⣻⡿⣾⣝⢿⣽⣞⠇⣸⣟⢮⠑⢝⣿⣿⣿⣟⣿⣽⡿⣽⢿⣥
//⠀⠀⠀⠀⠨⣫⣟⡆⢱⣟⣾⣻⡿⣽⣯⣷⡿⣟⣯⣿⣻⡷⣿⢾⢻⣹⣾⣿⡿⣿⣾⣿⣟⣿⣽⣻⣿⣿⣿⣾⣻⣽⢿⣽⣻⣷⣻⣯⣷⣿⣿⢏⣮⢷⣻⣳⡯⡿⣝⡾⡽⣝⣗⢷⣽⢯⣷⢿⣟⣯⣷⣟⣯⣷⡫⣿⣻⣽⣟⣷⣿⢷⣎⢾⠀⣷⣻⢕⠀⠀⠘⣻⣾⣿⣿⣿⣿⣿⣻⣽
//⠀⠀⠀⠀⠀⢇⣿⢦⠘⡾⣽⣯⡿⣯⣷⢿⣻⣟⣯⣿⣽⢟⡽⡾⣿⣿⣿⣻⣿⣿⣿⣽⣿⣿⡿⣿⣽⣷⣿⣯⡿⣾⣻⣽⢷⣯⣷⣿⣿⡿⣗⣯⢷⡯⡷⡯⡾⣝⢷⢽⢽⣺⣺⣽⣯⣏⢿⣻⣽⣯⣷⡿⣯⣿⣻⣮⣝⢾⣻⣞⣿⢿⣯⣷⢧⡻⡮⡇⠀⠀⡀⠀⢛⡿⣷⣿⣯⣿⣯⣿
//⠀⠀⠀⠀⠀⠸⣺⢯⠆⢹⢷⣻⣽⡿⣾⡿⣟⣯⣿⢷⣧⣻⣞⢿⢽⣻⣽⣿⣿⣷⣿⣿⣻⣾⣿⣿⣿⣷⣿⢿⣻⣽⣯⣿⣿⣿⣿⣿⣿⢾⢽⣞⡯⡯⡯⡯⣻⣺⢽⣝⣗⣷⢿⣺⢾⣽⣽⣹⡳⣟⣷⢿⣻⣾⣻⣽⣯⣷⣝⢿⡾⣿⣿⣿⣻⣟⣮⠄⠀⠀⠀⠀⠀⢙⢿⣟⣿⣿⣻⣾
//⠀⠀⠀⠀⠀⠀⢳⣻⣗⠈⢿⡽⣯⣿⣯⣿⣟⣯⣿⣻⣽⡷⣗⣟⣽⢽⡯⣿⣷⣿⣿⣾⣿⣿⢿⣯⣿⣿⣿⣿⣿⣿⣿⣿⣯⣿⣾⣿⣾⣻⣽⣺⢽⢽⢽⢝⡷⣝⣗⡷⣟⣾⢿⢽⡽⣺⢽⣝⣟⢾⢮⣛⡯⢿⣽⣯⣷⣿⣽⣮⡻⣟⣾⣿⣿⣽⣯⡿⣦⠈⠀⠈⠀⠀⢙⣯⣿⡿⣿⡽
//⠀⠀⠀⠀⠀⠀⠘⡼⣞⣇⠘⣽⢿⡾⣷⣟⣷⢿⣽⣿⣽⣟⣿⣗⣯⡳⣟⣽⣟⣯⣷⣿⣿⣻⣿⣿⣿⣯⣿⣿⣿⣿⢿⣷⣿⡿⣟⣯⣷⢗⣿⡺⡽⡽⡽⣽⣺⡳⡯⣯⡷⡯⡯⣗⡯⣯⣻⣺⡺⡽⡽⣮⣻⡳⣧⣯⡳⢿⣽⣯⢿⠮⣻⣽⣿⣷⣯⣿⣻⣯⡆⠀⠀⠂⠀⢽⡾⣟⣿⠃
//⠀⠀⠀⠀⠀⠀⠀⠸⣹⡽⣆⠘⣯⢿⣯⣿⣽⣿⣻⣾⢷⡿⣷⢿⣯⢿⡼⢾⣺⣟⣿⣿⡿⣿⣿⣿⣻⣿⣽⣿⣷⣿⣿⣿⣟⣿⣿⣻⣽⣻⡮⡯⡯⣯⣻⡺⣮⣯⣿⢯⢯⢯⢯⣗⡯⣗⣗⣗⢯⢯⣻⡺⣮⣻⡺⡮⡯⣗⣶⣽⡹⡠⣷⣝⣿⣯⣿⣾⣻⣾⣻⣧⡀⠄⠀⠐⣿⠛⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠱⡽⡷⣆⠙⣽⢷⢿⡾⣯⣿⣺⡿⣿⣻⡿⣽⣟⢟⣏⣷⣻⣽⣿⣿⣿⣿⢿⣿⣿⣿⣽⣿⣯⣿⣾⣿⡿⣟⣿⣳⣳⢯⢯⣻⡺⣮⡿⣯⣟⢾⢽⢽⣝⣗⢷⣝⣗⢷⢽⢽⢽⢮⣻⡺⡮⡯⡯⣯⢷⣗⢷⢿⢿⣮⣳⠪⢿⣿⣯⡿⣾⣻⡾⣷⣂⠀⠀⠁⠀⠀⠄
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠳⢽⢯⣆⠘⢟⣟⣿⢾⣻⣽⣿⣻⢽⢻⣹⡼⣯⣷⣿⣿⢾⡷⣿⣿⢿⣿⣿⣷⣿⣿⣯⣿⣟⣯⣿⣽⣿⣗⣟⡾⡽⣽⣺⣽⣟⣿⢽⣺⡽⡯⣗⡷⣝⣗⢷⢽⢽⢽⢽⣝⣗⣗⡯⡯⡯⣟⡽⣳⢽⢽⣝⡷⡽⣷⡂⠩⢿⣿⢿⣽⢷⣿⣻⣽⣦⠐⠀⠐⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡯⣯⣧⡈⢻⣺⢿⡻⡗⣏⡾⣞⣯⣷⣿⣷⣿⣿⣿⣿⣻⣿⣿⣿⣿⣽⡿⣽⣷⡿⣷⣿⡿⣟⣿⡿⣺⣳⣻⣽⣳⣿⣯⣿⡾⡿⡽⡽⣝⡷⣝⡷⡽⡽⡽⡽⣝⣗⣗⣗⡷⣯⣻⢽⡳⡯⡯⡯⣗⣗⡯⣯⣻⣯⡀⠩⣿⣿⣽⣟⣷⣟⡗⠋⢀⠀⠀⠄⠐
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢮⣺⢷⣄⠙⢽⣱⣟⣯⢿⣽⡿⣾⢿⣽⣿⣽⣷⡿⣿⣿⣿⣿⣽⣿⡿⣿⣟⣿⣿⣟⣿⣻⣿⢯⢯⣿⢾⣾⣟⣷⡿⣳⢯⢯⢯⢯⣗⡯⣗⡯⡯⡯⡯⡯⣗⣷⣳⡯⣟⣞⢾⢽⢽⢽⢽⠽⣳⣳⢯⢷⣗⡿⣖⠀⢚⣿⡷⡻⠙⠀⠀⢀⠀⠀⡀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠳⡹⣷⡳⣱⢯⣗⣿⣟⣯⣿⢿⣻⣿⢾⣳⣿⣿⣿⢿⣾⣿⣻⣷⣿⣿⣟⣯⣷⣿⣿⢿⢯⢯⣿⣻⣟⣷⢿⣽⣺⢽⡽⣝⣯⣻⣺⣺⡳⡯⡯⡯⡯⣯⡿⣵⣿⢽⣳⢽⢽⢽⢽⢽⡝⡁⢟⡾⣝⣗⡿⣽⣻⡂⠀⠃⠁⠀⠀⠀⢀⠀⠀⡀⠀⠀⠁
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢳⢵⡯⣿⣽⣿⣽⣿⣽⡿⣿⣽⢯⢾⣷⣿⣿⣿⡿⣿⣟⣿⣽⡾⣯⣿⣟⣿⡯⡿⡽⣽⣯⣟⣗⡿⡯⣞⡾⣽⣺⢽⣺⣺⡺⡮⡯⡯⡯⡯⣿⣻⣽⣿⣳⣻⣺⢽⣫⡯⣯⢷⠡⠐⡈⣟⡮⡷⡟⣟⣿⣯⠀⠀⠀⢀⠀⠄⠀⠀⠀⠀⢀⠐⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣬⣟⣾⡷⣿⣷⣿⡾⣯⣿⣟⣯⢯⣿⣿⡿⣷⣿⣻⣽⣾⣻⡾⣟⣿⣷⣿⣿⣟⡽⣽⣟⡵⣗⡿⡽⣝⣗⣟⣞⢾⢽⣺⣺⢽⡯⡯⡯⣯⣿⣟⣿⣯⣷⣳⣗⡯⡿⢺⢯⣗⣟⣎⠄⠂⢯⢯⢯⡗⢈⢿⣽⣅⠀⠁⠀⠀⠀⠀⠈⠀⠈⠀⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⣟⡾⣿⣯⣿⣾⣷⣿⢿⣷⡿⡽⣽⣿⣻⣿⣿⣳⣿⣽⡾⣯⣿⣻⣿⣽⣿⡽⡮⣯⣟⡮⣯⢯⢯⢯⣗⡷⣳⡽⡽⣽⣺⢾⢽⣿⢽⣫⣷⣿⣻⣽⣾⣞⡾⣮⡻⠀⢯⣗⢷⣳⢯⢂⢣⡠⢉⠩⠐⡠⠈⢿⣗⡀⠀⠄⠐⠀⠁⠀⠂⠀⠠⠀⠐
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣽⣯⣿⣿⣷⣿⣟⣷⡿⣟⣷⣟⣽⣾⣿⡿⣟⣷⣟⣷⣯⣿⣻⣾⣿⣿⣟⣿⢽⢽⣟⡾⡽⡽⡽⣽⢽⣺⣝⣗⣯⢯⣗⡯⡯⣟⣯⡿⣾⣟⣿⣟⣿⣗⣯⡿⣺⢇⠨⢈⠺⠿⢚⠋⡠⣠⡿⡆⠂⠝⢄⠅⢪⣿⠆⠀⠀⠀⢀⠀⠄⠀⠄⠀⢀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⡷⣿⣿⣾⣯⣿⣽⢿⣿⣻⡺⣾⣿⣟⣿⣿⣻⡾⣷⢿⣾⣿⣿⣻⣷⣿⢯⢯⣿⣳⣻⢯⣻⢽⣳⣻⡾⣞⣗⡯⣟⣮⣟⣯⣿⢿⣟⣿⣽⣿⣟⣿⡾⡇⡿⡽⡽⢇⢁⠂⠅⡂⣢⣺⣞⣏⣄⣅⣵⢾⣗⣯⣻⠅⠀⠀⠁⠀⠀⠀⠀⡀⠠⠀⠀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣽⣿⡿⣿⣿⣿⣞⣿⣾⢿⣻⣞⣽⣿⣯⣿⡿⣷⣻⣟⣿⣿⣿⣯⣿⣿⢿⡯⣯⣿⣟⣾⢯⣟⢾⣽⣾⢯⡯⣷⣯⢿⣯⣷⣿⣻⣾⣿⣿⣟⣿⣿⢿⡯⣯⡇⠌⡩⢉⠐⡄⢅⢥⣞⢷⣽⣯⡷⣟⣾⣽⣿⢽⣽⣿⡅⠀⠐⠀⠀⠂⠀⠁⠀⠀⠀⢀
//⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣺⡿⣾⣿⣿⣿⡷⣿⣻⣾⣿⣟⡾⣾⣿⣟⣿⣟⣯⣿⣿⢿⣿⣾⣿⣟⣿⣟⣯⣿⢷⡿⣯⣻⣾⢿⣯⡷⣿⣻⣻⣾⢿⡷⣿⣽⢿⣽⣿⣾⣿⣿⣿⣿⢽⣟⣧⣑⢢⢒⣝⣼⣞⡯⣞⣿⡿⣾⣿⣿⣿⣿⡿⣟⡷⣿⢷⡀⠀⠄⠂⠀⠠⠀⠠⠀⠂⠀
