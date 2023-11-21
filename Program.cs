
Class Func = new Class(100);
Func.Notify += DisplayMessage;
Func.Summa(70);



void DisplayMessage(string message) => Console.WriteLine(message);


public class Class
{
    public delegate void Handler(string message);
    public event Handler? Notify;
    public Class(int sum) => Sum = sum;
    public int Sum { get; set; }
    public void Summa(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"Со счета снято: {sum}"); 
    }
}