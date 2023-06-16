
using UnityEngine;
using UnityEngine.SceneManagement;

public class game3 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "game3")
        {

            Debug.Log("go");
            SceneManager.LoadScene("Sliding Puzzle");
        }
    }
}

