using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAssincrona_3
{
    class ArvorePersonalizada : ArvoreBinaria
    {

        public ArvorePersonalizada()
        {

        }

        public ArvorePersonalizada(char item)
        {
            base.Inserir(item);
        }

        public ArvorePersonalizada(IEnumerable<char> itens)
        {
            foreach(char item in itens)
            {
                base.Inserir(item);
            }
        }

        public void Remover(IEnumerable<char> itens)
        {
            foreach (char item in itens)
                base.Remover(item);
        }

    }
}
