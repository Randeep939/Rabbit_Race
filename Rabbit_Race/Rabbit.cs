using System.Windows.Forms;

namespace Rabbit_Race
{

    public abstract class Rabbit
    {
        public int RabbitID { get; set; }
        public string Name { get; set; }
        public PictureBox MyPictureBox { get; set; }

        private int newDistance = 76;


        public void UpdatePostition()
        {
            //moves the picture box to new postion
            MyPictureBox.Left = newDistance;
        }
        public void StartingPostition()
        {
            // new distance of the Rabbit
            newDistance = 76;
            // current location
            var location = MyPictureBox.Location;
            // changes the current location to new location
            location.X = newDistance;
            //moves the picture box
            MyPictureBox.Location = location;
            //updates the postion
            UpdatePostition();
        }
        public void Run()
        {
            //new distance + random move of 1, 2, 3, or 4 spaces
            newDistance += Factory.Number();
            //updates the postion
            UpdatePostition();
        }



    }

    class Rabbit01 : Rabbit
    {
        public Rabbit01()
        {
            RabbitID = 1;
            Name = "Bola";
        }
    }

    class Rabbit02 : Rabbit
    {

        public Rabbit02()
        {
            RabbitID = 2;
            Name = "Bunty";
        }
    }

    class Rabbit03 : Rabbit
    {
        public Rabbit03()
        {
            RabbitID = 3;
            Name = "Kato";
        }
    }

    class Rabbit04 : Rabbit
    {
        public Rabbit04()
        {
            RabbitID = 4;
            Name = "Sona";
        }
    }
}
