class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Password : ");
            int pass = int.Parse(Console.ReadLine());
            int passone = int.Parse(Console.ReadLine());
            int passten = int.Parse(Console.ReadLine());
            int passhundred = int.Parse(Console.ReadLine());
            int passthousand = int.Parse(Console.ReadLine());
            int passtenthousand = int.Parse(Console.ReadLine());
            int passhundredthousand = int.Parse(Console.ReadLine());
            Console.WriteLine("pass = {0}{1}{2}{3}{4}{5}", passhundredthousand, passtenthousand, passthousand, passhundred, passten, passone);
            
           Console.Write("Codename : ");
            string codename = Console.ReadLine();

            if (pass >= 0 && pass <= 999999) {
                if (codename == "CIA" || codename == "FBI" || codename == "NSA") {
                    switch (codename)
                    {
                        case "CIA" :
                            if ( (passone % 9 == 0) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            if ( (!(passten == 1 && passten == 3) && (passten == 5)) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            if ( (passthousand < 6) && (passthousand != 8) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            break;

                        case "FBI" :
                            if ( (passhundredthousand >= 4) && (passhundredthousand <= 7) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            if ( (passhundred % 2 == 0) && (passhundred != 6) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            if ( (passtenthousand % 3 == 0) ) { 
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }
                            break;

                        case "NSA" :
                            if ( (30 % pass == 0) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            if ( (passone % 3 == 0) && (passone % 2 != 0) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }
                        break;
                    }
                } else {
                     Console.WriteLine("Password is incorrect"); }

       }
    } 
}