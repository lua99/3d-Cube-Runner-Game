using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject obsticle;
    public Transform spawnPoint;

    int score = 0;
    public Text scoreText;
    public GameObject playButton;
    public GameObject Player;


    private void Start()
    {
        
    }

    private void Update()
    {
        
    }


    IEnumerator SpawnObsticle()
    {

        while (true)
        {
            float waitTime = Random.Range(0.7f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(obsticle, spawnPoint.position, Quaternion.identity);
        }


    }

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
   



    public void GameStart()
    {
        Player.SetActive(true);
        playButton.SetActive(false);

        InvokeRepeating("ScoreUp", 2f, 1f);
        StartCoroutine(SpawnObsticle());
        
    }



}
