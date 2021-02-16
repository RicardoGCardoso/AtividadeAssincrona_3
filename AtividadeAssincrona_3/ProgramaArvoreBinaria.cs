using System;
using System.Collections;
using System.Collections.Generic;

namespace AtividadeAssincrona_3
{
	class ProgramaArvoreBinaria
	{
		static void Main(string[] args)
		{
			Console.WriteLine("arvore binaria!");



			List<char> itemsAdd = new List<char> { 'K', 'R', 'Z', 'X', 'U' };

			ArvorePersonalizada arvorePersonalizada = new ArvorePersonalizada(itemsAdd);

			arvorePersonalizada.Inserir('A');
			arvorePersonalizada.Exibir();

			arvorePersonalizada.Inserir('B');
			arvorePersonalizada.Inserir('C');
			arvorePersonalizada.Inserir('D');
			arvorePersonalizada.Exibir();

			arvorePersonalizada = new ArvorePersonalizada('H');
			arvorePersonalizada.Inserir('C');
			arvorePersonalizada.Exibir();

			arvorePersonalizada.Inserir('A');
			arvorePersonalizada.Inserir('B');
			arvorePersonalizada.Inserir('D');
			arvorePersonalizada.Inserir('E');
			arvorePersonalizada.Exibir();

			arvorePersonalizada = new ArvorePersonalizada(itemsAdd);
			arvorePersonalizada.Inserir('C');
			arvorePersonalizada.Inserir('A');
			arvorePersonalizada.Inserir('B');
			arvorePersonalizada.Inserir('D');
			//arvoreBinaria.Inserir('E');
			arvorePersonalizada.Inserir('F');
			arvorePersonalizada.Inserir('E');
			arvorePersonalizada.Inserir('G');
			arvorePersonalizada.Exibir();

			Console.WriteLine(arvorePersonalizada.GetValorMinimo());
			Console.WriteLine(arvorePersonalizada.GetValorMaximo());
			arvorePersonalizada.PercorrerEmOrdem();

			//arvoreBinaria.Remover('A');
			//arvoreBinaria.Remover('B');
			//arvoreBinaria.Remover('C');
			//arvoreBinaria.Remover('D');
			arvorePersonalizada.Remover('F');
			arvorePersonalizada.Remover(itemsAdd);
			
			arvorePersonalizada.Exibir();

			arvorePersonalizada.PercorrerEmOrdem();

		}
	}
}