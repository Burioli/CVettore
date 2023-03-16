using System;
using System.Linq;

public class Vettore {

    private int[] vettore;
    private  int idx = 0;

    //costruire vuoto che crea interamente un vettore di un solo elemento intero inizializzato  zero

    public Vettore () {
        
        vettore = new int[] {0};
       
    }
    //costruttore con un parametro N ( che crea internamente un vettore di N interi)
    public Vettore( int N )
    {
        vettore = new int[N];
    }
    //un metodo bool aggiungi (val)
    // (che aggiunge sempre il valore val e torna true e riesce a inserirlo)
    public bool Aggiungi(int val)
    {
        if(idx >= vettore.Length)
            return false;

            vettore[idx] = val;
            idx++;
            return false;
    }
    // un metodo Somma che torna la soma degli elementi
    public int Somma()
    {
    int retVal = 0;
    for (int idx = 0; idx < vettore.Length; idx++ )
        retVal += vettore[idx];

}
public int Ultimo()
{
if (vettore.Length == 0)
    return 0;


        if (idx == 0)
        
            return vettore[idx];
            return vettore[idx - 1];
        
    }



}