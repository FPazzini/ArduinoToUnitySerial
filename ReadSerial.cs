using System.IO.Ports;
using UnityEngine;
using System.Collections;
using System;

public class ReadSerial : MonoBehaviour {
    SerialPort serialPort;
	// Use this for initialization
	void Start () {
        try {
            serialPort = new SerialPort("COM3", 115200);
            if (!serialPort.IsOpen) {
                serialPort.Open();
            }
            serialPort.ReadTimeout = 1;
        } catch (Exception e) {
            Debug.Log(e.ToString());
        }
	}
	
	// Update is called once per frame
	void Update () {
        try {
            Debug.Log(serialPort.ReadLine());
        } catch (Exception e) {
            Debug.Log(e.ToString());
        }
	}

    IEnumerator openPort() {
        yield return new WaitForSeconds(3);
    }
}
