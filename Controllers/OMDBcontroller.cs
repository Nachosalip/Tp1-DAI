using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using API.Models;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OMDBController : ControllerBase
{
    [HttpGet("movie")]
    public async Task<IActionResult> GetById([FromQuery] string id)
    // https://www.omdbapi.com/?apikey=c5834470&i=tt2446040
    // http://localhost:5000/api/OMDB/movie?id=tt2446040
    {
        //return Ok("hola");
        //https://www.omdbapi.com/?apikey=c5834470&s=toy
        string apiResponse = await HTTPHelper.GetContentAsync("https://www.omdbapi.com/?apikey=c5834470&i=" + id, null);
        //Console.WriteLine (apiResponse);
        //var returnValue = JsonSerializer.Deserialize<Movie>(apiResponse);

        return Ok(apiResponse);
    }

    [HttpGet("search/{titulo}")]
    public async Task<IActionResult> GetByTitulo(string titulo)
    // https://www.omdbapi.com/?apikey=c5834470&i=tt2446040
    // http://localhost:5000/api/OMDB/movie?id=tt2446040
    {
        //return Ok("hola");
        //https://www.omdbapi.com/?apikey=c5834470&s=toy
        string apiResponse = await HTTPHelper.GetContentAsync("https://www.omdbapi.com/?apikey=c5834470&s=" + titulo, null);
        //Console.WriteLine (apiResponse);
        //var returnValue = JsonSerializer.Deserialize<Movie>(apiResponse);

        return Ok(apiResponse);
    }



}

