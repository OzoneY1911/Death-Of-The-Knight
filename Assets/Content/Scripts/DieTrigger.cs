using UnityEngine;

public class DieTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _canvasDie;
    [SerializeField] private GameObject _soundSource;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

        _soundSource.SetActive(false);

        _canvasDie.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canvasDie.SetActive(true);

        Time.timeScale = 0f;

        Cursor.lockState = CursorLockMode.None;

        _soundSource.SetActive(true);
    }
}
