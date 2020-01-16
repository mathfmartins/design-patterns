using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using flyweight;

namespace outros_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
           var listaDeNotas = new NotasMusicais();
           var musica = new List<INota>() {
               listaDeNotas.GetNota("do"),
               listaDeNotas.GetNota("re"),
               listaDeNotas.GetNota("mi"),
               listaDeNotas.GetNota("fa"),
               listaDeNotas.GetNota("fa"),
               listaDeNotas.GetNota("fa")
           };

           var piano = new Piano();
           piano.Tocar(musica);
        }
    }
    
}
