using p1bpoo.MisClases;
public class runing : Vehiculo
{
    public runing(int anio, string elcolor, string elmodelo) : base(anio, elcolor, elmodelo)
    {
        TiposdelicenciaAceptados = new List<string> { "A", "b", "c" };
    }
}
