using System;
// Keep track of it's number and provide method for comparison
public class Card
{
    public int number = 1;
    Random random = new Random();

    public Card()
    {
    }

    public int randomInt()
    {
        return random.Next(1, 13);
    }  

    public int CompareTo(Card other)
    {
        int result = 0; // they're the same
        if (this.number > other.number) // 
        {
            result = 1;
        }
        if (this.number < other.number) // card1 is lower
        {
            result = -1;
        }
        return result;
    }

    // public bool isCorrect( int except, bool high )
    // {
    //     int result = random.Next( 1, 12 );
    //     if (result >= except) result += 1;
    //     return ((result > except) == high);
    // }
}