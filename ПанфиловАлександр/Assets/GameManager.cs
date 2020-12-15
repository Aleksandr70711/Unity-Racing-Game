using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour

{    public Text score;
     public void Endgame()
    {
      Debug.Log("GAME OVER");
      score.text = "GAME OVER";
    }

 
}
