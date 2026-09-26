public class Program // Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Benvenuto nella Easy Class 3E");

        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = 2;

        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco + numeroPacchiComprati;

        Console.WriteLine("Il tipo di consegna selezionata è: " + tipoConsegna);
        Console.WriteLine(costoTotale);

    }
}
