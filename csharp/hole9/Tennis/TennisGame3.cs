namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _score2;
        private int _score1;
        private readonly string _name1;
        private readonly string _name2;

        public TennisGame3(string player1Name, string player2Name)
        {
            _name1 = player1Name;
            _name2 = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _score1 += 1;
            else
                _score2 += 1;
        }

        public string GetScore()
        {
            if (IsTie()) return ScoreAsString(_score1) + "-All";
            if (IsDeuce()) return "Deuce";
            if (IsAdvantage()) return "Advantage " + LeadPlayerName();
            if (IsWin()) return "Win for " + LeadPlayerName();
            
            return ScoreAsString(_score1) + "-" + ScoreAsString(_score2);
        }

        private bool IsWin()
        {
            return _score1 >= 4 || _score2 >= 4 || _score1 + _score2 >= 6 || _score1 == _score2;
        }

        private bool IsAdvantage()
        {
            return (_score1 - _score2) * (_score1 - _score2) == 1 && (_score1 >= 4 || _score2 >= 4);
        }

        private bool IsDeuce()
        {
            return _score1 == _score2 && _score1 + _score2 >= 6;
        }

        private bool IsTie()
        {
            return _score1 < 4 && _score2 < 4 && _score1 + _score2 < 6 && _score1 == _score2;
        }

        private string LeadPlayerName()
        {
            return _score1 > _score2 ? _name1 : _name2;
        }

        private string ScoreAsString(int score)
        {
            return new[] { "Love", "Fifteen", "Thirty", "Forty" }[score];
        }
    }
}