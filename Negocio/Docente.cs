namespace Broda.Negocio
{
    public class Docente
    {
        public static List<Entidades.Docente> RecuperarTodos()
        {
            Datos.Docente dataDocente = new Datos.Docente();
            return dataDocente.RecuperarTodos();
        }
        public static void Agregar(Entidades.Docente docente)
        {
            Datos.Docente docente1 = new Datos.Docente();
            docente1.Agregar(docente);
        }
        public static Entidades.Docente RecuperarUno(string cuil)
        {
            Datos.Docente datadocente = new Datos.Docente();
            return datadocente.RecuperarUno(cuil);
        }
    }
}