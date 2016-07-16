using UnityEngine;
using System.Collections;

public class Player {
    private int hp = 100;
    private int power = 50;

    public void Attack() {
        Debug.Log("Gave" + this.power + "damage");
    }

    public void Damage(int damage) {
        this.hp -= damage;
        Debug.Log("Took" + damage + "damage");
    }
}

public class LearningClass : MonoBehaviour {

    void Start () {
        Player myPlyer = new Player();
        myPlyer.Attack();
        myPlyer.Damage(30);
    }
}
