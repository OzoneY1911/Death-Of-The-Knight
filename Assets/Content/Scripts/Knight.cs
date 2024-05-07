using UnityEngine;

public class Knight : MonoBehaviour
{
    public GameObject Target;
    public GameObject Target2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Target.SetActive(true);
        Target2.SetActive(true);
    }
}