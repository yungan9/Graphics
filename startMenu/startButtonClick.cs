using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void next()
    {
        SceneManager.LoadScene("outpost with snow");
    }
}
