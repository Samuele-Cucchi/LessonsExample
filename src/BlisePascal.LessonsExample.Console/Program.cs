using BlaisePascal.LessonsExample.Domain;

public class Program // Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
       

        Console.WriteLine("Inserisci i nome del cliente: "); // stampo a video il messaggio della richiesta
        string nomeCliente = Console.ReadLine(); // dichiarazione + assegnazione

        Console.WriteLine($"Benvenuto {nomeCliente} nella Easy Class 3E");
        string tipoConsegna = Console.ReadLine(); // dichiarazione

        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = int.Parse(Console.ReadLine());

        

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;

        Console.WriteLine("Il tipo di consegna selezionata è: " + tipoConsegna);
        Console.WriteLine(costoTotale);

        Enemy newEnemy = new Enemy();
    }
}
