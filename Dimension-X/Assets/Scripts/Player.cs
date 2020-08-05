using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float PlayerSpeed = 10f;
    [SerializeField] Camera GameCamera;
    [SerializeField] TrackHandler Tracks;
    private void Update()
    {
        NewMethod();
    }

    private void NewMethod()
    {
        if (Input.GetButton("MoveLeft"))
        {

            gameObject.transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
        }
        else if (Input.GetButton("MoveRight"))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.tag);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Boundary")
        {
            StopGame();
        }
        if (other.transform.tag == "Obtacle")
        {
            StopGame();
        }
    }

    private void StopGame()
    {
        //gameObject.SetActive(false);
        GameCamera.transform.parent = null;
        Tracks.enabled = false;
        StartCoroutine(LoadGameOver());
    }

    IEnumerator LoadGameOver()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("Hello");
        SceneManager.LoadScene("GameOver");
    }
}
