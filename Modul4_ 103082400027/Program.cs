using Modul4__103082400027;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PENGUJIAN KODE POS ===");
        KodePos kodePos = new KodePos();

        Console.WriteLine("Kode Pos Batununggal : " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kujangsari  : " + kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos Mengger     : " + kodePos.GetKodePos("Mengger"));
        Console.WriteLine("Kode Pos Wates       : " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos Cijaura     : " + kodePos.GetKodePos("Cijaura"));
        Console.WriteLine("Kode Pos Jatisari    : " + kodePos.GetKodePos("Jatisari"));
        Console.WriteLine("Kode Pos Margasari   : " + kodePos.GetKodePos("Margasari"));
        Console.WriteLine("Kode Pos Sekejati    : " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos Kebonwaru   : " + kodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode Pos Maleer      : " + kodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode Pos Samoja      : " + kodePos.GetKodePos("Samoja"));

        Console.WriteLine("\n=== PENGUJIAN DOOR MACHINE ===");
        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.BukaPintu();
        pintu.KunciPintu();
        pintu.KunciPintu();

        Console.ReadLine();
    }
}
