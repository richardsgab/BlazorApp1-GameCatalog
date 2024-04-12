using BlazorApp1.Models;
using System.Collections.Immutable;

namespace BlazorApp1.Clients
{
	public class GamesClient
	{
		private readonly List<GameSummary> games =
		[
			new(){
			Id = 1,
			Name = "Street Figher II",
			Genre = "Fighting",
			Price = 19.99m,
			ReleaseDate = new DateOnly(1999,7,10)
			},
			new(){
				Id = 2,
				Name = "Final Fantasy XIV",
				Genre = "RPG",
				Price = 59.99m,
				ReleaseDate = new DateOnly(2012,4,10)
			},
			new(){
				Id = 3,
				Name = "FIFA 23",
				Genre = "Sports",
				Price = 69.99m,
				ReleaseDate = new DateOnly(2022,10,10)
			},
		];

		//To get the name of the gender from the Id selected by the user:
		//it create an instance of GenresClient, and the apply the method.
		private readonly Genre[] genres = new GenresClient().GetGenres();


		//method to fetch this data, because as is private, we cannot do it directly .Wll be called in Home
		public GameSummary[] GetGames() => games.ToArray();
		//another way to write it : => [..games];

		//To add a new game to the collection:
		//the var genre is for find the corresponding genre to the Id choosen for the user
		public void AddGame(GameDetails game)
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
			var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));
			var gamesummary = new GameSummary
			{
				Id = games.Count + 1,
				Name = game.Name,
				Genre = genre.Name,

			};
		}
	}
}
