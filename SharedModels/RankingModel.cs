using System;
namespace SharedModels
{
    public class RankingModel
    {
		public string Nome { get; set; }
        public int Level { get; set; }
        public RankingModel(string nome,int Lv)
        {
            Nome = nome;
            Level = Lv;
        }
        public RankingModel()
        {

        }
    }
}
