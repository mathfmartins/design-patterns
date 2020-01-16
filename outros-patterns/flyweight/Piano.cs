using System.Collections.Generic;

namespace flyweight { 
    public class Piano { 
        public void Tocar(List<INota> notas) {
            foreach (var nota in notas) {
                System.Console.Beep(nota.Frequencia, 400);
            }
        }
    }
}