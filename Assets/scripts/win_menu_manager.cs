using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class win_menu_script : MonoBehaviour
{

    public void ExitButtonPressed()
    {
        SceneManager.LoadScene(0);
    }

}