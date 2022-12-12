Console.WriteLine("Time dos Sonhos do Futebol BR\n");

string[] top = {
"Gylmar(GL)",
"Taffarel(GL)",
"Marcos(GL)",
"Dida(GL)",
"Emerson Leão(GL)",
"Barbosa(GL)",
"Castilho(GL)",
"Júlio César(GL)",
"Rogério Ceni(GL)",
"Manga(GL)",
"Cássio(GL)",
"Fernando Prass(GL)",
"Cafu(L)",
"Branco(L)",
"Roberto Carlos(L)",
"Djalma Santos(L)",
"Júnior(L)",
"Leandro(L)",
"Leonardo(L)",
"Nílton Santos(L)",
"Daniel Alves(L)",
"Marcelo(L)",
"Aldair(ZAG)",
"Bellini(ZAG)",
"Domingos da Guia(ZAG)",
"Lúcio(ZAG)",
"Luis Pereira(ZAG)",
"Mauro(ZAG)",
"Mauro Galvão(ZAG)",
"Orlando(ZAG)",
"Ricardo Rocha(ZAG)",
"Roberto Dias(ZAG)",
"Ademir da Guia(M)",
"Didi(M)",
"Gérson(M)",
"Kaká(M)",
"Rivaldo(M)",
"Ronaldinho Gaúcho(M)",
"Sócrates(M)",
"Zico(M)",
"Zizinho(M)",
"Careca(ATA)",
"Garrincha(ATA)",
"Jairzinho(ATA)",
"Pelé(ATA)",
"Reinaldo(ATA)",
"Roberto Dinamite(ATA)",
"Romário(ATA)",
"Ronaldo(ATA)",
"Tostão(ATA)",
"Vavá(ATA)",
"Adriano Imperador(ATA)",
"Neymar Jr(ATA)",
};

int[] time = new int[11];

Console.WriteLine("Top 53 jogadores:\n");
for (int i = 0; i < 53; i++)
{
    Console.WriteLine($"\t{i + 1,2} - {top[i]}");
}

Console.WriteLine();

for (int i = 0; i < 11; i++)
{
    while (true)
    {
        Console.Write($"{i} jogador(es) selecionados. Adicionar o Top # ");
        int selecionado = Convert.ToInt32(Console.ReadLine());

        selecionado--;

        if (selecionado < 0 || selecionado >= 53)
        {
            Console.WriteLine("Entrada inválida.");
            continue;
        }

        bool jaSelecionado = false;
        for (int anterior = 0; anterior < i; anterior++)
        {
            jaSelecionado = time[anterior] == selecionado;
            if (jaSelecionado) break;
        }

        if (jaSelecionado)
        {
            Console.WriteLine("Atleta já incluído no seu time.");
            continue;
        }

        time[i] = selecionado;
        break;
    }
}

Array.Sort(time);

Console.WriteLine("\nSeu time dos sonhos é:\n");
for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"\t{time[i] + 1,2} - {top[time[i]]}");
}