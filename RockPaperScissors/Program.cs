using System;

string inputPlayer, inputComp;
int playerscore = 0, compscore = 0;
int randomInt;

while (playerscore < 3 && compscore < 3)
{
    Console.WriteLine("Select: rock, paper, scissors");
    Console.WriteLine("-----------------------------");
    inputPlayer = Console.ReadLine();
    Console.WriteLine("-----------------------------");

    Random rnd = new Random();
    randomInt = rnd.Next(1, 4);

    switch (randomInt)
    {
        case 1:
            inputComp = "rock";
            Console.WriteLine("Computer chooses: rock");
            Console.WriteLine("-----------------------------");
            if (inputPlayer == "rock")
            {
                Console.WriteLine("| Draw |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            else if (inputPlayer == "paper")
            {
                playerscore++;
                Console.WriteLine("| Player Won! |" + " Computer: " + compscore +  " Player: "  + playerscore);
                Console.WriteLine("-----------------------------");
            }
            else if (inputPlayer == "scissors")
            {
                compscore++;
                Console.WriteLine("| Computer Won! |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            break;
        case 2:
            inputComp = "paper";
            Console.WriteLine("Computer chooses: paper");
            Console.WriteLine("-----------------------------");
            if (inputPlayer == "rock")
            {
                compscore++;
                Console.WriteLine("| Computer Won! |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            else if (inputPlayer == "paper")
            {
                Console.WriteLine("| Draw |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            else if (inputPlayer == "scissors")
            {
                playerscore++;
                Console.WriteLine("| Player Won! |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            break;

        case 3:
            inputComp = "scissors";
            Console.WriteLine("Computer chooses: scissors");
            Console.WriteLine("-----------------------------");
            if (inputPlayer == "rock")
            {
                playerscore++;
                Console.WriteLine("| Player Won! |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            else if (inputPlayer == "paper")
            {
                compscore++;
                Console.WriteLine("| Computer Won! |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            else if (inputPlayer == "scissors")
            {
                Console.WriteLine("| Draw |" + " Computer: " + compscore + " Player: " + playerscore);
                Console.WriteLine("-----------------------------");
            }
            break;
        default:
            break;
    }
}
if (playerscore == 3)
{

    Console.WriteLine("Player Wins The Game!");
    Console.WriteLine("-----------------------------");
}
else if (compscore == 3)
{
    Console.WriteLine("Computer Wins The Game!");
}
Console.ReadLine();
