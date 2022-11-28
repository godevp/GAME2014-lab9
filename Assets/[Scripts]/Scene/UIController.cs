using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void OnRestartButton_Pressed()
    {
        SceneManager.LoadScene("Main");
    }
}
