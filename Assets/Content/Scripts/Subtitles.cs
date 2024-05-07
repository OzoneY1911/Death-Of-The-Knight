using UnityEngine;
using TMPro;
using System.Collections;

public class Subtitles : SingletonMono<Subtitles>
{
    [SerializeField] private GameObject _subtitlesTextBck;
    [SerializeField] private GameObject _subtitlesNameObject;
    [SerializeField] private GameObject _subtitlesTextObject;
    [SerializeField] private TextMeshProUGUI _subtitlesText;
    [SerializeField] private TextMeshProUGUI _subtitlesHintText;
    [SerializeField] private string[] _subtitlesLine;

    private int _nextLine;

    private bool _canTravel;

    protected override void Awake()
    {
        base.Awake();

        NextLine();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_canTravel)
        {
            if (_nextLine < _subtitlesLine.Length)
            {
                NextLine();
            }
            else
            {
                _subtitlesNameObject.SetActive(false);
                _subtitlesTextObject.SetActive(false);
                _subtitlesHintText.text = "Press SPACE to agree and travel to town.";
                _canTravel = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _canTravel)
        {
            LevelLoader.Load("MedievalTown");
        }
    }

    private void NextLine()
    {
        _subtitlesText.text = _subtitlesLine[_nextLine];
        _nextLine++;
    }
}