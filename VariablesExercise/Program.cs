namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string bookTitle = "Retrospection of Hampton";

            double bookPrice = 15.99;

            decimal dealPrice = 30.00m;

          

            char tier = 'A';

            int bookRating = 95;
                
            Console.WriteLine($"Are you looking for {bookTitle}?");
            
            bool favorsBook = true;
            bool dislikesBook = false;
            if (favorsBook && !dislikesBook)
            {
                Console.WriteLine("That one is recommended a lot.");
            }
            Console.WriteLine($"If I had to give it a rating it'd be {bookRating}. Truly an {tier} tier story.");
            Console.WriteLine($"It goes for {bookPrice}, but you can get two for {dealPrice}.");
        }
    }
}
