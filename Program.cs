// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public String SapaUser(String X) {
        return "Halo " + X;
    }


}

class Program
{
    static void Main(String[] args)
    {
        HaloGeneric sapaan = new HaloGeneric();
        String nama = "Hasan Nurrahman";
        String sapa = sapaan.SapaUser(nama);
        Console.WriteLine(sapa);
    }
}

