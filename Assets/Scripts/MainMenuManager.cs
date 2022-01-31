using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button creditsOpenButton;
    [SerializeField] private Button creditsCloseButton;
    [SerializeField] private GameObject creditsUI;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("GunScene"));
        creditsOpenButton.onClick.AddListener(() => creditsUI.SetActive(true));
        creditsCloseButton.onClick.AddListener(()=> creditsUI.SetActive(false));

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}