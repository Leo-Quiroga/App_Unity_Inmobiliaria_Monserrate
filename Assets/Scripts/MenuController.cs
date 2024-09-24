using System;
using UnityEngine;
using UnityEngine.SceneManagement; // Para cargar escenas

public class MenuController : MonoBehaviour
{
    public void GoToSearchProperties()
    {
        SceneManager.LoadScene("SearchPropertiesScene"); // Nombre de la escena de búsqueda
    }

    public void GoToFavorites()
    {
        SceneManager.LoadScene("FavoritesScene"); // Nombre de la escena de favoritos
    }

    public void GoToAccount()
    {
        SceneManager.LoadScene("AccountScene"); // Nombre de la escena de cuenta
    }

     public void GoToPrincipal()
    {
        SceneManager.LoadScene("VistaPrincipal"); // Nombre de la escena de cuenta
        Debug.Log("Cambio de escena");
    }
}
