using System;

class MainClass {
  public static void Main (string[] args) {
    int number_of_tries;
    string x;
    int y;
    int z=0;
    int random_number=0;
    bool GameOn = true;
		Console.Clear();
    while (1==1){

      Console.WriteLine("Wana Play? (yes/no)");
      x = Console.ReadLine();
			Console.Clear();

      if(x=="yes"){
        GameOn =true;
        number_of_tries = 0;
        Random rand = new Random();
        while (GameOn){

          try{
            Console.WriteLine("Enter highest number.");
            y = Convert.ToInt32(Console.ReadLine());
            random_number = rand.Next(y)+1;
            GameOn=false;
						Console.Clear();
            
          }

          catch{

            Console.WriteLine("Something went wrong. \nEither you put in to big of a number or did not put in a number.");
          }

        }
        GameOn = true;
        while (GameOn){
          while (GameOn){
            try{
              Console.WriteLine("Guess The Number");
              z = Convert.ToInt32(Console.ReadLine());
              GameOn=false;
            }

            catch{
             Console.WriteLine("Enter a number");
            }

          }

          GameOn=true;
          if(z==random_number){
						Console.Clear();
            Console.WriteLine("You got it right!!! \nIt took {0} tries!!!",Convert.ToString(number_of_tries+1));
            GameOn=false;
          }

          else if(z>random_number){
						Console.Clear();
            Console.WriteLine("The number {0} is to high",z);
          }

          else if(z<random_number){Console.WriteLine("The number {0} is to low",z);}

          number_of_tries++;

        }

      }
      
      else if(x=="no"){
        Console.WriteLine("That is sad.");
        break;
      }
      else{
        Console.WriteLine("Sorry did not catch that.");
        
      }
    }

    
  }
}