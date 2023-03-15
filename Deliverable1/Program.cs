// Deliverable 1 - Restock the Store

Console.WriteLine("Welcome to the Restocking Tool");

// Sodas

int Soda_0 = 100;   // Initial Stock

int Soda_Rstock = 40; // Restock Value 

Console.WriteLine("How many sodas have been sold today? " + Soda_0 + " are in stock.");
    int Soda_sold = int.Parse(Console.ReadLine());  // Reads input for sodas sold 

int Soda_Rem = Soda_0 - Soda_sold; // Sodas remaining 

if (Soda_sold > Soda_0) {
    Console.WriteLine("That Value is too high. Stock not adjusted");
} else if (Soda_Rem < Soda_Rstock) {
    Console.WriteLine("Soda needs to be Restocked.");
} else { 
    Console.WriteLine("There are " + Soda_Rem + " Sodas left.");
}
// Chips 

int Chip_0 = 40;   

int Chip_Rstock = 20; 

Console.WriteLine("How many chips have been sold today? " + Chip_0 + " are in stock.");
int Chip_sold = int.Parse(Console.ReadLine());  
int Chip_Rem = Chip_0 - Chip_sold;

if (Chip_sold > Chip_0) {
    Console.WriteLine("That Value is too high. Stock not adjusted");
} else if (Chip_Rem < Chip_Rstock) {
    Console.WriteLine("Chips needs to be Restocked.");
} else {
    Console.WriteLine("There are " + Chip_Rem + " Chips left.");
}
// Candy 

int Candy_0 = 60;

int Candy_Rstock = 40;

Console.WriteLine("How much Candy has been sold today? " + Candy_0 + " are in stock.");
int Candy_sold = int.Parse(Console.ReadLine());
int Candy_Rem = Candy_0 - Candy_sold;

if (Candy_sold > Candy_0) { 
    Console.WriteLine("That Value is too high. Stock not adjusted");
} else if (Candy_Rem < Candy_Rstock) { 
    Console.WriteLine("Candy needs to be Restocked.");
} else {
    Console.WriteLine("There are " + Candy_Rem + " Candies left.");
}
// Final Message

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

if (Soda_Rem < Soda_Rstock) { 
    Console.WriteLine("Soda needs to be restocked.");
}
if (Chip_Rem < Chip_Rstock) { 
    Console.WriteLine("Chips need to be restocked.");
}
if (Candy_Rem < Candy_Rstock) { 
    Console.WriteLine("Candy needs to be restocked.");
}