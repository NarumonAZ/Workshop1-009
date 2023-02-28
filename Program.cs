class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Password : ");
            int pass = int.Parse(Console.ReadLine());
            
           Console.Write("Codename : ");
            string codename = Console.ReadLine();

            if (pass >= 0 && pass <= 999999) {
                if (codename == "CIA" || codename == "FBI" || codename == "NSA") {
                    switch (codename)
                    {
                        case "CIA" :
                            if (pass >= 0 && pass <= 999999) {
                                Console.WriteLine("True");
                                } else {
                                 Console.WriteLine("False"); }
                            break;

                        case "FBI" :
                            if (pass >= 0 && pass <= 999999) {
                                Console.WriteLine("True");
                                } else {
                                 Console.WriteLine("False"); }
                            break;

                        case "NSA" :
                            if (pass >= 0 && pass <= 999999) {
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