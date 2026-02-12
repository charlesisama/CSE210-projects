using System;

// =============================================================
// EXCEEDING REQUIREMENTS:
// 1) Added a simple Level system (every 1000 points = new level).
// 2) Added celebration message when earning points.
// =============================================================

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
