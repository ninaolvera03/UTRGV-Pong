using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public int leftScore, rightScore;
  public TMP_Text scoreText;  // drag in!

  public void Score(bool leftPlayer){
    if(leftPlayer) leftScore++;
    else rightScore++;
    scoreText.text =
      leftScore + " : " + rightScore;
  }
}
