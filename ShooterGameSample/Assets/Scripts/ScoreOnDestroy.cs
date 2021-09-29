using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    /****VARIABLES****/
    public int ScoreValue = 50;

    public void onDestroy()
    {
        GameManager.Score += ScoreValue;
    }
}
