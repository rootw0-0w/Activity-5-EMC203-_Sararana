using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHits = 5;
    int hits = 0;

    public void TakeHit()
    {
        hits++;

        if (hits >= maxHits)//restart at 5 hits
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}