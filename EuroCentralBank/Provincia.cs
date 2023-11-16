namespace EuroCentralBank
{
    public class Provincia :
        AreaGeo,
        // UEPublicAdministration,  ->  Non puoi ereditare da PIU  Classi.
        IUEEnteAdministration
    {
        public Provincia(string nameGeo, decimal area) : base(nameGeo, area) { }


        ///  NON DEVI FARE OVVERRIDE dei metodi dell'Interface. L'OVERRRIDE va fatto solo per i metodi abstract e virtual 
        /// Per fare ORERRIDE dei metodi dell'Interface basta aggiungere il  corpo della funzione 


        //public override void WelfareService() { }
        //public abstract void HNS(UECitizenPublicService ID) { }
        //public abstract void EducationSystem(UECitizenPublicService ID) { }



        /// Per implentare i metodi dell'interfaccia  basta portarli dentro la classe aggiungere il corpo della funzione. 
        public string BorderReDefinition(Parlement parlement)
        {
            return string.Empty;
        }

        public void WelfareService() { }
        public void HNS() { }
        public void LAWSystem() { }
        public void EducationSystem() { }
    }
}
