using System;
namespace SharedModels
{
    public class Resposta
    {
        public bool IsCorreta { get; set; }
        public string Text { get; set; }
        public  Pergunta Pergunta { get; set; }

        public Resposta()
        {
        }
    }
}
