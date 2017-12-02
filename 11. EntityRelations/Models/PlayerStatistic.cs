﻿namespace P03_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }
        public int ScoredGoals { get; set; }

        public Player Player { get; set; }
        public Game Game { get; set; }
    }
}