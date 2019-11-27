using System.Windows.Forms;

namespace Rabbit_Race
{
    public abstract class Punter
    {
        public int PunterID { get; set; }
        public string PunterName { get; set; }
        public int MaxCash { get; set; }
        public int AmountBet { get; set; }
        public int BettorRabbitNum { get; set; }

        public RadioButton MyRadioButton { get; set; }
    }
}
