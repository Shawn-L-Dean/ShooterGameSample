/*
 * Created By: Shawn Dean
 * Date Created: September 29, 2021
 * 
 * Last Edited By: 
 * Last Updated: September 29, 2021
 * 
 * Description: Manages global game behaviors. 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    /****VARIABLES****/
    #region GameManager Singleton
    static GameManager gm;

    public static GameManager GM { get { return gm; } }

    void CheckGameManagerIsInScene()
    {
        if(gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }//end CheckGameManagerIsInScene()
    #endregion

    public static int Score;
    public string ScorePrefix = string.Empty;
    public TMP_Text ScoreText = null;
    public TMP_Text GameOverText = null;

    private void Awake()
    {
        CheckGameManagerIsInScene();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreText != null)
        {
            ScoreText.text = ScorePrefix + Score.ToString();
        }
    }

    public static void GameOver()
    {
        if(gm.GameOverText != null)
        {
            gm.GameOverText.gameObject.SetActive(true);
        }
    }
}
