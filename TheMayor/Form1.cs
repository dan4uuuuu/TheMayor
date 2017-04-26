using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TheMayor
{
    public partial class Form1 : Form
    {
        private const bool IsDrinkingTime = true;
        private const int NoRakia = 0;
        private Rakia _rakia = new Rakia();
        private MusicPlayer player;

        public void TheMayorSaysCheers(Rakia rakia)
        {
            pictureBox2.Hide();
            //PLAYING MILE KITIC IN THE BACKGROUND
            
            player.PlayMile();
            player.wplayer.controls.play();
            pictureBox1.Show();

            ////Всички пияници.
            //EverybodyDrink();
            rakia.QuantityDecrement();
        }

        public void EverybodyDrink()
        {
            var alchoholics = new Drinkers();
            alchoholics.Drink();
            alchoholics.Eat_Horse();
        }

        public Rakia SendMichkataForRakia()
        {
            pictureBox1.Hide();
            pictureBox2.Show();
            var DrinkOfTheGods = new Rakia();
            //DrinkOfTheGods.FillRakia();
            player.wplayer.controls.stop();
            player.PlayAlisia();
            player.wplayer.controls.next();
            player.wplayer.controls.play();
            return DrinkOfTheGods;
        }
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            pictureBox2.Hide();
            var _player = new MusicPlayer();
            player = _player;
        }

        private void Drink_Click(object sender, EventArgs e)
        {
            if (IsDrinkingTime)
            {
                if (_rakia.Quantity == NoRakia)
                {
                    var result = MessageBox.Show("Искаш ли Мичката да напълни ракия?!");
                    _rakia = SendMichkataForRakia();
                }
                else
                {
                    TheMayorSaysCheers(_rakia);
                }
                
            }
        }
    }
}
