using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("yooo");
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
