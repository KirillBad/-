public abstract class AudioTrack
{
    public abstract string GetLanguage();
}

public abstract class Subtitles
{
    public abstract string GetLanguage();
}


public abstract class MovieLanguageFactory
{
    public abstract AudioTrack CreateAudioTrack();
    public abstract Subtitles CreateSubtitles();
}


public class RussianAudioTrack : AudioTrack
{
    public override string GetLanguage() => "Русский";
}

public class RussianSubtitles : Subtitles
{
    public override string GetLanguage() => "Русский";
}


public class EnglishAudioTrack : AudioTrack
{
    public override string GetLanguage() => "Английский";
}


public class EnglishSubtitles : Subtitles
{
    public override string GetLanguage() => "Английский";
}


public class RussianMovieFactory : MovieLanguageFactory
{
    public override AudioTrack CreateAudioTrack() => new RussianAudioTrack();
    public override Subtitles CreateSubtitles() => new RussianSubtitles();
}


public class EnglishMovieFactory : MovieLanguageFactory
{
    public override AudioTrack CreateAudioTrack() => new EnglishAudioTrack();
    public override Subtitles CreateSubtitles() => new EnglishSubtitles();
}


public class Movie
{
    public string Title { get; }
    private AudioTrack audioTrack;
    private Subtitles subtitles;

    public Movie(string title)
    {
        Title = title;
    }

    public void ConfigureLanguage(MovieLanguageFactory factory)
    {
        audioTrack = factory.CreateAudioTrack();
        subtitles = factory.CreateSubtitles();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Фильм: {Title}");
        Console.WriteLine($"Язык аудио: {audioTrack.GetLanguage()}");
        Console.WriteLine($"Язык субтитров: {subtitles.GetLanguage()}");
    }
}


public class Program
{
    public static void Main()
    {
        Movie movie = new Movie("Матрица");
        
        movie.ConfigureLanguage(new RussianMovieFactory());
        movie.ShowInfo();
        
        Console.WriteLine("\nСмена языка...\n");
        
        movie.ConfigureLanguage(new EnglishMovieFactory());
        movie.ShowInfo();
    }
}