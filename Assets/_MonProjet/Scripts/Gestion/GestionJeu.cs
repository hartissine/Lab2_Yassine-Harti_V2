using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    private int _pointage = 0;  
    private int _accrochageNiveau1 = 0;  
    private float _tempsNiveau1 = 0.0f;      
    private int _accrochageNiveau2 = 0;  
    private float _tempsNiveau2 = 0.0f;      
    private int _accrochageNiveau3 = 0;  
    private float _tempsNiveau3 = 0.0f;  

    
    private void Awake()
    {
       
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        InstructionsDepart(); 
    }

  
    private static void InstructionsDepart()
    {
        Debug.Log("*** Course à obstacles");
        Debug.Log("Le but du jeu est d'atteindre la zone d'arrivée le plus rapidement possible");
        Debug.Log("Chaque contact avec un obstable entraînera une pénalité dans le temps de la partie");
        Debug.Log("");
    }

    
    public void AugmenterPointage()
    {
        _pointage++;
    }

   
    public int GetPointage()
    {
        return _pointage;
    }

   
    public float GetTempsNiv1()
    {
        return _tempsNiveau1;
    }

  
    public int GetAccrochagesNiv1()
    {
        return _accrochageNiveau1;
    }

    public float GetTempsNiv2()
    {
        return _tempsNiveau2;
    }


    public int GetAccrochagesNiv2()
    {
        return _accrochageNiveau2;
    }

    public float GetTempsNiv3()
    {
        return _tempsNiveau3;
    }


    public int GetAccrochagesNiv3()
    {
        return _accrochageNiveau3;
    }

    public void SetNiveau1(int accrochages, float tempsNiv1)
    {
        _accrochageNiveau1 = accrochages;
        _tempsNiveau1 = tempsNiv1;
    }

    public void SetNiveau2(int accrochages, float tempsNiv2)
    {
        _accrochageNiveau2 = accrochages;
        _tempsNiveau2 = tempsNiv2;
    }

    public void SetNiveau3(int accrochages, float tempsNiv3)
    {
        _accrochageNiveau3 = accrochages;
        _tempsNiveau3 = tempsNiv3;
    }
}
