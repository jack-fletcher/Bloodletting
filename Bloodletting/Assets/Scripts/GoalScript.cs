using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalScript : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Hero")
        {
            if (SceneManager.GetActiveScene().name == "Game level 3")
            {
                SceneManager.LoadScene("Game Info 3");
            }
            if (SceneManager.GetActiveScene().name == "Game level 4")
            {
                SceneManager.LoadScene("Win Credits");
            }
        }
    }
}
