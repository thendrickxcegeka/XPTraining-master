using Xunit;
using FluentAssertions;

namespace MovieRental.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void TestCustomer()
        {
            Customer c = new CustomerBuilder().Build();
            c.Should().NotBeNull();
        }

        [Fact]
        public void TestAddRental()
        {
            var customer2 = new CustomerBuilder().WithName("Sallie").Build();
            var movie1 = new Movie("Gone with the Wind", Movie.REGULAR);
            var rental1 = new Rental(movie1, 3); // 3 day rental
            customer2.AddRental(rental1);
        }

        [Fact]
        public void TestGetName()
        {
            var c = new Customer("David");
            c.Name.Should().Be("David");
        }

        [Fact]
        public void StatementForRegularMovie()
        {
            var movie1 = new Movie("Gone with the Wind", Movie.REGULAR);
            var rental1 = new Rental(movie1, 3); // 3 day rental
            var customer2 =
                new CustomerBuilder()
                    .WithName("Sallie")
                    .WithRentals(rental1)
                    .Build();
            var expected = "Rental Record for Sallie\n" +
                                "\tGone with the Wind\t3.5\n" +
                                "Amount owed is 3.5\n" +
                                "You earned 1 frequent renter points";
            var statement = customer2.Statement();
            statement.Should().Be(expected);
        }

        [Fact]
        public void StatementForNewReleaseMovie()
        {
            Movie movie1 = new Movie("Star Wars", Movie.NEW_RELEASE);
            Rental rental1 = new Rental(movie1, 3); // 3 day rental
            Customer customer2 =
                new CustomerBuilder()
                    .WithName("Sallie")
                    .WithRentals(rental1)
                    .Build();
            var expected = "Rental Record for Sallie\n" +
                                "\tStar Wars\t9.0\n" +
                                "Amount owed is 9.0\n" +
                                "You earned 2 frequent renter points";
            var statement = customer2.Statement();
            statement.Should().Be(expected);
        }

        [Fact]
        public void StatementForChildrensMovie()
        {
            var movie1 = new Movie("Madagascar", Movie.CHILDRENS);
            var rental1 = new Rental(movie1, 3); // 3 day rental
            var customer2
                = new CustomerBuilder()
                        .WithName("Sallie")
                        .WithRentals(rental1)
                        .Build();
            var expected = "Rental Record for Sallie\n" +
                                "\tMadagascar\t1.5\n" +
                                "Amount owed is 1.5\n" +
                                "You earned 1 frequent renter points";
            var statement = customer2.Statement();
            statement.Should().Be(expected);
        }

        [Fact]
        public void StatementForManyMovies()
        {
            var movie1 = new Movie("Madagascar", Movie.CHILDRENS);
            var rental1 = new Rental(movie1, 6); // 6 day rental
            var movie2 = new Movie("Star Wars", Movie.NEW_RELEASE);
            var rental2 = new Rental(movie2, 2); // 2 day rental
            var movie3 = new Movie("Gone with the Wind", Movie.REGULAR);
            var rental3 = new Rental(movie3, 8); // 8 day rental
            var customer1
                = new CustomerBuilder()
                    .WithName("David")
                    .WithRentals(rental1, rental2, rental3)
                    .Build();
            var expected = "Rental Record for David\n" +
                                "\tMadagascar\t6.0\n" +
                                "\tStar Wars\t6.0\n" +
                                "\tGone with the Wind\t11.0\n" +
                                "Amount owed is 23.0\n" +
                                "You earned 4 frequent renter points";
            var statement = customer1.Statement();
            statement.Should().Be(expected);
        }

        //TODO make test for price breaks in code.
    }
}
