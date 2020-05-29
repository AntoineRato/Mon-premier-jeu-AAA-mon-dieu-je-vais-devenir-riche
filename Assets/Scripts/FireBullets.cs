using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int shootForce = 2000;
    public Text numberOfShootText;
    private int numberOfShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            numberOfShoot++;
            numberOfShootText.text = "" + numberOfShoot;
        }
    }

    private void Shoot()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
        bulletObject.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
    }
}
