using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public Animator menuAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void PlayButton()
    {
        menuAnimator.SetTrigger("PlayButtonPressed");
        Time.timeScale = 1;
       // menu.SetActive(false);
        
    }
}
