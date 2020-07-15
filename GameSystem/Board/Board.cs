using System;
using System.Collections.Generic;

namespace GameSystem.Board
{
  public class Board
  {
    private int _width;
    private int _height;
    private Tile[,] _tiles;

    public Board(int width, int height)
    {
      _width = width;
      _height = height;
      Initialize();
    }

    public Tile GetTile(int x, int y)
    {
      return _tiles[x - 1, y - 1];
    }

    public void AddUnit(Unit unit, int x, int y)
    {
      Tile tile = GetTile(x, y);
      tile.AddUnit(unit);
    }

    public void RemoveUnit(Unit unit, int x, int y)
    {
      Tile tile = GetTile(x, y);
      tile.RemoveUnit(unit);
    }

    public List<Unit> GetUnits(int x, int y)
    {
      return GetTile(x, y).Units;
    }

    private void Initialize()
    {
      _tiles = new Tile[_width, _height];

      for (int i = 0; i < _tiles.GetLength(0); i++)
      {
        for (int j = 0; j < _tiles.GetLength(1); j++)
        {
          _tiles[i, j] = new Tile();
        }
      }
    }
  }
}