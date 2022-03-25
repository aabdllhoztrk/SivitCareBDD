using System;
using System.Collections.Generic;
using System.Text;

namespace SivitCareBDD.Generators
{
   public static class BasiYarasiGenerator

    {
    private static Random rnd = new Random();
    public static int GetRandom()
    {
        return rnd.Next(1, 100);
    }

    }
}
