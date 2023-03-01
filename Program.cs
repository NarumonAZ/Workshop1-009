class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Password : ");
            int password = int.Parse(Console.ReadLine());
            int passhundredthousand = 0 ;
            int passtenthousand = 0 ;
            int passthousand = 0 ;
            int passhundred = 0 ;
            int passten = 0 ;
            int passone = 0 ;
                
        Console.Write("Codename : ");
            string name = Console.ReadLine();

            if (password >= 0 && password < 100000) { 
                
                if (name == "CIA" || name == "FBI" || name == "NSA") {
                    switch (name)
                    {
                        case "CIA" :
                            if (passone % 3 == 0) {
                                Console.WriteLine("True1");
                                    if (passten != 1 && passten != 3 && passten != 5) {
                                         Console.WriteLine("True2");
                                        if (passthousand >= 6 && passthousand != 8) {
                                            Console.WriteLine("True3");

                                        } else {
                                            Console.WriteLine("False3"); }
                                    } else {
                                         Console.WriteLine("False2"); }
                            } else {
                                Console.WriteLine("False1"); }

                            break;
                    }
                } else {
                     Console.WriteLine("False0"); }
            }
    } 
}