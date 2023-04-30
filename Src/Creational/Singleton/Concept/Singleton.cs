namespace CsharpDesignPatterns.Concept;

public class  Singleton
{
    private Singleton() {
        SingletonTestValue = "Text for testing singleton pattern";
    }

    private static Singleton? _instance;
    public string SingletonTestValue { get; set; }

    private static readonly object _lock = new object();
    public static Singleton GetInstance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }                
            }
            return _instance;
        }
    }
}