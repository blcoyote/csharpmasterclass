using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world{
    class Program{
        static void Main(string[] args){

			Human denis = new Human("Denis", "Themenace", "blue", 13);
			
			denis.IntroduceMyself();
			Human carl = new Human("Carl","Sagan", "grey", 48);
		
			carl.IntroduceMyself();

			Console.ReadLine();
			/*
            for (int i = 0; i <=20; i++)
            {
                if(i%2 !=0){
                    Console.WriteLine(i);
                }
            }
            Console.Read();
            */

			/*
            int counter = 0;
            string peopleCounter = "";
            Console.WriteLine("Press Enter to count, 's' to stop:");
            Console.Read();
            while (peopleCounter == "") {
                
                peopleCounter = Console.ReadLine();
                counter++;
                Console.WriteLine($"curent count is {counter}");
                
            }
            Console.WriteLine($"total count is {counter}");
            Console.WriteLine("press enter to close");
            Console.Read();
			*/

            /*
			int score = 0;
			int totalScore=0;
			int studentCount = 0;
			double avgScore;
			
			while (score != -1)	{
				Console.WriteLine("Enter student score between 0 and 20, -1 to stop");
				try	{
					score = Int32.Parse(Console.ReadLine());
					if (score == -1) { break; }
					if (score > 20 || score < -1){
						Console.WriteLine("illegal entry, only use numbers between 0 and 20");
						continue;
					}
					totalScore += score;
					studentCount++;
				}catch (FormatException){
					Console.WriteLine("illegal entry, only use numbers");
				}
			}
			avgScore = (double)totalScore / (double)studentCount; 
			Console.WriteLine($"The score is = {avgScore} averaged from {studentCount} students");
			Console.Read();
            */
        }
    }
}
