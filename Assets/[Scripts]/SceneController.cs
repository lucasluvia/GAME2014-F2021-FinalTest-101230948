// SceneController.cs
// Lucas Dunster 101230948
// DLM: Same From Template
// Loads Platform Scene for button response

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{


    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
