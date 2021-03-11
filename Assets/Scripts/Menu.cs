using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Atomes()
    {
        SceneManager.LoadScene("ScanAtomeindiv");
    }
    public void Molecule()
    {
        SceneManager.LoadScene("CompositionAtome");
    }
    public void Exercice()
    {
        SceneManager.LoadScene("EquilibreMoleculeExercice");
    }
    public void Aide()
    {
        SceneManager.LoadScene("Aide Tuto");
    }
}
