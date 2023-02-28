class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Password : ");
            int passhundredthousand = int.Parse(Console.ReadLine());
            int passtenthousand = int.Parse(Console.ReadLine());
            int passthousand = int.Parse(Console.ReadLine());
            int passhundred = int.Parse(Console.ReadLine());
            int passten = int.Parse(Console.ReadLine());
            int passone = int.Parse(Console.ReadLine());
        Console.WriteLine("Password : {0}{1}{2}{3}{4}{5}", passhundredthousand, passtenthousand, passthousand, passhundred, passten, passone); 

        Console.Write("Codename : ");
            string name = Console.ReadLine();

            if (true) {
                if (name == "CIA" || name == "FBI" || name == "NSA") {
                    switch (name)
                    {
                        case "CIA" :
                            if ( (passone % 9 == 0) && (!(passten == 1 && passten == 3) && (passten == 5)) && (passthousand < 6) && (passthousand != 8) ) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }

                            break;

                        case "FBI" :
                            if ( (passhundredthousand >= 4) && (passhundredthousand <= 7) && (passhundred % 2 == 0) && (passhundred != 6) && (passtenthousand % 3 == 0)) {
                                Console.WriteLine("True");
                            } else {
                                Console.WriteLine("False"); }
                            break;

                        case "NSA" :
                            if ( (30 % passone == 0) && (passone % 3 == 0) && (passone % 2 != 0) ) && (passone == 7 || passten == 7 || passhundred == 7 || passtenthousand == 7 ||  passhundredthousand == 7 || passhundredthousand == 7) ) {
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