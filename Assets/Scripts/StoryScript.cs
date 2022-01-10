using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoryScript : MonoBehaviour
{

    public GameObject firstLabel;
    public GameObject secondLabel;
    public GameObject thirdLabel;
    private bool isThirdLabelVisible = false;

    private void Awake()
    {
        firstLabel.SetActive(false);
        secondLabel.SetActive(false);
        thirdLabel.SetActive(false);
        StartCoroutine(FirstLabelAppear());
    }

    private void Update()
    {
        if(isThirdLabelVisible)
        {
            if(Input.anyKey)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private IEnumerator FirstLabelAppear()
    {
        yield return new WaitForSeconds(0.4f);
        firstLabel.SetActive(true);
        StartCoroutine(SecondLabelAppear());
    }

    private IEnumerator SecondLabelAppear()
    {
        yield return new WaitForSeconds(0.5f);
        secondLabel.SetActive(true);
        StartCoroutine(ThirdLabelAppear());
    }

    private IEnumerator ThirdLabelAppear()
    {
        yield return new WaitForSeconds(0.6f);
        isThirdLabelVisible = true;
        thirdLabel.SetActive(true);
    }



}
