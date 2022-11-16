using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaslijedivanjePon
{
    class Biljka
    {

    }
    class Stablo : Biljka
    {
        bool otpadajuListovi;
        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }
    }
    class Cvijet : Biljka
    {

    }
    class Crnogoricno : Stablo
    {
        bool _otpadajuListovi;
        public Crnogoricno(bool otpadajuListovi1) : base(otpadajuListovi1)
        {
          _otpadajuListovi=otpadajuListovi1;
        }
        public override string ToString()
        {
            return "Otpadaju listovi= " + _otpadajuListovi;
        }
    }
    class Bijelogoricno : Stablo
    {
        bool _otpadajuListovi;
        public Bijelogoricno(bool otpadajuListovi1) : base(otpadajuListovi1)
        {
                _otpadajuListovi = otpadajuListovi1;
        }
        public override string ToString()
        {
            return "Otpadaju listovi= " + _otpadajuListovi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);
            Console.WriteLine("Hrast: "+ Hrast.ToString());
            Console.WriteLine("Bor: " + Bor.ToString());
            Console.ReadKey();
        }
    }
}
