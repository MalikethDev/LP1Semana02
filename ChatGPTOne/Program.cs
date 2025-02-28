using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {  
            // Infinite loop to keep the program running
            while (true)
            {
                // Ask the user to ask a question adn store it in a variable
                Console.WriteLine("Please ask a question: ");
                string question = Console.ReadLine();

                // Variable to store the answer 
                // Necessary
                string answer;

                // Recognizing the question and providing an answer
                switch (question)
                {
                    case "How are you?":
                        answer = "I'm good, thank you!";
                        break;

                    case "What's your name?":
                        answer = "I'm ChatGPToOne!";
                        break;

                    case "What's your mission?":
                        answer = "To help you with your questions!";
                        break;

                    case "Are you more intelligent than me?":
                        answer = "I'm just a program, so I don't have intelligence!";
                        break;

                    // If the user enters EXIT the program will end
                    case "EXIT":
                        return;

                    // Default case if the question is not recognized
                    // Necessary
                    default:
                        answer = "I'm not sure how to answer that!";
                        break;
                }

                // Print the answer
                Console.WriteLine(answer);
            } 
        }
    }
}