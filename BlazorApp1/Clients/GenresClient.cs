using BlazorApp1.Models;

namespace BlazorApp1.Clients
{
    public class GenresClient
    {
        private readonly Genre[] genres =
            [
                new(){
                    Id = 1,
                    Name = "Fighting"
                }, 
                new(){
                    Id = 2,
                    Name = "RPG"
                },
                new(){
                    Id = 3,
                    Name = "Sports"
                }, 
                new(){
                    Id = 4,
                    Name = "Music"
                },
                new(){
                    Id = 5,
                    Name = "Puzzles"
                }
            ];
        //to retrieve the list of genres
        public Genre[] GetGenres() => genres;
    }
}
