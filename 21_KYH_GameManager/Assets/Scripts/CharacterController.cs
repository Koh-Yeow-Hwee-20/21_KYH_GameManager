using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public float speed;
    public Animator animator;

    public GameObject EnergyCollected;
    private int energyCount;
    private int totalEnergy;

    // Start is called before the first frame update
    void Start()
    {
        totalEnergy = GameObject.FindGameObjectsWithTag("addEnergyPrefab").Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            //startRun();
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            //startRun();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, -90, 0);
            //startRun();
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            //startRun();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("addEnergyPrefab"))
        {
            energyCount += 5;
            EnergyCollected.GetComponent<Text>().text = "Energy Count: " + energyCount;

            Destroy(collision.gameObject);
        }
    }
}
