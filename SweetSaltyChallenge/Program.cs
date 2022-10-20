int startNum, stopNum, perLine;

// Loop to validate startNum & stopNum inputs
do {
    // Start & Stop are assigned to valid ints input by user
    startNum = NumInput("Start Number: ");
    stopNum = NumInput("Stop Number: ");

    // Print warnings when Start & Stop numbers don't meet constraints
    if (stopNum - startNum < 0)
        Console.WriteLine("\n***Start # must be smaller than Stop #***");
    else if (stopNum - startNum > 1000)
        Console.WriteLine("\n***Numbers cannot be more than 1000 apart***");
    // Only breaks out of loop if start & stop meet constraints
    else    break;

    Console.WriteLine("\n---Please Re-Input Numbers---");
} while (true);

// Loop to validate perLine input
do {
    // PerLine is assigned to valid int input by user
    perLine = NumInput("How many numbers should print per line?");

    // Print warnings when number doesn't meet constraints
    if (perLine < 5)
        Console.WriteLine("\n***Must print at least 5 per line***");
    else if (perLine > 30)
        Console.WriteLine("\n***Only up to 30 per line***");
    // Only breaks out of loop if perLine meets constraints
    else    break;
} while (true);

// Instantiate counters to 0 before loop
int sweet = 0, salty = 0, sweetSalty = 0 , lineIndex = 0;

// Iterates through each number from startNum to stopNum
for (; startNum <= stopNum; startNum++) {
    // Establishes new line on console once the desired amount of numbers are on current one
    if (lineIndex == perLine) {
        Console.Write("\n");
        lineIndex = 0;
    }

    // Print number OR phrase & increment counter for each number that meets pre-determined constraints:
    // Sweet when multiple of 3, Salty when multiple of 5, Sweet'nSalty when both
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

    // Incement index of current line for each number's output
    lineIndex++;
}

// Print the total amount of Sweets, Saltys, & Sweet'nSaltys seperately 
Console.WriteLine("\nAmount of Sweet: " + sweet);
Console.WriteLine("Amount of Salty: " + salty);
Console.WriteLine("Amount of Sweet'nSalty: " + sweetSalty);


// Function to validate that user inputs an int in response to a prompt(msg)
int NumInput(string msg) {
    do {
        // Ask user for input through console
        Console.WriteLine(msg);
        string input = Console.ReadLine()!;

        // Only break loop if user's input can be parsed to an int
        if (!String.IsNullOrWhiteSpace(input))
            if (int.TryParse(input, out int number)) return number;

        // Print warning and loop if input is not a valid int
        Console.WriteLine("***Invalid Input*** (Number Only)\n");
    } while (true);
}