using Movie;

public interface IMovieInterface
{
    void PrintFilmList();
    void SearchMovieList(string text);
    void AddMovieList(string name, DateTime releaseDate, double IMDbRating);
    void RemoveFilmById(int id);
    void SelectedFilms();
}