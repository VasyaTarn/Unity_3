using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
