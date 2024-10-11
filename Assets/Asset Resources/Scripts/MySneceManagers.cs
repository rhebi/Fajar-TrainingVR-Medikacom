using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Perbaikan di sini: 'sceneManagement' -> 'SceneManagement'

public class MySceneManager : MonoBehaviour // Perbaikan nama kelas dari 'MySneceManagers' menjadi 'MySceneManager'
{
    // public string characterString;
    // public int bilanganBulat;
    // public float bilanganPecahan;
    // public bool kondisi;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World"); // Perbaikan di sini: 'Word' -> 'World'
    }

    // Update is called once per frame
    void Update() // Perbaikan: tidak perlu menandai dengan 'public'
    {
        
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // Perbaikan di sini: 'sceneManager' -> 'SceneManager'
    }
}
