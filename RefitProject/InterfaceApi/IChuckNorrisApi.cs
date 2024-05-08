using Refit;
using RefitProject.IntegrationClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitProject.InterfaceApi
{
    public interface IChuckNorrisApi
    {
        [Get("/jokes/random")]
        Task<JokeResponse> GetRandomJoke();
    }
}
