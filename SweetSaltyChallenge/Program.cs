/*
Get the start and stop numbers (within the 1000 range) from the user. 

You must re-prompt if the difference between the numbers is more than 1000. 

If the numbers are given in the wrong order, re-prompt. (ex. first number 1000, second number 100.)

Get the quantity of numbers you will print on each line from the user. 

You must re-prompt if the quantity chosen by the user is greater than 30 or less than 5 

Print the numbers in groups of what the user says per line with one space separating each number. 

If the number is a multiple of three, print “Sweet” (instead of the number) to the console.     

If the number is a multiple of five, print “Salty” (instead of the number) to the console.     

For numbers which are multiples of both three and five, print “Sweet’nSalty” to the console (instead of the number).     

After the numbers have all been printed to the console, print to the console on 3 separate lines, 

how many "Sweet",  

how many "Salty", and  

how many "Sweet’nSalty" numbers there were.  

'Sweet', 'Salty', and 'Sweet'nSalty' are three separate groups, so "Sweet’nSalty" does not increment "Sweet" or "Salty" (and vice versa).    

Include verbose commentary in the source code to tell me what each few lines are doing. 

Make sure to merge this branch to your main branch, by 5pm today. 
*/

int startNum, stopNum, diff, perLine;

do {
    startNum = NumInput("Start Number: ");
    stopNum = NumInput("Stop Number: ");
    diff = stopNum - startNum;
} while (stopNum - startNum < 0 || stopNum - startNum > 1000);

do {
    perLine = NumInput("How many numbers should print per line?");
} while (perLine < 5 || perLine > 30);

int sweet = 0, salty = 0, sweetSalty = 0 , lineIndex = 0;

for (; startNum <= stopNum; startNum++) {
    if (lineIndex == perLine) {
        Console.Write("\n");
        lineIndex = 0;
    }

    if (startNum % 3 == 0 && startNum % 5 == 0) {
        Console.Write("Sweet'nSalty ");
        sweetSalty++;
    }
    else if (startNum % 3 == 0) { 
        Console.Write("Sweet ");
        sweet++;
    }
    else if (startNum % 5 == 0) {
        Console.Write("Salty ");
        salty++;
    }
    else {
        Console.Write(startNum + " ");
    }

    lineIndex++;
}

Console.WriteLine("\n# of Sweet: " + sweet);
Console.WriteLine("# of Salty: " + salty);
Console.WriteLine("# of Sweet'nSalty: " + sweetSalty);


string RealInput(string msg) {
    string input;
    do {
        if (msg != "")  Console.WriteLine(msg);
        input = Console.ReadLine()!;
    } while (String.IsNullOrWhiteSpace(input));
    return input;
}

int NumInput(string msg) {
    int number;
    bool isNumber;
    do {
        isNumber = int.TryParse(RealInput(msg), out number);
    } while (!isNumber);
    return number;
}