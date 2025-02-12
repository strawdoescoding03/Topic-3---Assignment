namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sarah T

            // 1)

            // Sarah T

            // 1)

            string courseName, name, attitude, job, firstName, lastName;
            double homelandApplePrice, currentApplePrice, orangPantPrice, radiusCircleOne,
                radiusCircleTwo, areaCircleOne, areaCircleTwo, carDistanceMetres,
                carDistanceKm, driveTimeSeconds,
                driveTimeHours ;
            int compSciRoomNumber, maxPotato, birthYear, gradAge,
                fullYearsLeft,currentYear,
                age;


            //String variables 
            courseName = "Computer Science";
            name = "Sarah the Sasquatch";
            attitude = "Grumpy bum";
            job = "school enthusiast";


            //Double variables           
            homelandApplePrice = 2.99;
            currentApplePrice = 8.97;
            orangPantPrice = 213.98;


            //Int Variables
            compSciRoomNumber = 29;
            maxPotato = 1898899834; // REAL NUMBER :)

            Console.WriteLine("Good Morning!");
            Console.WriteLine("My name is " + name + ", and I'm feeling like a " + attitude + " today.");
            Console.WriteLine("Currently, I am taking " + courseName + " in room " + compSciRoomNumber + ".");
            Console.WriteLine("One could say I'm a bit of a " + job + ".");
            Console.WriteLine();
            Console.WriteLine("Now that you know about me, let me tell you some fun facts about me!");
            Console.WriteLine("In my home land, the price of apples was only " + homelandApplePrice.ToString("C") + " but here it's crazy!");
            Console.WriteLine("Like who wants to spend " + currentApplePrice.ToString("C") + "? Yikes");
            Console.WriteLine("Due to my incredible body, I have to buy custom orange pants, which are unfortunalty " + orangPantPrice.ToString("C") + ":(");
            Console.WriteLine("It's not all bad though because I can fit " + maxPotato + " potatoes in my mouth at the same time!");

            Console.WriteLine();
            Console.WriteLine();

            // 2)


            firstName = "Sarah";
            lastName = "Tiffany";

            birthYear = 2008;
            currentYear = 2025;
            gradAge = 18;
            age = currentYear - birthYear;
            fullYearsLeft = gradAge - age;

            Console.WriteLine("Hello again! I am no longer a Sasquatch! (The curse is gone! Yipeee!)");
            Console.WriteLine("Allow me to properly intoduce myself! I am " + firstName + " " + lastName);
            Console.WriteLine("and I'll graduate in the year " + (birthYear + gradAge) + "!");

            Console.WriteLine("I have " + fullYearsLeft + " full school years left!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Here are some cool math problems for you!");
            Console.WriteLine();
            // 3) Area of A Circle with a variable radius!


            radiusCircleOne = 10.0;
            areaCircleOne = (2.0 * Math.PI * radiusCircleOne);
            radiusCircleTwo = 25.0;
            areaCircleTwo = (2.0 * Math.PI * radiusCircleTwo);

            Console.WriteLine("1) What is the area of the circle if it has a radius of 10 cm?");
            Console.WriteLine("The area of the circle is " + Math.Round(areaCircleOne, 1, MidpointRounding.AwayFromZero) + " cm^2");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2) What is the area of the circle if it has a radius of 25 cm?");
            Console.WriteLine("The area of the circle is " + Math.Round(areaCircleTwo, 1, MidpointRounding.AwayFromZero) + " cm^2");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("3) What is the combined area of the two circles?");
            Console.WriteLine("The combined area of the circles are " + Math.Round(areaCircleOne + areaCircleTwo, 1, MidpointRounding.AwayFromZero) + "cm^2");
            Console.WriteLine();
            Console.WriteLine();
            //4 Own formula (Speed Calculations   (distance over time)


            carDistanceMetres = 33.15;
            carDistanceKm = carDistanceMetres / 1000.00;


            driveTimeSeconds = 1.00;
            driveTimeHours = driveTimeSeconds * 3600.00;

            Console.WriteLine("4) If a car is traveling at 33.15 m/s, how fast is the car travelling in km/h?");
            Console.WriteLine("Therefore, the speed of the car is " + Math.Round(carDistanceKm * driveTimeHours, 2, MidpointRounding.AwayFromZero) + " km/h");

            Console.WriteLine();


            Console.ReadLine();




        }
    }
}
