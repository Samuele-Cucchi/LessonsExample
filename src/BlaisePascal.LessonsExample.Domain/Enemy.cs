namespace BlaisePascal.LessonsExample.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        // private: modificatore di accesso che indica che la variabile è accessibile solo all'interno della classe Enemy
        // int: tipo di dato intero
        // _health: nome della variabile privata che rappresenta la salute del nemico
        private int _health;

        private const int _maxHealth = 100; // costante che rappresenta la salute massima del nemico
        public Enemy() { }

    }
       
}
