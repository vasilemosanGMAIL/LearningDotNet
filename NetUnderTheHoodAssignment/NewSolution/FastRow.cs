﻿namespace CsvDataAccess.NewSolution;

public class FastRow
{
    private Dictionary<string, string> _stringsData = new();
    private Dictionary<string, int> _intsData = new();
    private Dictionary<string, bool> _boolData = new();
    private Dictionary<string, decimal> _decimalsData = new();

    public void AssignCell(string columnName, bool value)
    {
        _boolData[columnName] = value;
    }
    public void AssignCell(string columnName, decimal value)
    {
        _decimalsData[columnName] = value;
    }
    public void AssignCell(string columnName, string value)
    {
        _stringsData[columnName] = value;
    }
    public void AssignCell(string columnName, int value)
    {
        _intsData[columnName] = value;
    }

    public object GetAtColumn(string columnName)
    {
        if (_boolData.ContainsKey(columnName))
            return _boolData[columnName];

        if (_decimalsData.ContainsKey(columnName))
            return _decimalsData[columnName];

        if (_stringsData.ContainsKey(columnName))
            return _stringsData[columnName];

        if (_intsData.ContainsKey(columnName))
            return _intsData[columnName];

        return null;
    }
}
