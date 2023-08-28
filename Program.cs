// // Three Basic Arrays
// // Create an integer array with the values 0 through 9 inside.
// // int [] arr= {0,1,2,3,4,5,6,7,8,9};
// // Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
// // string[] names={"Tim", "Martin", "Nikki", "Sara"};
// // Create a boolean array of length 10. Then fill it with alternating true/false values, 
// // starting with true. (Tip: do this using logic! Do not hard-code the values in!)

bool [] array= new bool [10];
for (int i=0; i<array.Length; i+=2)
{
    array[i]= true;
}
//check
foreach( bool value in array)
{
    Console.WriteLine(value);
}

// // List of Flavors
// // Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;

List <string> icecream= new List <string> (5);

// Output the length of the List after you added the flavors.
icecream.Add("chocolate");
icecream.Add("pistachio");
icecream.Add("mint");
icecream.Add("vanilla");
icecream.Add("coffee");

for (int idx=0; idx<icecream.Count; idx++)
{
    Console.WriteLine(icecream[idx]);
}

// Output the third flavor in the List.
Console.WriteLine(icecream[2]);
// Now remove the third flavor using its index location.
icecream.RemoveAt(2);
for (int idx=0; idx<icecream.Count; idx++)
{
    Console.WriteLine(icecream[idx]);
}

// // Output the length of the List again. It should now be one fewer.
Console.WriteLine(icecream.Count);

// // User Dictionary
// // Create a dictionary that will store string keys and string values.
string[] names={"Tim", "Martin", "Nikki", "Sara"};
Dictionary <string, string> profile= new Dictionary<string, string> ();
// // Add key/value pairs to the dictionary where:
// // Each key is a name from your names array (this can be done by hand or using logic)
// // Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
 
    // int randIndex= rnd.Next(icecream.Count);
    // string random= icecream[randIndex];

    foreach(string name in names)
    {
        profile.Add(name, null);
    }

    Random rnd= new Random();
    foreach (string name in names){
        int randIndex= rnd.Next(icecream.Count);
        profile[name]=icecream[randIndex];
        icecream.RemoveAt(randIndex);
    }



//     // profile.Add (names[0], random);
//     // profile.Add (names[1], random);
//     // profile.Add (names[2], random);
//     // profile.Add (names[3], random);

// // int i=0;
// // while (i<names.Length)
// // {
// //     profile.Add (names[i], null);
// //     i++;

// // }
// // foreach(KeyValuePair<string,string> entry in profile)
// // {
// //     profile[entry.Value]= random;
// //     icecream.RemoveAt(randIndex);
// // }



// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach(KeyValuePair<string,string> entry in profile)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}
