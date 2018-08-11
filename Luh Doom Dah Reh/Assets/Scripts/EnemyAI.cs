using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    public static int numEnemies = 0;

    public float hp = 100;

    [SerializeField] float hpLowPercent = 25;
    [SerializeField] private float stationDmg = 25;
    [SerializeField] private float flyDmg = 10;
    [SerializeField] private Material hpLowMat;

    private bool hpLowBool = false;

    private void Update() {
        HpCheck();
    }

    private void HpCheck() {
        if (hpLowBool) {
            return;
        }

        if (hp < (hp / hpLowPercent * 100)) {
            Renderer rend = GetComponent<Renderer>();
            if (rend != null) {
                rend.material = hpLowMat;
            }

            hpLowBool = true;
        }
    }
}
