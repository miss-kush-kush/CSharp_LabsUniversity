using static DBUsage.CRUDFunctions;
using static System.Console;
bool exit = false;
while(!exit)
{
    WriteLine("Choose an option:");
    WriteLine("1: Add new Faktura");
    WriteLine("2: View all Faktury");
    WriteLine("3: Update a Faktura");
    WriteLine("4: Delete a Faktura");
    WriteLine("5: Exit");

    var choice = ReadLine();
    decimal value;
    int id;
    switch (choice)
    {
        case "1":
            WriteLine("Enter Faktura number:");
            string number = ReadLine();

            WriteLine("Enter Faktura value:");
            value = Convert.ToDecimal(ReadLine());
            AddFaktura(number, value);

            WriteLine("Faktura added successfully.");
            break;
        case "2":
            ViewFaktury();
            break;
        case "3":
            WriteLine("Enter Faktura ID to update:");
            id = Convert.ToInt32(ReadLine());
            WriteLine("Enter new Faktura value:");
            value = Convert.ToDecimal(ReadLine());
            UpdateFaktura(id, value);
            break;
        case "4":
            WriteLine("Enter Faktura ID to delete:");
            id = Convert.ToInt32(ReadLine());
            DeleteFaktura(id);
            break;
        case "5":
            exit = true;
            break;
        default:
            WriteLine("Invalid choice.");
            break;
    }
}
