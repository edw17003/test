// Runs the game sequence
public class Director
{
    public bool isDirecting = true;
    public Card card1 = new Card();
    public Card card2 = new Card();

    public Director()
    {
    }

    public void StartGame()
    {
        while(isDirecting == true)
        {
            DoInputs();
            DoUpdates();
            DoOutputs();
        }
    }

    public void DoInputs()
    {
        System.Console.WriteLine($"The first card number is {card1.number}");
        System.Console.WriteLine($"The second card number is {card2.number}");

        System.Console.Write("Enter a new number for the first card: ");
        string input = System.Console.ReadLine();
        System.Console.WriteLine();

        if (input == "q")
        {
            isDirecting = false;
        }
        else
        {
            card1.number = System.Int32.Parse(input);      
        }
    }

    public void DoUpdates()
    {
        
    }

    public void DoOutputs()
    {
        int result = card1.CompareTo(card2);
        if (result == 1)
        {
            System.Console.WriteLine("Card1 was higher");
        }
        else if (result == -1)
        {
            System.Console.WriteLine("Card1 was lower");
        }
        else
        {
            System.Console.WriteLine("They are the same.");
        }
    }
}