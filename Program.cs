﻿string[] ArrString; 
int count; 
string s;
string[] ArrString2; 

    Console.WriteLine("Введите несколько строк. Как только захотите закончить ввод нажмите 2 раза клавишу Enter:");
     count = 0; 
     ArrString = new string[count];

      do
      {
               s = Console.ReadLine();
        
        if (s!="")
        {
          count++;
          ArrString2 = new string[count];

          
          for (int i = 0; i < ArrString2.Length - 1; i++)
            ArrString2[i] = ArrString[i];

          
          ArrString2[count - 1] = s;

          
          ArrString = ArrString2;
        }
      } while (s != "");

      
// for (int i=0; i<ArrString.Length; i++)
// {
//     Console.Write($" {ArrString[i]}");
// }

for (int i = 0; i < ArrString.Length; i++)
    if (ArrString.Length < 4)
    {
      Console.WriteLine( ArrString[i]);
      Console.ReadKey();
    }
        


              
      