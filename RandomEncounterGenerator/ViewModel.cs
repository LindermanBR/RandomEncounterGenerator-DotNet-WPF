using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEncounterGenerator
{
    public class ViewModel
    {
        public List<string> TipoEncontro { get; } = new List<string> {
            "Interpretacao",
            "Desafio",
            "Dinamico",
            "Estatico"
        };
        public List<string> Oponente { get; } = new List<string> {
            "Criatura Hostil",
            "Criatura Neutra",
            "Criatura Amigavel",
            "Forca Natureza",
            "Forca Mistica",
            "Forca Sobrenatural",
            "Presenca Anormal",
            "Presenca Hostil",
            "Presenca Amigavel",
            "Personagens Inimigos",
            "Personagens Neutros",
            "PersonagemAmigaveis",
        };
        public List<string> Objetivo { get; } = new List<string> {
            "Desafio Habilidade",
            "Desafio Combate",
            "Desafio Conhecimento",
            "Desafio Fuga",
            "Informação Criatura",
            "Informação Recursos",
            "Informação Lugar",
            "Informacao Evento",
            "Descoberta Criatura",
            "Descoberta Recursos",
            "Descoberta Lugar",
            "Descoberta Evento"
        };
        public List<string> Localidade { get; } = new List<string> {
            "Ermo Sombrio",
            "Ermo Calmo",
            "Ermo Agitado",
            "Ermo Hostil",
            "Ermo Neutro",
            "Passagem Sombria",
            "Passagem Neutra",
            "Passagem Hostil",
            "Construcao Isolada Habitada",
            "Construcao Isolada Desabitada",
            "Assentamento Habitado",
            "Assentamento Desabitado",
            "Ruina Habitada",
            "Ruina Desabitada"
        };
        public List<string> Clima { get; } = new List<string> {
            "Desanuviado",
            "Parcialmente Nublado",
            "Totalmente Nublado",
            "Garoa",
            "Tempestade",
            "Trovoadas Distantes",
            "Trovoadas Intensas",
            "Bruma Suave",
            "Nevoeiro Espesso",
            "Neve Rasa",
            "Tempestade De Neve",
            "Chuva De Granizo",
            "Brisa Leve",
            "Vento Forte",
            "Tornado",
            "Luzes Do Norte",
            "Ceu Estrelado",
            "Arco Iris",
            "Calor",
            "Frio"
        };

        private string opcaoTipoEncontro;
        private string opcaoOponente;
        private string opcaoObjetivo;
        private string opcaoLocalidade;
        private string opcaoClima1;
        private string opcaoClima2;

        public void SelecionarAleatorio()
        {
            Random random = new Random();

            opcaoTipoEncontro = TipoEncontro[random.Next(TipoEncontro.Count)];
            opcaoOponente = Oponente[random.Next(Oponente.Count)];
            opcaoObjetivo = Objetivo[random.Next(Objetivo.Count)];
            opcaoLocalidade = Localidade[random.Next(Localidade.Count)];
            opcaoClima1 = Clima[random.Next(Clima.Count)];
            opcaoClima2 = Clima[random.Next(Clima.Count)];
        }

        public void SelecionarOpcoes(string tipoEncontro, string oponente, string objetivo, string localidade, string clima1, string clima2)
        {
            // Lógica para selecionar opções fornecidas nos parâmetros
            opcaoTipoEncontro = tipoEncontro;
            opcaoOponente = oponente;
            opcaoObjetivo = objetivo;
            opcaoLocalidade = localidade;
            opcaoClima1 = clima1;
            opcaoClima2 = clima2;
        }

        public string GerarEncontro()
        {
            StringBuilder encontro = new StringBuilder();
            encontro.Append("(Apague os textos entre parêntesis e em seu lugar coloque as escolhas) " +
                "\nDados Base" +
                "\n(Nome do Evento)");

            encontro.Append("\nTipo de Encontro: ");
            encontro.Append(opcaoTipoEncontro);
            encontro.Append("\nOponente: ");
            encontro.Append(opcaoOponente);
            encontro.Append("\nObjetivo: ");
            encontro.Append(opcaoObjetivo);
            encontro.Append("\nLocalidade: ");
            encontro.Append(opcaoLocalidade);
            encontro.Append("\nClima1: ");
            encontro.Append(opcaoClima1);
            encontro.Append("\nClima2: ");
            encontro.Append(opcaoClima2);
            encontro.Append("\nMotivo: " +
                "\n(Baseado no Objetivo cite 2 motivos)" +
                "\nComplicações:" +
                "\n(Baseando-se no oponente, localidade e clima crie 3 complicações)" +
                "\n\nDescrição Expandida" +
                "\n(Substitua por um paragrafo descrevendo a localidade)" +
                "\n\n(Substitua por um paragrafo descrevendo o Objetivo)" +
                "\n\n(Substitua por um paragrafo descrevendo o Oponente)" +
                "\n\nResolução do Evento" +
                "\n(Forneça de 3 a 5 possíveis resoluções e seus ganhos e perdas para o grupo)");


            return encontro.ToString();
        }

    }
}
