using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    int puzzle_collected = 0;
    [SerializeField] private PuzzlePiece[] _puzzlepieces;
    [SerializeField] private Camera _main_camera;
    void Start()
    {
        foreach(PuzzlePiece puzzle in _puzzlepieces)
        {
            puzzle.Collect += pieceCollected;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _main_camera.enabled = !_main_camera.enabled;
        }
    }

    void pieceCollected(int i)
    {
        puzzle_collected += 1;
        Debug.Log("puzzles:" + puzzle_collected);
    }
}