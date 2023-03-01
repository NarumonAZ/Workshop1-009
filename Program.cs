class Program
    {

        static void Main(string[] args) {Console.WriteLine("Please fill in Password");
        {
            Console.Write("Password : ");
            int pa = int.Parse(Console.ReadLine());
            
            int hundredthousand = pa/100000;
            pa = pa - hundredthousand * 100000;
            int tenthousand = pa/10000;
            pa = pa - tenthousand * 10000;
            int onethousand = pa/1000;
            pa = pa - onethousand * 1000;
            int onehundred = pa/100;
            pa = pa - onehundred * 100;
            int ten = pa/10;
            pa = pa - ten * 10;
            int one = pa/1;
            pa = pa - one * 1;

            Console.Write("Cordname : ");
            string name = Console.ReadLine();

            if (pa >= 0 && pa < 100000) { 
                
                if (name == "CIA" || name == "FBI" || name == "NSA") {
                    switch (name)
                    {
                        case "CIA" :
                            if (one % 3 == 0) {
                                    if (ten != 1 && ten != 3 && ten != 5) {
                                            if (onethousand >= 6 && onethousand != 8) {
                                                Console.WriteLine("True");
                                            } else {
                                                Console.WriteLine("False"); }
                                    } else {
                                    Console.WriteLine("False"); }
                            } else {
                            Console.WriteLine("False"); }
                        
                        break;

                        case "FBI" :
                            if (hundredthousand >= 4 && hundredthousand <= 7) {
                                    if (onehundred % 2 ==0 && onehundred != 6) {
                                            if (tenthousand % 2 == 1) {
                                                Console.WriteLine("True");
                                            } else {
                                                Console.WriteLine("False"); }
                                    } else {
                                    Console.WriteLine("False"); }
                            } else {
                            Console.WriteLine("False"); }

                        break;

                        case "NSA" :
                            if (30 % one == 0) {
                                    if (onehundred % 3 == 0 && onehundred % 2 != 0) {
                                            if (one == 7 || ten == 7 || onehundred == 7 || onethousand == 7 ||  tenthousand == 7 || hundredthousand == 7) {
                                                Console.WriteLine("True");
                                            } else {
                                                Console.WriteLine("False"); }
                                    } else {
                                    Console.WriteLine("False"); }
                            } else {
                            Console.WriteLine("False"); }
 
                        break;
                    }
                } else {
                     Console.WriteLine("False : Please try again"); }
            }
        }
    } 
}