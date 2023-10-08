public class Journal {
    public List<string> _entries = new List<string> ();

    public void displayEntries() {
        Console.WriteLine("Entries: ");
        foreach (string entry in _entries) {
            Console.WriteLine($"{entry}\n");
        }
    }

    // saves entries to a file and allows to set a file name
    public void saveEntries() {
        Console.Write("Enter the file to save to: ");
        string fileName = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(string entry in _entries){
                outputFile.WriteLine(entry);
            }
            
        }
    }
    
    // loads file, allows user to input file name to be loaded
    public void loadEntries() {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        var lines = System.IO.File.ReadLines(fileName);
        
        // iterate through the lines and adds the lines to 
        // the journal entry list
        foreach (string line in lines) {
            string fileEntry = line;
            _entries.Add(fileEntry);
        }
    }
}