using UnityEngine;
using System.Collections;

public class SetActiveLayer : MonoBehaviour {

    public GameObject[] layers;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) setActiveLayer(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) setActiveLayer(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) setActiveLayer(2);
        if (Input.GetKeyDown(KeyCode.Alpha4)) setActiveLayer(3);
        if (Input.GetKeyDown(KeyCode.Alpha5)) setActiveLayer(4);
        if (Input.GetKeyDown(KeyCode.Alpha6)) setActiveLayer(5);
    }

    void setActiveLayer(int i) {
        foreach (GameObject obj in layers) {
            obj.SetActive(false);
        }
        layers[i].SetActive(true);
    }
}
