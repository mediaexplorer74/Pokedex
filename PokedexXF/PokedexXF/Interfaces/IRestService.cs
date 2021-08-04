﻿using PokedexXF.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokedexXF.Interfaces
{
    public interface IRestService
    {
        Task<PaginationModel> GetPokemons(string url);
        Task<PokemonModel> GetPokemon(string url);
    }
}