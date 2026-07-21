Console.WriteLine("==================================");
Console.WriteLine("Student Exam Weighthing Calculator");
Console.WriteLine("==================================");

// Declare the variables for the test weighting
const double test1Weight = 0.30;
const double test2Weight = 0.50;
const double assignment1Weight  = 0.10;
const double projectWeight = 0.10;

double test1 = GetValidMark("Enter your Test 1 mark (weight:30%):");
double test2 = GetValidMark("Enter your Test 2 mark (weight:50%):" );
double assingment1 = GetValidMark("Enter your Assignment 1 mark (weight:10%):");
double project = GetValidMark("Enter your Project mark (weight:10%):");


// Calculation for weighted average using the weights declared at beginning
double weightedAverage =(test1 * test1Weight) + (test2 * test2Weight) + (assingment1 * assignment1Weight ) + (project * projectWeight);

Console.WriteLine("---------------------------");
Console.WriteLine($"Weighted Average is: {weightedAverage:F2}%");

// Check Threshold eligibility if its 50 and above
if (weightedAverage >=50.0)
{
    Console.WriteLine("Status: Eligible for Examination");
}
else
{
    Console.WriteLine("Status: Inelgible for Examination");
}

Console.WriteLine("--------");

//Method helping to check the validity of user inputs
static double GetValidMark(string prompt)
{
    double mark;
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();

        if(double.TryParse(input, out mark)&& mark >= 0 && mark <= 100)
        {
            return mark;
        }

        Console.WriteLine("[!] Please enter the correct input between 0 and 100.");
    }

}
