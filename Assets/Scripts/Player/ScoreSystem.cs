using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private int _score;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit") {
            _score++;
            Debug.Log("Score: " + _score);
        }
    }
}
