using System;
using System.IO;

class SessionTracker
{
    private int _totalSessions = 0;
    private string _fileName = "sessions.txt";

    public void Load()
    {
        if (File.Exists(_fileName))
        {
            string text = File.ReadAllText(_fileName);
            _totalSessions = int.Parse(text);
        }
    }

    public void Save()
    {
        File.WriteAllText(_fileName, _totalSessions.ToString());
    }

    public void AddSession()
    {
        _totalSessions++;
    }

    public int GetTotalSessions()
    {
        return _totalSessions;
    }
}