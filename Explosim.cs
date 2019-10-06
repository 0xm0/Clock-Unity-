using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Explosim : MonoBehaviour
{

    private void Awake()
    {
        string server = "localhost";
        string database = "connectcsharptomysql";
        string uid = "username";
        string password = "password";
        string connectionString;

        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


    }
    void Start()
    {
        foreach (Transform child in transform)
        {
            Rigidbody rb = child.gameObject.AddComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
