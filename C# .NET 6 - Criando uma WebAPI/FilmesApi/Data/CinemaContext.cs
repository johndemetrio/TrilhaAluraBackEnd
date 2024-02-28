using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class CinemaContext
{
    public CinemaContext(DbContextOptions<CinemaContext> opts) : base(opts)
    {

    }
    public DbSet<Cinema> Cinemas {get; set;}
    public object Cinema { get; set; }
}