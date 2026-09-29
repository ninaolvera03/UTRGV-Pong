using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
  public bool isLeftGoal;
  public GameManager game;    // drag in!

  void OnTriggerEnter2D(Collider2D o){
    var b = o.GetComponent<BallController>();
    if(b==null) return;
    game.Score(!isLeftGoal);
    b.ResetBall();
  }
}
