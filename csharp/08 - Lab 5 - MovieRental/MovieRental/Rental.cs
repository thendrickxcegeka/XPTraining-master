namespace MovieRental
{
    /**
     * The rental class represents a customer renting a movie.
     */
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public int DaysRented { get; }
        public Movie Movie { get; }

    }
}
