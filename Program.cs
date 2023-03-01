static void Change2(){
  Console.Write("Change = ");
  double change = double.Parse(Console.ReadLine());

  int thousand = (int)change/1000;
  change = change - thousand * 1000;
  int fivehundred = (int)change/500;
  change = change - fivehundred * 500;
  int hundred = (int)change/100;
  change = change - hundred * 100;
  int fifty = (int)change/50;
  change = change - fifty * 50;
  int twenty = (int)change/20;
  change = change - twenty * 20;
  int ten = (int)change/10;
  change = change - ten * 10;
  int five = (int)change/5;
  change = change - five * 5;
  int one = (int)change/1;
  change = change - one;
  int P50 = (int)(change/0.50);
  change = change - P50*0.50;
  int P25 = (int)(change/0.25);
  

  Console.WriteLine("1000: {0}", thousand);
  Console.WriteLine("500: {0}", fivehundred);
  Console.WriteLine("100: {0}", hundred);
  Console.WriteLine("50: {0}", fifty);
  Console.WriteLine("20: {0}", twenty);
  Console.WriteLine("10: {0}", ten);
  Console.WriteLine("5: {0}", five);
  Console.WriteLine("1: {0}", one);
  Console.WriteLine(".50: {0}", P50);
  Console.WriteLine(".25: {0}", P25);
 }

 static void Switchcase(){
  Console.WriteLine("Please select menu\n--------------------\n1. Login\n2. Register");
  int input = int.Parse(Console.ReadLine());
  switch(input){
   case 1:
   Console.Clear();
   Console.WriteLine("Login");
   break;
   case > 1 and < 10:
   Console.Clear();
   Console.WriteLine("Register");
   break;
   default:
   Console.Clear();
   Console.WriteLine("Invalid input");
   break;
  }
 }
