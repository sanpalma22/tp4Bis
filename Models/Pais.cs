namespace tp4Bis.Models;
public class Pais{
    public string Nombre{get;private set;}
    public string imgBandera{get;private set;}
    public int Poblacion{get;private set;}
    public DateOnly FechaHistorica{get;private set;}
    public string AtractivosTuristicos{get;private set;}

    public Pais(string nom, string img, int pob, DateOnly FP, string AT){
        Nombre=nom;
        imgBandera=img;
        Poblacion=pob;
        FechaHistorica=FP;
        AtractivosTuristicos=AT;
    }
}