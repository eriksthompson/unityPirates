using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//Erik Thompson
public class CannonFire : MonoBehaviour
{
    [SerializeField] GameObject cannon;
    [SerializeField] GameObject boat;
    [SerializeField] GameObject target1;
    [SerializeField] GameObject target2;
    [SerializeField] GameObject target3;
    [SerializeField] public TextMeshProUGUI scoreText;

    static int score;
    void start()
    {
        score = 0;
    }
    public void Fire()
    {
        var ray1 = new Ray(cannon.transform.position, boat.transform.rotation * Quaternion.identity * Vector3.forward);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray1, out hitInfo, 75))
        {
            Debug.Log(hitInfo);
            if(hitInfo.transform.tag == "Target")
            {
                Debug.Log("Hit target");
                if(hitInfo.transform == target1.transform)
                {
                    updateScore();
                    target1.transform.SetPositionAndRotation(new Vector3(Random.Range(-25, 25), 1.77f, Random.Range(-25, 25)), Quaternion.identity);
                    
                }
                if (hitInfo.transform == target2.transform)
                {
                    updateScore();
                    target2.transform.SetPositionAndRotation(new Vector3(Random.Range(-25, 25), 1.77f, Random.Range(-25, 25)), Quaternion.identity);
                }
                if (hitInfo.transform == target3.transform)
                {
                    target3.transform.SetPositionAndRotation(new Vector3(Random.Range(-25, 25), 1.77f, Random.Range(-25, 25)), Quaternion.identity);
                    updateScore();
                }
            }
        }
    }
    public void updateScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
