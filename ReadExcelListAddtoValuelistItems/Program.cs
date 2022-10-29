// Creating a Client Connection
// Instantiate an MFilesClientApplication object.
// https://www.m-files.com/api/documentation/index.html#MFilesAPI~MFilesClientApplication.html
using MFilesAPI;

var mfClientApplication = new MFilesClientApplication();

// Find all connections to the vault with GUID {C840BE1A-5B47-4AC0-8EF7-835C166C8E24},
// then select the first one and bind to it if we can.
// Note: this will return null if no connections are created.
var vault = mfClientApplication.GetVaultConnectionsWithGUID("{A297AF69-4DC5-4F05-8074-C66178F4C7FD}")
    .Cast<VaultConnection>()
    .FirstOrDefault()?
    .BindToVault((long)IntPtr.Zero, CanLogIn: true, ReturnNULLIfCancelledByUser: true);

Console.WriteLine($"Hello, World! {vault.Name}");
//Instantiate the spreadsheet creation engine
string filepath = @"C:\Users\Samuel\Documents\Expense_Accounts.csv";
StreamReader reader = null;
if(File.Exists(filepath))
{
    reader = new StreamReader(File.OpenRead(filepath));    
    List<string> ListA = new List<string>();
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(',');
        foreach (var item in values)
        //{
        //    ListA.Add(item.Trim());
        //}
        //foreach (var column1 in ListA)
        //{
            //vault.ValueListItemOperations.AddValueListItem(215, new ValueListItem { Name = item }, false);
            Console.WriteLine("The value {0} has been added", item.Trim());
        //}
        //Console.WriteLine(values.Count);
    }       
}
else
{
    Console.WriteLine("File does not exists");
}
Console.ReadLine();
    //vault.ValueListItemOperations.AddValueListItem(215, new ValueListItem { Name = "textbook" }, false);

