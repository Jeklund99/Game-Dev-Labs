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
    [SerializeField] private Button notQuitePlatformerButton;
    [SerializeField] private Button threeDSpawnButton;
    [SerializeField] private Button pongButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("GunScene"));
        creditsOpenButton.onClick.AddListener(() => creditsUI.SetActive(true));
        creditsCloseButton.onClick.AddListener(()=> creditsUI.SetActive(false));
        notQuitePlatformerButton.onClick.AddListener(() => LoadingScreen.LoadScene("NotQuitePlatformer"));
        threeDSpawnButton.onClick.AddListener(()=> LoadingScreen.LoadScene("3DSpawn"));
        pongButton.onClick.AddListener(() => LoadingScreen.LoadScene("Pong"));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
