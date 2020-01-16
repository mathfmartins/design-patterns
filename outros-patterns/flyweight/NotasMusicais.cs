using System.Collections.Generic;

namespace flyweight { 
    public interface INota
    {
        int Frequencia { get; }
    }

    public class NotasMusicais { 
        public static IDictionary<string, INota> Notas = 
            new Dictionary<string, INota>() {
                {"do", new Do()},
                {"re", new Re()},
                {"mi", new Mi()},
                {"fa", new Fa()},
                {"sol", new Sol()},
                {"la", new La()},
                {"si", new Si()},
            };
        public INota GetNota(string nome) { 
            return Notas[nome];
        }
    }

    public class Do : INota {
        public int Frequencia {
            get { return 262; }
        }
    }

    public class Re : INota {
        public int Frequencia {
            get { return 294; }
        }
    }

    public class Mi : INota {
        public int Frequencia {
            get { return 330; }
        }
    }

     public class Fa : INota {
        public int Frequencia {
            get { return 349; }
        }
    }
 
     public class Sol : INota {
        public int Frequencia {
            get { return 392; }
        }
    }

     public class La : INota {
        public int Frequencia {
            get { return 440; }
        }
    }
       public class Si : INota {
        public int Frequencia {
            get { return 490; }
        }
    }
}