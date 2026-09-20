using System.Collections.Generic;
using System;

// ╰ Simulacion de db uwu ╯
namespace NicaCompare
{
    public static class sesion_actual
    {
        public static string Correo = "";
        public static string Nombre = "";
        public static string TipoUsuario = "";
        public static int Saldo = 0;
        public static int Telefono = 81234567;
        public static DateTime fecha_registro = DateTime.Today;


    }

    public static class usuarios_db
    {
        public static Dictionary<string, (string Nombre, string Password, string TipoUsuario, int Saldo, int Telefono, DateTime fecha_registro)> Usuarios =
            new Dictionary<string, (string Nombre, string Password, string TipoUsuario, int Saldo, int Telefono, DateTime fecha_registro)>
        {
        { "skl@unan.ni", ("Skl ◕⩊◕", "17", "Gratis", 250, 81234567, new DateTime(2026, 9, 14)) },
        { "oto@.unan.ni", ("Oto (๑﹏๑)", "123", "Gratis", 300, 81234567, new DateTime(2026, 9, 14)) },
        { "jahary@.unan.ni", ("Jahary (✿ᴗ͈ˬᴗ͈)⁾", "123", "Gratis", 300, 81234567, new DateTime(2026, 9, 14)) },
        { "moises@.unan.ni", ("Moises (•̀ ᗜ •́ )", "123", "Gratis", 300, 81234567, new DateTime(2026, 9, 14)) }
        };
    }
}