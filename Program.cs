using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Artyr artyr = new Artyr("Артур");
            P p = new P("дыра");
            Enttity enttity = new Enttity("существа");

            string a = artyr.start() + artyr.name + artyr.next() + p.name + p.next2() + enttity.name + enttity.sushestva();
            Console.WriteLine(a);

            Console.ReadKey();
        }


    }

    public class Artyr
    {
        public string name { get; set; }

        public Artyr(string name)
        {
            this.name = name;
        }

        public string start()
        {
            return "Например, в тот самый момент, когда ";
        }
        public string next()
        {
            return "произнес 'А у меня, кажется, большие проблемы с образом жизни', в ткани пространства-времени открылась случайная";
        }


    }

    public class P
    {
        public string name { get; set; }

        public P(string name)
        {
            this.name = name;
        }

        public string next2()
        {
            return "и перенесла его слова далеко-далеко во времени через почти бескрайние просторы космоса в далекую галактику, где странные воинственные";

        }


    }
    public class Enttity
    {
        public string name { get; set; }

        public Enttity(string name)
        {
            this.name = name;
        }
        public string sushestva()
        {
            return "балансировали на грани ужасной межзвездной войны.";

        }

    }
}
