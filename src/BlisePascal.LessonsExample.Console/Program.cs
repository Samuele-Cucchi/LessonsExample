using BlaisePascal.LessonsExample.Domain;

public class Program // Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
       

        Console.WriteLine("Inserisci il nome del cliente: "); 
        string customerName = Console.ReadLine(); 

        Console.WriteLine("Inserisci il numero di libri acquistati: ");
        int numberOfBooks = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il prezzo di un singolo libro: ");
        double bookPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Sei uno studente? (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il tipo di consegna (spedizione/ritiro): ");
        string deliveryType = Console.ReadLine();

        double subtotal = numberOfBooks * bookPrice;

        int shipping = 0;

        if(deliveryType == "spedizione")
        {
            shipping = 5;
        }else if (deliveryType == "ritiro")
        {
            
        }else
        {
            Console.WriteLine("Tipo di consegna non valido.");
        }

        double total = subtotal + shipping;

        Console.WriteLine();
        Console.WriteLine("===== ORDINE =====");

        Console.WriteLine("Cliente: " + customerName);
        Console.WriteLine("Libri acquistati: " + numberOfBooks);
        Console.WriteLine("Prezzo unitario: " + bookPrice + " euro");
        Console.WriteLine("Studente: " + isStudent);
        Console.WriteLine("Tipo di consegna: " + deliveryType);
        Console.WriteLine("Subtotale: " + subtotal + " euro");
        Console.WriteLine("Spese di spedizione: " + shipping + " euro");
        Console.WriteLine("Totale finale: " + total + " euro");

        Console.WriteLine();

        if(total <= 0)
        {
            Console.WriteLine("Errore: ordine non valido.");

        }
        else if(total < 20)
        {
            Console.WriteLine("Ordine di piccolo importo");
        }else
        {
            Console.WriteLine("Ordine di grande importo");
        }

        Console.WriteLine("Grazie per il tuo ordine!");
        
        



        }
}
