using System.Collections.Generic;

// ╰ Simulacion de db uwu ╯
namespace NicaCompare
{
    public static class sesion_actual
    {
        public static string Correo = "";
        public static string Nombre = "";
        public static string TipoUsuario = "";
        public static int Saldo = 0;
    }

    public static class usuarios_db
    {
        public static Dictionary<string, (string Nombre, string Password, string TipoUsuario, int Saldo)> Usuarios =
            new Dictionary<string, (string Nombre, string Password, string TipoUsuario, int Saldo)>
        {
            { "skl@unan.ni", ("Skl ◕⩊◕", "17", "Gratis", 250) },
            { "oto@.unan.ni", ("Oto (๑﹏๑)", "123", "Gratis", 300) },
            { "jahary@.unan.ni", ("Jahary (✿ᴗ͈ˬᴗ͈)⁾", "123", "Gratis", 300) },
            { "moises@.unan.ni", ("Moises (•̀ ᗜ •́ )", "123", "Gratis", 300) }
        };
    }
}