using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp2

{
    class faceBookLikeCounterDisplayer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I will post a Like message similar to the ones on Facebook posts. Please enter the names of the people one at a time, pressing Enter between each friend's name.");
            string facebookName;
            ArrayList nameArray = new ArrayList(); 
            int count = 0;
            do
            {
                Console.WriteLine("Please give me a name, when you've typed all names you want to use,  press the  Enter button.");
                facebookName = Console.ReadLine(); //User enters names one at a time and they are stored in the facebookName variable.
                if (facebookName == "")
                {
                    break;  //Once user presses the Enter key twice after entering a name, the program will know they are done typnig names 
                } //loop breaks here when this condition is met.
                else {
                    nameArray.Add(facebookName); //When user enters a name, that name is added to an array list.
                    count++; //A counter I created adds up the number of names the user enters as they enter them.
                }
            } while (true); //Since there is a break condition above, the while condition is just a boolean with the value 'true'.

            if (nameArray.Count == 1) {//Depending on how many names the user enters, a message will pop up.
                Console.WriteLine("{0} likes this", nameArray[0]); //With just one or to names, those names will be displayed.
            }
            if (nameArray.Count == 2)
            {
                Console.WriteLine("{0} and {1} like this", nameArray[0], nameArray[1]);
            }
            if (nameArray.Count >= 3) //With three or more names, names after the last two will have the number counted by the count variable, and 
                                      //The first two names will be displayed, then the remaining names will just be represented by the number of those names.
            {
                Console.WriteLine("{0} ,{1} and {2} others  like this", nameArray[0], nameArray[1], (count - 2));
            } 



        }
    }
}
