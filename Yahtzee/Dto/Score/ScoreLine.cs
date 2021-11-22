using System;

namespace Yahtzee.Dto.Score
{
    public class ScoreLine
    {
        //TODO: Change en enum ? 
        public String name { get; set; }
        public Boolean isSet { get; set; }
        public int defaultValue { get; set; }
        public Boolean yahtzee { get; set; }

        //TODO: Ajouter type de scoreline (premier ou second) 
    }
}
