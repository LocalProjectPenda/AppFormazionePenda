namespace EuroCentralBank
{
    public interface IUEEnteAdministration : IEnteAdminstrative
    {
        public string BorderReDefinition(Parlement parlement);  // I medoti dell'interfaccia sono sempre PUBLIC 
        public void WelfareService();
        //  ->  Hai gia quest metodi da IEnteAdminstrative. non devi recrearli di nuovoa livello di Interface
        // -> L'overloading va fatto solo a livello di classe 

        /*
         
        public void HNS() { }
        public void LAWSystem() { }
        public void EducationSystem() { } 

         */

    }
}
