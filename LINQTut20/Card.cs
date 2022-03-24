using System.Text;
using System.Threading.Tasks;

namespace LINQTut20
{
    public class Card
    {
        public enum Suites
        {
            HEARTS = 0,
            DIAMONDS,
            CLUBS,
            SPADES
        }

        public int Value { get; set; }
        public Suites Suite { get; set; }
         
        public string NamedValue
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                {
                    case (14):
                        name = "Ace";
                        break;
                    case (13):
                        name = "King";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (11):
                        name = "Jack";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }

                return name;
            }
        }

        public string Name
        { 
            get
            { 
                return NamedValue + " of  " + Suite.ToString();
            }
        }

        public bool IsRed => Suite == Suites.HEARTS || Suite == Suites.DIAMONDS;

        public Card(int Value, Suites Suite)
        {
            this.Value = Value;
            this.Suite = Suite;
        }
    }

}
