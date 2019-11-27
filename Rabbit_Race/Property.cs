using System.Windows.Forms;

namespace Rabbit_Race
{
    public class Property
    {
        public string NotBetYet { get; set; } = " has not placed a bet.";
        public string Busted { get; set; } = " you have run out of Cash! BUSTED!";
        public string LBLJashandeep { get; set; } = "";
        public string LBLJagdeep { get; set; } = "";
        public string LBLTajinder { get; set; } = "";
        public RadioButton FakeRB { get; set; } = new RadioButton();

        public bool isWinner { get; set; } = false;

        public int Rabbit { get; set; }
        public int RabbitID { get; set; }
        public int Punter { get; set; }

        //public int RabbitWinner { get; set; }
        //public int RabbitWinnerID { get; set; }
        public int RabbitRaceNum { get; set; }

    }
}
