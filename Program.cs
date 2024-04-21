const int MAX_FLASHCARDS = 1000;
string [] question = new string [MAX_FLASHCARDS];
string [] possibleAnswer1 = new string [MAX_FLASHCARDS];
string [] possibleAnswer2 = new string [MAX_FLASHCARDS];
string [] possibleAnswer3 = new string [MAX_FLASHCARDS];
string [] possibleAnswer4 = new string [MAX_FLASHCARDS];
string [] answer = new string [MAX_FLASHCARDS];

Console.Clear();
int userChoice = DisplayMenu();
while(userChoice != 10)
{
    Console.Clear();
    RouteEm(userChoice,question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer);
    Console.Clear();
    userChoice = DisplayMenu();
}

static int DisplayMenu()
{
    System.Console.WriteLine("1)Basic Disney Trivia\n2)Advanced Disney Trivia\n3)Park Trivia\n4)Create a new trivia!\n5)Use a custom trivia");
    return int.Parse(System.Console.ReadLine());
}

static void RouteEm(int userChoice,string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer)
{
    switch(userChoice)
    {
        case 1:
        DisneyTrivia();
        break;
        case 2:
        AdvancedDisneyTrivia();
        break;
        case 3:
        ParkTrivia();
        break;
        case 4:
        NewTrivia(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer);
        break;
        case 5:
        int count = GetExistingTrivia(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer);
        UseCustomTrivia(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer,count);
        break;
        default:
        DisplayError();
        break;
    }
}

static void DisplayError()
{
    System.Console.WriteLine("Sorry, that is not a choice. Please try again!");
}

static void DisneyTrivia()
{
    int points = 0;
    int userChoice = UserChoice();
    while(userChoice != 2)
    {
    TriviaRules();
    DisneyTriviaRoundOne(ref points);
    DisneyTriviaRoundTwo(ref points);
    DisneyTriviaRoundThree(ref points);
    DisneyTriviaRoundFour(ref points);
    DisneyTriviaRoundFive(ref points);
    System.Console.WriteLine($"Total Points from game: {points}");
    userChoice = UserChoice();
    }
}

static int UserChoice()
{
    System.Console.WriteLine("Would you like to play? Enter 1 to play and 2 to go back to the menu");
    return int.Parse(Console.ReadLine());
}

static void TriviaRules()
{
    System.Console.WriteLine("Before you begin.... here are the rules \n You will be presented with a question and 4 possible answers\n press 1,2,3,or 4 to submit your answer\nIf you get the answer correct, you will be awarded 100 points\nGood Luck!!!!!!!");

    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

static void DisneyTriviaRoundOne(ref int points)
{
    System.Console.WriteLine("What is the only Disney animated feature film where the title character does not speak?");
    System.Console.WriteLine("1)Dumbo \n2)Snow White\n3)Bolt\n4)Aladdin");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 1)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void DisneyTriviaRoundTwo(ref int points)
{
    System.Console.WriteLine("Who is the trusted advisor to Mufasa in The Lion King?");
    System.Console.WriteLine("1)Simba \n2)Zazu\n3)Scar\n4)Nala");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 2)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}


static void DisneyTriviaRoundThree(ref int points)
{
    System.Console.WriteLine("Which Disney princess was the first to receive a star on the Hollywood Walk of Fame?");
    System.Console.WriteLine("1)Snow White \n2)Rapunzel\n3)Cinderella\n4)Aurora");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 1)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}


static void DisneyTriviaRoundFour(ref int points)
{
    System.Console.WriteLine("Which Princess is the youngest?");
    System.Console.WriteLine("1)Cinderella\n2)Rapunzel\n3)Snow White \n4)Aurora");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 3)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void DisneyTriviaRoundFive(ref int points)
{
    System.Console.WriteLine("How many sisters does Ariel Have");
    System.Console.WriteLine("1)4\n2)5\n3)6 \n4)7");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 3)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void AdvancedDisneyTrivia()
{
    int points = 0;
    int userChoice = UserChoice();
    while(userChoice != 2)
    {
    TriviaRules();
    Console.Clear();
    AdvancedTriviaRoundOne(ref points);
    AdvancedTriviaRoundTwo(ref points);
    AdvancedTriviaRoundThree(ref points);
    AdvancedTriviaRoundFour(ref points);
    AdvancedTriviaRoundFive(ref points);
    Console.Clear();
    System.Console.WriteLine($"Total Points from game: {points}");
    userChoice = UserChoice();
    }
}

static void AdvancedTriviaRoundOne(ref int points)
{
    System.Console.WriteLine("What character did Walt voice??");
    System.Console.WriteLine("1)Bambi\n2)Goofy\n3)Mickey \n4)Donald");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 3)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void AdvancedTriviaRoundTwo(ref int points)
{
    System.Console.WriteLine("Why did Walt drop out of high school?");
    System.Console.WriteLine("1)To build Disney World\n2)To join a film studio\n3)To join the Red Cross Ambulance Corps \n4)To travel");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 3)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void AdvancedTriviaRoundThree(ref int points)
{
    System.Console.WriteLine("Why did Walt name the model train he built in his backyard?");
    System.Console.WriteLine($"1)Carolwood Pacific Railroad\n2)Oswald's Train \n3)Mickey's Train\n4)The Patriot");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 1)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void AdvancedTriviaRoundFour(ref int points)
{
    System.Console.WriteLine("What character did Walt Disney create before Mickey Mouse?");
    System.Console.WriteLine($"1)No one, Mickey Mouse was first\n2)Oswald \n3)Donald\n4)Goofy");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 2)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void AdvancedTriviaRoundFive(ref int points)
{
    System.Console.WriteLine($"What was the name of Walt's wife?");
    System.Console.WriteLine($"1)Amber\n2)Daisy \n3)ALice\n4)Lillian");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 4)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void ParkTrivia()
{
    int points = 0;
    int userChoice = UserChoice();
    while(userChoice != 2)
    {
    TriviaRules();
    ParkTriviaRoundOne(ref points);
    ParkTriviaRoundTwo(ref points);
    ParkTriviaRoundThree(ref points);
    ParkTriviaRoundFour(ref points);
    ParkTriviaRoundFive(ref points);
    System.Console.WriteLine($"Total Points from game: {points}");
    userChoice = UserChoice();
    }
}

static void ParkTriviaRoundOne(ref int points)
{
    System.Console.WriteLine("What is the fastest ride at Walt Disney World?");
    System.Console.WriteLine("1)Test Track \n2)Space Mountain\n3)Big Thunder Mountain Railroad\n4)Mission Space");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 1)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void ParkTriviaRoundTwo(ref int points)
{
    System.Console.WriteLine("How much was Adult Admission to Walt Disney World on opening day in 1971?");
    System.Console.WriteLine("1)$3.00 \n2)$5.00\n3)$3.50\n4)$10.50");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 3)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}


static void ParkTriviaRoundThree(ref int points)
{
    System.Console.WriteLine("How long did the construction of Disneyland take?");
    System.Console.WriteLine("1)1 year and 1 day \n2)2 years\n3)3 years\n4)4 years and 20 days");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 1)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}


static void ParkTriviaRoundFour(ref int points)
{
    System.Console.WriteLine("What is the most expensive Disney attraction?");
    System.Console.WriteLine("1)Peter Pan\n2)Tower of Terror\n3)Rise of the Resistance \n4)Space Mountain");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 3)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void ParkTriviaRoundFive(ref int points)
{
    System.Console.WriteLine("What year did Tokyo Disneyland open?");
    System.Console.WriteLine("1)1992\n2)2012\n3)2001 \n4)1983");
    System.Console.WriteLine("Please enter your choice!");
    int userChoice = int.Parse(Console.ReadLine());
    if(userChoice == 4)
    {
        points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}
static int GetExistingTrivia(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer)
        {
            System.Console.WriteLine("What is the name of the quiz you created?");
            string fileName = Console.ReadLine().ToLower();
            StreamReader inFile = new StreamReader($"{fileName}.txt");
            int count = 0;
            string line  = inFile.ReadLine();
            while(line != null)
            {
                string [] temp = line.Split("#");
                question[count] = temp[0];
                possibleAnswer1[count] = temp[1];
                possibleAnswer2[count] = temp[2];
                possibleAnswer3[count] = temp[3];
                possibleAnswer4[count] = temp[4];
                 answer[count] = temp[5];
                 count++;
                line = inFile.ReadLine();

            }
            return count;
            inFile.Close();
        }


static void NewTrivia(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer)
{
    int count = 0;
    while(count < 5)
    {
        System.Console.WriteLine("What question would you like to ask?");
        question[count] = Console.ReadLine();
        System.Console.WriteLine("What is the first possible answer?");
        possibleAnswer1[count] = Console.ReadLine();
        System.Console.WriteLine("What is the second possible answer?");
        possibleAnswer2[count] = Console.ReadLine();
        System.Console.WriteLine("What is the third possible answer?");
        possibleAnswer3[count] = Console.ReadLine();
        System.Console.WriteLine("What is the fourth possible answer?");
        possibleAnswer4[count] = Console.ReadLine();
        System.Console.WriteLine("What is the correct answer. Please enter 1,2,3, or 4");
        answer[count] = Console.ReadLine();
        // outFile.WriteLine($"{question[count]}#{possibleAnswer1[count]}#{possibleAnswer2[count]}#{possibleAnswer3[count]}#{possibleAnswer4[count]}#{answer[count]}");
        count++;
    }
    System.Console.WriteLine("What file would you like to save this to?");
    string userChoiceToSaveFile = Console.ReadLine().ToLower();
    StreamWriter outFile = new StreamWriter($"{userChoiceToSaveFile}.txt");
   for(int i = 0; i < count; i++)
   {
     outFile.WriteLine($"{question[i]}#{possibleAnswer1[i]}#{possibleAnswer2[i]}#{possibleAnswer3[i]}#{possibleAnswer4[i]}#{answer[i]}");
   }
    for(int i = 0; i < count; i++)  
    {
    System.Console.WriteLine($"{question[i]}#{possibleAnswer1[i]}#{possibleAnswer2[i]}#{possibleAnswer3[i]}#{possibleAnswer4[i]}#{answer[i]}");
    }
    outFile.Close();
}

static void UseCustomTrivia(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer, int count)
{
RoundOne(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer,count);
RoundTwo(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer,count);
RoundThree(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer,count);
RoundFour(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer,count);
RoundFive(question,possibleAnswer1, possibleAnswer2, possibleAnswer3,possibleAnswer4,answer,count);
}

static void RoundOne(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer, int count)
{
int points = 0;
System.Console.WriteLine($"{question[0]}\n1){possibleAnswer1[0]}\n2){possibleAnswer2[0]}\n3){possibleAnswer3[0]}\nn4){possibleAnswer4[0]}");
int userChoice = int.Parse(Console.ReadLine());
int correctAnswer = int.Parse(answer[0]);
if(userChoice == correctAnswer)
{
    points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void RoundTwo(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer, int count)
{
int points = 0;
System.Console.WriteLine($"{question[1]}\n1){possibleAnswer1[1]}\n2){possibleAnswer2[1]}\n3){possibleAnswer3[1]}\nn4){possibleAnswer4[1]}");
int userChoice = int.Parse(Console.ReadLine());
int correctAnswer = int.Parse(answer[1]);
if(userChoice == correctAnswer)
{
    points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void RoundThree(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer, int count)
{
int points = 0;
System.Console.WriteLine($"{question[2]}\n1){possibleAnswer1[2]}\n2){possibleAnswer2[2]}\n3){possibleAnswer3[2]}\nn4){possibleAnswer4[2]}");
int userChoice = int.Parse(Console.ReadLine());
int correctAnswer = int.Parse(answer[2]);
if(userChoice == correctAnswer)
{
    points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void RoundFour(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer, int count)
{
int points = 0;
System.Console.WriteLine($"{question[3]}\n1){possibleAnswer1[3]}\n2){possibleAnswer2[3]}\n3){possibleAnswer3[3]}\nn4){possibleAnswer4[3]}");
int userChoice = int.Parse(Console.ReadLine());
int correctAnswer = int.Parse(answer[3]);
if(userChoice == correctAnswer)
{
    points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}

static void RoundFive(string [] question, string [] possibleAnswer1, string [] possibleAnswer2, string [] possibleAnswer3, string [] possibleAnswer4,string [] answer, int count)
{
int points = 0;
System.Console.WriteLine($"{question[4]}\n1){possibleAnswer1[4]}\n2){possibleAnswer2[4]}\n3){possibleAnswer3[4]}\nn4){possibleAnswer4[4]}");
int userChoice = int.Parse(Console.ReadLine());
int correctAnswer = int.Parse(answer[4]);
if(userChoice == correctAnswer)
{
    points = points + 100;
        System.Console.WriteLine("Congradulations, you got it correct!!!!! You have been awarded 100 points");
    }else
    {
        System.Console.WriteLine("Better Luck next time!!!");
    }
    System.Console.WriteLine("press any key to continue");
    Console.ReadKey();
    Console.Clear();
}
