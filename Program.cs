﻿using System;
﻿using System.Collections.Generic;

namespace oop_lesson_5_eightball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string> {
              "It is certain.",
              "It is decidely so.",
              "Without a doubt.",
              "Yes definitely.",
              "You may rely on it.",
              "As I see it, yes.",
              "Most likely.",
              "Outlook good.",
              "Yes.",
              "Signs point to yes.",
              "Reply hazy, try again.",
              "Ask again later.",
              "Better not tell you now.",
              "Cannot predict now.",
              "Concentrate and ask again.",
              "Don't count on it.",
              "My reply is no.",
              "My sources say no.",
              "Outlook not so good.",
              "Very doubtful."
            };

            Random rnd = new Random();

            Console.Write("Question: ");
            Console.ReadLine();

            Console.WriteLine(answers[rnd.Next(21)]);
        }
    }
}
