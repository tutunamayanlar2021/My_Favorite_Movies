﻿using OrnekPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
{
        new Movie {
        MovieId=1,
        Title="Jiu Jitsu",
        Description="Every six years, an ancient order of jiu-jitsu fighters joins forces to battle a vicious race of alien invaders. But when a celebrated war hero goes down in defeat, the fate of the planet and mankind hangs in the balance.",
        Director="Dimitri Logothetis",
        Player=new string[] { "Nicolas Cage", "Alain Moussi"},
        ImageUrl="1_.jpeg",
        TurId=1
    },
    new Movie {
        MovieId=2,
        Title="Fatman",
        Description="A rowdy, unorthodox Santa Claus is fighting to save his declining business. Meanwhile, Billy, a neglected and precocious 12 year old, hires a hit m...",
        Director="Eshom Nelms",
        Player=new string[] { "Mel Gibson", "Walton Goggins","Michelle Lan"},
        ImageUrl="revelant.jpg",
        TurId=1
    },
    new Movie {
        MovieId=3,
        Title="The Dalton Gang",
        Description="When their brother Frank is killed by an outlaw, brothers Bob Dalton, Emmett Dalton and Gray Dalton join their local sheriff's department. When the...",
        Director="Christopher Forbes",
        Player=new string[] { "oyuncu 1","oyuncu 2"},
        ImageUrl="k.jpg",
        TurId=3
    },
        new Movie {
        MovieId=4,
        Title="Tenet",
        Description="Armed with only one word - Tenet - and fighting for the survival of the entire world, the Protagonist journeys through a twilight world of internat...",
        Director="Christopher Nolan",
        Player=new string[] { "Robert Pattinson", "Elizabeth Debicki"},
        ImageUrl="revelant.jpg",
        TurId=3
    },
    new Movie {
        MovieId=5,
        Title="The Craft: Legacy",
        Description="An eclectic foursome of aspiring teenage witches get more than they bargained for as they lean into their newfound powers.",
        Director="Zoe Lister-Jones",
        Player=new string[] { "Cailee Spaeny", "Zoey Luna"},
        ImageUrl="1_.jpeg",
       TurId=3
    },
    new Movie {
        MovieId=6,
        Title="Hard Kill",
        Description="The work of billionaire tech CEO Donovan Chalmers is so valuable that he hires mercenaries to protect it, and a terrorist group kidnaps his daughte...",
        Director="Matt Eskandari",
        Player=new string[] { "Bruce Willis", "Jesse Metcalfe"},
        ImageUrl="1_.jpeg",
        TurId=4
    }
};
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void Add(Movie movie )
        {
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m=>m.MovieId==id);
        }
        public static void Edit(Movie m)
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId) {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.ImageUrl = m.ImageUrl;
                    movie.TurId = m.TurId;
                    break;
                } ;
            }
        }
        public static void Delete(int MovieId)
        {
            var movie = GetById(MovieId);
            if (movie!=null)
            {
                _movies.Remove(movie);
            }
        }
    }
}