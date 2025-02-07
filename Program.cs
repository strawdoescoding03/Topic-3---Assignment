namespace Topic_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sarah T

            // 1)
            
            string course_name, name, attitude, job;
            double homeland_apple_price, current_apple_price, orange_pant_price;
            int comp_sci_room_number, max_potato;

            
            //String variables 
            course_name = "Computer Science";
            name = "Sarah the Sasquatch";
            attitude = "Grumpy bum";
            job = "School Enthusiast";


            //Double variables           
            homeland_apple_price = 2.99;
            current_apple_price = 8.97;
            orange_pant_price = 213.98;


            //Int Variables
            comp_sci_room_number = 29;
            max_potato = 1898899834; // REAL NUMBER :)

            Console.WriteLine("Good Morning!");
            Console.WriteLine("My name is " + name + ", and I'm feeling like a " + attitude + " today.");
            Console.WriteLine("Currently, I am taking " + course_name + " in room " + comp_sci_room_number + ".");
            Console.WriteLine("One could day I'm a bit of a " + job + ".");
            Console.WriteLine();
            Console.WriteLine("Now that you know about me, let me tell you some fun facts about me!");
            Console.WriteLine("In my home land, the price of apples was only " + homeland_apple_price.ToString("C") + " but here it's crazy!");
            Console.WriteLine("Like who wants to spend " + current_apple_price.ToString("C") + "? Yikes");
            Console.WriteLine("Due to my incredible body, i have to buy custom pants, which are unfortunalty " + orange_pant_price.ToString("C") + ":(");
            Console.WriteLine("It's not all bad though because I can fit " + max_potato + " potatoes in my mouth at the same time!");

            Console.WriteLine();
            Console.WriteLine();
               
            // 2)

            string first_name, last_name;
            int birth_year, grad_age;

            first_name = "Sarah";
            last_name = "Tiffany";

            birth_year = 2008;
            grad_age = 18;

            Console.WriteLine("Hello again! I am no longer a Sasquatch! (The curse is gone! Yipeee!)");
            Console.WriteLine("Allow me to properly intoduce myself! I am " + first_name + " " + last_name);
            Console.WriteLine("and I'll graduate in the year " + (birth_year + grad_age) + "!");

            Console.WriteLine();
            Console.WriteLine();


            // 3) Area of A Circle with a variable radius!

            double radius_circle_one,
                radius_circle_two,
                area_circle_one;

            radius_circle_one = 10.0;
            area_circle_one = (2.0 * Math.PI * radius_circle_one);
            radius_circle_two = 25.0;


            Console.WriteLine("1) What is the area of the circle if it has a radius of 10?");
            Console.WriteLine("The area of the circle is " + Math.Round((area_circle_one));
                



        }
    }
}
