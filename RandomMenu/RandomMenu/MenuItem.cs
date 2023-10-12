using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMenu
{
    public class MenuItem
    {
        public static Random Randomaizer = new Random();

        public string Description = "";
        public string Price;

        public string[] Proteins =
        {
            "Ростбіф",
            "Cалямі",
            "Індичка",
            "Шинка",
            "Бастурма",
            "Тофу"
        };

        public string[] Condiments =
        {
            "жовтою гірчицєю",
            "Бурою гірчицею",
            "медовою гірчицею",
            "майонезом",
            "релішом",
            "французькою гірчицею"
        };

        public string[] Breads =
        {
            "нарізним хлібом",
            "білим хлібом",
            "чорним хлібом",
            "пампушками",
            "житнім хллібом"
        };

        public void Generate()
        {
            string randomProtein = Proteins[Randomaizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomaizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomaizer.Next(Breads.Length)];

            Description = randomProtein + " під " + randomCondiment + " з " + randomBread;

            decimal bucks = Randomaizer.Next(2, 5);
            decimal cents = Randomaizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
        }
    }
}
