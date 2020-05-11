using System;
namespace SharedModels
{
    public class Pergunta
    {
        public string Texto { get; set; }
        public Dificuldade Dificuldade { get;  set; }
        public Tema Tema { get;  set; }
        public Pergunta()
        {
        }
        public Pergunta(Tema tema,Dificuldade dificuldade,string text)
        {
            Tema = tema;
            Dificuldade = dificuldade;
            Texto = text;
        }
        
    }
}
