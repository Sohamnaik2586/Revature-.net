var logger1 = SingletonLogger.CreateStaticLogger();
var logger2 = SingletonLogger.CreateStaticLogger();
var logger3 = SingletonLogger.CreateStaticLogger();


Console.WriteLine(logger1.GetHashCode());
Console.WriteLine(logger2.GetHashCode());
Console.WriteLine(logger3.GetHashCode());
public class SingletonLogger
{
    private static SingletonLogger? singletonInstance;
    private SingletonLogger(){}
    public static SingletonLogger CreateStaticLogger()
    {
       singletonInstance ??= new SingletonLogger();
       return singletonInstance; 
    }
}