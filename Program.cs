class Program
{
    static void Main(string[] args)
    {
         CircularLinkedList<char> T = new CircularLinkedList<char>(); 
        while(true)
        {
            Console.Write("{jasmine = J,Globe Amaranth = G , Orchid = O ,Rose = R}: ");
            char input = char.Parse(Console.ReadLine());

        if (input != 'J'&& input != 'G' && input != 'O' && input != 'R')

         {break;}
        else 
        {
            int Length = T.GetLength();
            if(Length == 0)
            {
                if(input == 'G' || input == 'J'|| input == 'O')
                {
                    T.Add (input);
                }
                else
                {
                    Console.WriteLine("Invalid pattern");
                }               
            }  
            
            else if (Length >= 1)
            {
                if(Length <= 2)
                {
                    if (input == 'R' && T.Get(0) == T.Get(-1))
                    {
                        Console.WriteLine("Invalid pattern");
                    } 
                    else if (T.Get (-1) == 'R' && input == T.Get(-2))
                    {
                        Console.WriteLine("Invalid pattern");
                    }
                    else
                    {
                        T.Add(input);
                    }
                }
                else if(Length >= 3)
                {
                    if (input == 'R' && T.Get(0) == T.Get(-1))
                   { 
                        Console.WriteLine("Invalid pattern.");
                   }
                    else if (T.Get(-1) == 'R' && input == T.Get(-2))
                   {
                        Console.WriteLine("Invalid pattern.");
                   }
                    else if(input == 'G')
                   { 

                     if(input == T.Get(-1) && input == T.Get(-2)&& input == T.Get(-3))
                   {
                        Console.WriteLine("Invalid pattern.");
                   }

                     else if(T.Get(0) == 'G' && T.Get(1) == 'G' && T.Get(2) == 'G')
                   { 
                        Console.WriteLine("Invalid pattern.");
                   }

                     else if (T.Get(0) == 'G' && T.Get(-1) == 'G' && T.Get(-2) == 'G' )
                   { 
                        Console.WriteLine("Invalid pattern.");
                   }

                     else if(T.Get(0) == 'G' && T.Get(1) == 'G' && T.Get(-1) == 'G')
                   {
                        Console.WriteLine("Invalid pattern.");
                   }
                
                     else
                   {
                        T.Add(input);
                   }

                   }

                    else 
                    {
                        T.Add(input);
                    }

                    }

                }
            }
            Console.WriteLine("------------------------------------------------------------------");
            
             for(int i = 0 ; i < T.GetLength() ; i++)
            {
                Console.Write(T.Get(i));
            }

                Console.WriteLine("");

            Console.WriteLine("input : {0}", input);
                


        }
    } 
 }     
         
                     
          
    
