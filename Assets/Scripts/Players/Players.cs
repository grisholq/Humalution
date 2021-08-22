using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class Players : MonoBehaviour
{
    [SerializeField] private StatsListUI _statsListUI;

    [SerializeField] private UnityEvent<Player> TurnEnded;

    private List<Player> _players;
   
    private Player _currentPlayer;
    private int _playerIndex;

    public List<Player> List => _players;

    private void Awake()
    {
        Inizialize();
    }

    private void Inizialize()
    {
        InizializePlayers();
        SetFirstPlayer();
    }

    private void InizializePlayers()
    {
        _players = new List<Player>(GetComponentsInChildren<Player>());
    }

    private void SetFirstPlayer()
    {
        _playerIndex = 0;
        _currentPlayer = _players[0];
    }

    public void SetUIStats()
    {
        _statsListUI.ShowUIStats(_currentPlayer.Stats.Stats.Stats);
    }

    public void EndCurrentPlayerTurn()
    {
        TurnEnded.Invoke(_currentPlayer);
        MoveToNextPlayer();
    }

    public void MoveToNextPlayer()
    {
        IncrementPlayerIndex();
        SetCurrentPlayerByIndex();
    }

    private void IncrementPlayerIndex()
    {
        _playerIndex++;

        if (_playerIndex >= _players.Count)
        {
            _playerIndex = 0;
            return;
        }
    }

    private void SetCurrentPlayerByIndex()
    {
        _currentPlayer = _players[_playerIndex];
    }
}