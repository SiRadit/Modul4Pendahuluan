using Modul4__103082400027;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PENGUJIAN KODE POS ===");

        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal : " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Wates       : " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos Maleer      : " + kodePos.GetKodePos("Maleer"));

        Console.ReadLine();
    }
}
