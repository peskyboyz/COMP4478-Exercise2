using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{
    public int score;
    public bool GameOver;
    public Transform title;
    public TextMeshProUGUI Scoreboard;
    public Generator generator;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameOver = false;
        Scoreboard.text = "0";
        generator = GameObject.Find("Scripts").GetComponent<Generator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == true)
        {
            title.localPosition = new Vector3(0f, 0f, 0f);
            generator.generate = false;
            GameOver = false;
        }
    }
    public void ScoreAdd()
    {
        score++;
        Scoreboard.SetText(score.ToString());
    }
    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
}
