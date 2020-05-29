using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    static int numberCubeLeft;
    private Text numberCubeLeftText;
    private bool asTouchTheGround = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ground" && !asTouchTheGround)
        {
            asTouchTheGround = true;
            numberCubeLeft--;
            numberCubeLeftText.text = "" + numberCubeLeft;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        numberCubeLeftText = GameObject.Find("NumberCubeLeft").GetComponent<Text>();
        numberCubeLeft++;
    }

    // Update is called once per frame
    void Update()
    {
        if(numberCubeLeft == 0)
        {
            GameObject.Find("Victory").GetComponent<Text>().enabled = true;
            Time.timeScale = 0;
        }
    }
}
