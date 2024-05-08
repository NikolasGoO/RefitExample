using Refit;
using RefitProject.InterfaceApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var chuckNorrisApi = RestService.For<IChuckNorrisApi>("https://api.chucknorris.io");

            var jokeResponse = await chuckNorrisApi.GetRandomJoke();
            Console.WriteLine("Chuck Norris Joke: " + jokeResponse.Value);

            Console.WriteLine("\n\nDo you want another joke?\nPress Y for Yes\nPress another key for No\n");
            var response = Console.ReadLine();

            while (response == "y" || response == "Y")
            {
                Console.WriteLine("Chuck Norris Joke: " + jokeResponse.Value);
                Console.WriteLine("\n\nDo you want another joke?\nPress Y for Yes\nPress another key for No\n");
                response = Console.ReadLine();
            }

            Console.WriteLine("Bye! Bye!");
        }
    }
}
