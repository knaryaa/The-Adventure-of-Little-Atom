using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class VideoScript : MonoBehaviour
{
    public VideoPlayer video;
    void Start()
    {
        StartCoroutine(WaitAndLoad());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(1);
        }
    }


    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(35);
        SceneManager.LoadScene(1);
    }
}