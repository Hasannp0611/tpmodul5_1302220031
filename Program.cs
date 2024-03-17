// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class DataGeneric<D>
{
    private D data;
    public DataGeneric(D NIM)
    {
        this.data = NIM;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah NIM: " + this.data);
    }
}
