using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerbtn: MonoBehaviour
{
   public void GotoMainScene(){
        SceneManager.LoadScene("Main");
    }

   public void GotoPyscis_EncyclopediaScene(){
        SceneManager.LoadScene("Pyscis_Encyclopedia");
    }

    public void GotoChem_EncyclopediaScene(){
        SceneManager.LoadScene("Chem_Encyclopedia");
    }
  
   
}
