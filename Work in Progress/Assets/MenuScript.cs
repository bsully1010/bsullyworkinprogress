using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject TitleMenu;
    public GameObject PlayMenu;
    public GameObject OptionsMenu;
    public GameObject AudioMenu;

    // Start is called before the first frame update
    void Start()
    {
        TitleMenu.SetActive(true);
        PlayMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        AudioMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            TitleMenu.SetActive(false);
            PlayMenu.SetActive(true);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Options()
    {
        PlayMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Audio()
    {
        OptionsMenu.SetActive(false);
        AudioMenu.SetActive(true);
    }
}
