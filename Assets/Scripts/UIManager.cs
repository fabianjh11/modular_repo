using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    // Start is called before the first frame update
    public GameObject loginUI;
    public GameObject registerUI;
<<<<<<< Updated upstream
=======
    void Start()
    {
        
    }
>>>>>>> Stashed changes

    public void LoginScreen()
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }

    public void RegisterScreen()
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }
}
