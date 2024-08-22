using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Erik Thompson
public class PlayerRespawner : MonoBehaviour
{
    private Vector3 start;
    [SerializeField] public GameObject currentPlayer;
    // Start is called before the first frame update
    void Start()
    {

        this.start = currentPlayer.transform.position;
        Debug.Log(start);
    }

    public void Respawn()
    {
        Debug.Log("Reseting");
        StartCoroutine(wait2());
    }

    public void resetPosition()
    {
        currentPlayer.transform.SetPositionAndRotation(start, currentPlayer.transform.rotation);
    }

    //Coroutine wait 2 seconds and resetPosition
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(2);
        resetPosition();

    }

    private void Update()
    {
        if (this.currentPlayer.transform.position.x < -25 || this.currentPlayer.transform.position.x > 25 ||
            this.currentPlayer.transform.position.z < -25 || this.currentPlayer.transform.position.z > 25)
        {
            resetPosition();
        }
    }
}