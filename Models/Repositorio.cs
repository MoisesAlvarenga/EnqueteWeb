using System.Collections.Generic;

namespace EnqueteWeb.Models
{
    public static class Repositorio{
        private static List<Resposta> respostas = new List<Resposta>();

        public static IEnumerable<Resposta> Respostas{get {return respostas;} }

        public static void AdicionarResposta(Resposta resposta){
            respostas.Add(resposta);
        }

        static Repositorio(){
            respostas.Add(new Resposta
            {
                Nome = "João",
                Email = "Joao@outlook.com",
                Sim = true
            });

        respostas.Add(new Resposta
            {
                Nome = "Maria",
                Email = "maria@outlook.com",
                Sim = true
            });

        respostas.Add(new Resposta
            {
                Nome = "Andressa",
                Email = "andressa@outlook.com",
                Sim = false
            });

           respostas.Add(new Resposta
            {
                Nome = "Joses",
                Email = "Joses@outlook.com",
                Sim = false
            });

        }
    }

}