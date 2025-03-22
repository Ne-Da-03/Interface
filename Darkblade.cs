using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using p1bpoo.MisClases;
public class Darkblade : Vehiculo
{
    public Darkblade(int anio, string elcolor, string elmodelo) : base(anio, elcolor, elmodelo)
    {
        TiposdelicenciaAceptados = new List<string> { "M" };
    }
}

