// See https://aka.ms/new-console-template for more information

// Arrays:
string[] myGroceryArray = new string[5];

myGroceryArray[0] = "Milk";
myGroceryArray[1] = string.Empty;

Console.WriteLine(myGroceryArray[0]);
Console.WriteLine(myGroceryArray[1]);
Console.ReadLine();

string[] mySecondGroceryArray = { "banana", "apples", "raisins" };
Console.WriteLine(mySecondGroceryArray[0]);
Console.ReadLine();

// Lists:
List<string> myGroceryList = new List<string>() {"Sweets", "catfood", "herbs" };       // need () because you're actually calling the constructor of the List Class
Console.WriteLine(myGroceryList[0]);
Console.WriteLine(myGroceryList[1]);

Console.ReadLine();
myGroceryList.Add("chopsticks");
Console.WriteLine(myGroceryList[3]);
Console.ReadLine();

// IEnumerable:
IEnumerable<string> myGroceryIEnumerable = myGroceryList;
Console.WriteLine(myGroceryIEnumerable.First());
Console.ReadLine();

// 2D Array:
string[,] myTwoDimensionalArray = new string[,]{
    {"Sweets", "catfood", "herbs"},
    { "banana", "apples", "raisins" }
};

Console.WriteLine(myTwoDimensionalArray[0,0]);
Console.ReadLine();

// Dictionary:
Dictionary<string, string[]> myDictionary = new Dictionary<string, string[]>(){
    {"Diary", new string[]{"Cheese", "Yoghurt", "Cream"}}
};

Console.WriteLine(myDictionary["Diary"][1]);
Console.ReadLine();