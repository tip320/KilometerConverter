using System.Linq.Expressions;

namespace KilometerConverter {
    internal class Program {
        static void Main(string[] args) {

            //PrintInfo();
            //KilometersToMiles();
            //SalesTax();
            //InsuranceCalculator();
            //AutoExpensesCalculator();
            //PropertyTax();
            //BodyMassIndex();
            //CaloriesFromFatAndCarbs();
            //StadiumSeating();
            PaintJobEstimator();
            //MonthlySalesTax();

        }//end main   

        static void PrintInfo() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**THIS PROGRAM CONVERTS KILOMETERS TO MILES**");
            Console.ResetColor();
        }//end function

        static void KilometersToMiles () {

            double miles = 0;
            double kilometers = 0;
            const double KM_TO_MI = 0.6214;

            //INPUT
            Console.Write("How many kilometers? ");
            kilometers = double.Parse(Console.ReadLine());

            //PROCESS
            miles = kilometers * KM_TO_MI;

            //OUTPUT
            Console.WriteLine("===============================================");
            Console.WriteLine($"{kilometers} kilometers is equal to {miles} miles.");
        }//end function

        static void SalesTax() {

            double stateTax = 0.0;
            double countyTax = 0.0;
            double totalTax = 0.0;
            double totalSale = 0.0;
            double purchase = 0.0;

            //INPUT
            Console.Write("Please enter purchase amount: ");
            purchase = double.Parse(Console.ReadLine());

            //PROCESS
            stateTax = StateTax(purchase);
            countyTax = CountyTax(purchase);
            totalTax = TotalTax(stateTax, countyTax);
            totalSale = purchase + totalTax;


            //OUTPUT    


            Console.WriteLine("===============================================");
            Console.WriteLine($"Subtotal: ${purchase:F2}");
            Console.WriteLine($"State Tax: ${stateTax:F2}");
            Console.WriteLine($"County Tax: ${countyTax:F2}");
            Console.WriteLine($"Total Tax: ${totalTax:F2}");
            Console.WriteLine($"Grand Total: ${totalSale:F2}");

        }//end function

        static double StateTax(double purchase) {

            double stateTax = 0.0;
            stateTax = purchase * 0.04;
            return stateTax;
        }//end function

        static double CountyTax(double purchase) {

            double countyTax = 0.0;
            countyTax = purchase * 0.02;
            return countyTax;
        }//end function

        static double TotalTax(double stateTax, double countyTax) {

            double totalTax = 0.0;
            totalTax = stateTax + countyTax;
            return totalTax;
        }//end function

         
        static void InsuranceCalculator() {

            double replacementCost = 0.0;
            double minInsurance = 0.0;
            const double INSURANCE_MINIMUM = 0.8;

            //INPUT

            Console.Write("Please enter property value: $");
            replacementCost = double.Parse(Console.ReadLine());

            //PROCESS
            minInsurance = replacementCost * INSURANCE_MINIMUM;

            //OUTPUT

            Console.WriteLine("===============================================");
            Console.WriteLine($"${minInsurance:F2}");
        }//end function
        static void AutoExpensesCalculator() {

            double loan = 0.0;
            double insurance = 0.0;
            double gas = 0.0;
            double oil = 0.0;
            double tires = 0.0;
            double maintenance = 0.0;
            double monthlyCosts = 0.0;
            double annualCosts = 0.0;
            const double ANNUAL = 12;

            //INPUT
            Console.Write("Enter the monthly cost for your loan: $");
            loan = double.Parse(Console.ReadLine());
            Console.Write("Enter the monthly cost for your insurance: $");
            insurance = double.Parse(Console.ReadLine());
            Console.Write("Enter the monthly cost for your gas: $");
            gas = double.Parse(Console.ReadLine());
            Console.Write("Enter the monthly cost for your oil: $");
            oil = double.Parse(Console.ReadLine());
            Console.Write("Enter the monthly cost for your tires: $");
            tires = double.Parse(Console.ReadLine());
            Console.Write("Enter the monthly cost for your maintenance: $");
            maintenance = double.Parse(Console.ReadLine());

            //PROCESS

            monthlyCosts = loan + insurance + gas + oil + tires + maintenance;
            annualCosts = monthlyCosts * ANNUAL;

            //OUTPUT

            Console.WriteLine("===============================================");
            Console.WriteLine($"Monthly Costs: ${monthlyCosts}");
            Console.WriteLine($"Annual Costs: ${annualCosts}");
        }//end function

        static void PropertyTax() {


        }//end function

        static void BodyMassIndex() {

            //VARIABLES
            double weight = 0.0;
            double height = 0.0;
            double BMI = 0.0;

            //INPUT

            Console.Write("Please enter weight in pounds: ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Please enter height in inches: ");
            height = double.Parse(Console.ReadLine());

            //PROCESS

            BMI = weight * 703 / (height * height);


            //OUTPUT
            Console.WriteLine("===============================================");
            Console.WriteLine($"BMI = {BMI:F2}");
            
        }//end function


        static void CaloriesFromFatAndCarbs() {

            //VARIABLES
            double fatG = 0.0;
            double carbG = 0.0;
            double fatCal = 0.0;
            double carbCal = 0.0;

            //INPUT
            Console.Write("Please enter the number of fat grams you've comsumed today: ");
                fatG = double.Parse(Console.ReadLine());
            Console.Write("Please enter the number of carbohydrate grams you've consumed today: ");
                carbG = double.Parse(Console.ReadLine());

            //PROCESS

            fatCal = fatG * 9;
            carbCal = carbG * 4;

            Console.WriteLine("===============================================");
            Console.WriteLine($"The number of calories that result from the fat is: {fatCal}");
            Console.WriteLine($"The number of calories that result from the carbohydrates is: {carbCal}");
        }//end function

        static void StadiumSeating() {
        
            double tixA = 0.0;
            double tixB = 0.0;
            double tixC = 0.0;
            double classA = 0.0;
            double classB = 0.0;
            double classC = 0.0;   
            double totalIncome = 0.0;

            Console.Write("How many tickets were sold out of Class A ($15)?  ");
            tixA = double.Parse(Console.ReadLine());
            Console.Write("How many tickets were sold out of Class B ($12)? ");
            tixB = double.Parse(Console.ReadLine());
            Console.Write("How many tickets were sold out of Class C ($9)? ");
            tixC = double.Parse(Console.ReadLine());

            classA = tixA * 15;
            classB = tixB * 12;
            classC = tixC * 9;
            totalIncome = classA + classB + classC;



            Console.WriteLine("===============================================");
            Console.WriteLine($"Total income generated: ${totalIncome}");
        
        }//end function

        static void PaintJobEstimator() {

            //VARIABLES
                double squareFeet = 0.0;
                double pricePerGallon = 0.0;
                double gallonOfPaint = 0.0;
                double laborHours = 0.0;
                double paintCost = 0.0;
                double laborCharge = 0.0;
                double totalCost = 0.0;

            //INPUT
                Console.Write("Please enter the square feet of wall space to be painted: ");
                squareFeet = double.Parse(Console.ReadLine());
                Console.Write("Please enter the price of the paint per gallon: $");
                pricePerGallon = double.Parse(Console.ReadLine());

            //PROCESS

                const double SQUARE_FEET = 115;
                const double LABOR_DAY = 14.375;
                const double HOUR_LABOR = 20;

                gallonOfPaint = squareFeet / SQUARE_FEET;
                laborHours = squareFeet / LABOR_DAY;
                paintCost = gallonOfPaint * pricePerGallon;
                laborCharge = laborHours * HOUR_LABOR;
                totalCost = gallonOfPaint + paintCost + laborCharge;

            //OUTPUT
                Console.WriteLine($"Number of gallons required: {gallonOfPaint:F2}");
                Console.WriteLine($"Hours of labor required: {laborHours:F2}");
                Console.WriteLine($"Cost of paint: ${paintCost:F2}");
                Console.WriteLine($"Labor charges: ${laborCharge:F2}");
                Console.WriteLine($"Total cost: ${totalCost:F2}");
        }//end function

        static void MonthlySalesTax() {

            double totalSales = 0.0;
            double stateTax = 0.0;
            double countyTax = 0.0;
            double totalTax = 0.0;
            const double STATE_TAX_RATE = 0.04;
            const double COUNTY_TAX_RATE = 0.02;


            Console.Write("Please input the amount of total sales: $");
            totalSales = double.Parse(Console.ReadLine());

            stateTax = totalSales * STATE_TAX_RATE;
            countyTax = totalSales * COUNTY_TAX_RATE;
            totalTax = stateTax + countyTax;

            Console.WriteLine("==========================================");
            Console.WriteLine($"County Tax: ${countyTax:F2}");
            Console.WriteLine($"State Tax: ${stateTax:F2}");
            Console.WriteLine($"Total Tax: ${totalTax:F2}");

        }//end function




    }//end class
}//end namespace