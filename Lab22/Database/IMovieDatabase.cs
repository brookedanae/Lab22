using Lab22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Database
{
    public interface IMovieDatabase
    {
        List<MovieViewModel> Get();
    }
}
