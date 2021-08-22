using UnityEngine;
using System.Collections.Generic;

public class PlayerTurnProcessors : MonoBehaviour
{
    private PlayerTurnProcessor _populationProcessor;
    private PlayerTurnProcessor _expansionProcessor;
    private PlayerTurnProcessor _warProcessor;

    private Players _players;

    private List<PlayerTurnProcessor> _turnProcessors;

    private void Awake()
    {
        _players = GetComponent<Players>();
        InizializeComponent();
    }

    private void InizializeComponent()
    {
        _turnProcessors = new List<PlayerTurnProcessor>();
        _turnProcessors.Add(new PlayerPopulator());
        _turnProcessors.Add(new PlayerExpansioner());
        _turnProcessors.Add(new PlayerWarProcessor());
    }

    public void ProcessPlayerTurn(Player player)
    {
        for (int i = 0; i < _turnProcessors.Count; i++)
        {
            _turnProcessors[i].ProcessPlayerTurn(player);
        }
    }
}