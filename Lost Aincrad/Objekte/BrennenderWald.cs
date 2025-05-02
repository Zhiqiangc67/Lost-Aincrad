
namespace LOST_Aincrad__experimental_
{
    internal class BrennenderWald
    {
        private string spielerName;
        private string spielerKlasse;
        private bool hatWassereimer;

        public BrennenderWald(string spielerName, string spielerKlasse, bool hatWassereimer)
        {
            this.spielerName = spielerName;
            this.spielerKlasse = spielerKlasse;
            this.hatWassereimer = hatWassereimer;
        }

        public bool SpielerFandWasser { get; internal set; }

        internal void ZeigeWald()
        {
            throw new NotImplementedException();
        }
    }
}