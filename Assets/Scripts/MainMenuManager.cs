using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public string backgroundSceneName;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(backgroundSceneName, LoadSceneMode.Additive);
        Instantiate(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
