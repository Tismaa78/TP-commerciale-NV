using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_commerciale_NV
{
    class Program
    {
        static void Main(string[] args)
        {
            Categorie cat1 = new Categorie("E34P", "Salarié ");
            Categorie cat2 = new Categorie("C9OZ", "Indépendant");
            

            Service s1 = new Service("National");
            Service s2 = new Service("International");

            Commercial com1 = new Commercial("Ronaldo", "Cristiano", 1985, cat1, s2);
            Commercial com2 = new Commercial("Thauvin", "Florian", 1993, cat2, s2);
            Commercial com3 = new Commercial("Under", "Cengiz", 1996, cat1, s2);

            Commercial com4 = new Commercial("Mandanda", "steve", 1983, cat1, s1);
            Commercial com5 = new Commercial("Balerdi", "Leonardo", 1998, cat2, s1);
            Commercial com6 = new Commercial("Rongier", "Valentin", 1994, cat1, s1);



            s1.afficheCom();
            s2.afficheCom();

            com1.Compare(com2);
            com1.Compare(com3);

            s1.plusAge();
            s2.plusAge();

        }

    }

}
