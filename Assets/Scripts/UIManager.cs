using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    public TMP_Text introText;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;
    Scene currentScene;

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                introText.text = "Welcome to Learning ROCKS!\n\n" +
                    "Learn about rocks and minerals by becoming a mining master!";
                introImage.SetActive(true);
                backButton.SetActive(false);
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }

    public void IntroSequenceBack()
    {
        introSequence = introSequence - 2;
        IntroSequenceNext();
    }

    public void IntroSequenceNext()
    {
        introSequence++;
        switch (introSequence)
        {
            case 0:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
                introText.text = "Welcome to Learning ROCKS!\n\n" +
                    "Learn about rocks and minerals by becoming a mining master!";
                introImage.SetActive(true);
                backButton.SetActive(false);
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "OVERVIEW";
                break;
            case 2:
                introText.text = "PROPOSED EDTECH SOLUTION";
                break;
            case 3:
                introText.text = "COMPETING SOFTWARE REVIEW";
                break;
            case 4:
                introText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS";
                break;
            case 5:
                introText.text = "STAKEHOLDERS";
                break;
            case 6:
                introText.text = "PERSONA";
                break;
            case 7:
                introText.text = "PERSONA JUSTIFICATION";
                break;
            case 8:
                introText.text = "PROBLEM SCENARIO";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO";
                break;
            case 10:
                nextButton.SetActive(true);
                introText.text = "ACTIVITY SCENARIO CONTINUED";
                break;
            case 11:
                nextButton.SetActive(false);
                introText.text = "PROBLEM STATEMENT";
                break;
        }
    }
}
