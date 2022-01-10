using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Soul currentSoul;
    [SerializeField] public List<Soul> soulsQueue;
    private int initialRandomizedIndex;
    public GameObject nameText;
    public GameObject ageText;
    public GameObject genderText;
    public GameObject storyText;
    public GameObject soulFace;
    public GameObject alignmentText;
    public GameObject causeOfDeathText;
    public AlignmentController alignmentController;
    public int alignment;
    public Timer timer;
    public GameObject tutorialScreen;
    

    public Soul CurrentSoul { get => currentSoul;
        set
        {
            currentSoul = value;
            nameText.GetComponent<TextMeshProUGUI>().text = "Name: " + currentSoul.Name;
            ageText.GetComponent<TextMeshProUGUI>().text = "Age: " + currentSoul.Age;
            genderText.GetComponent<TextMeshProUGUI>().text = "Gender: " + currentSoul.Gender;
            storyText.GetComponent<TextMeshProUGUI>().text = currentSoul.Story;
            causeOfDeathText.GetComponent<TextMeshProUGUI>().text = "Cause of death: " + currentSoul.CauseOfDeath;
            soulFace.GetComponent<Image>().sprite = currentSoul.Face;
            timer.StartTimer();
        }

    }

    

    public int Alignment
    {
        get => alignment;
        set
        {
            alignment = value;
            alignmentText.GetComponent<TextMeshProUGUI>().text = "Alignment: " + alignment;
            alignmentController.setCurrentValue(alignment);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        timer.InitializeTimer();
        Random.InitState(System.DateTime.Now.Second);
        initialRandomizedIndex = Random.Range(0, soulsQueue.Count);
        CurrentSoul = soulsQueue[initialRandomizedIndex];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (soulsQueue.Count == 0)
            if (alignment >= 40)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            else if (alignment <= -30)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            else 
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    private void Awake()
    {
        tutorialScreen.SetActive(true);
    }

    public void removeCurretSoulFromQueue()
    {
        soulsQueue.Remove(currentSoul);
    }

    public void changeCurrentSoul()
    {
        CurrentSoul = getRandomSoulFromCollection();
    }

    public Soul getRandomSoulFromCollection()
    {
        int temporaryIndex = Random.Range(0, soulsQueue.Count);
        return soulsQueue[temporaryIndex];
    }

    public void ResetTimer()
    {
        timer.ResetTimer();
    }

}
