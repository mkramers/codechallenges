using System.Collections.Generic;
using System.Linq;

namespace Challenges.Easy
{
    /// <summary>
    ///     https://www.reddit.com/r/dailyprogrammer/comments/bqy1cf/20190520_challenge_378_easy_the_havelhakimi/
    /// </summary>
    public static class HavelHakimiAlgorithm
    {
        public static bool IsEveryoneTellingTheTruth(IEnumerable<int> _answers)
        {
            while (true)
            {
                int[] zerosRemoved = _answers.Where(_answer => _answer != 0).ToArray();

                if (!zerosRemoved.Any()) return true;

                int[] ordered = zerosRemoved.OrderByDescending(_answer => _answer).ToArray();

                int n = ordered.FirstOrDefault();

                int[] trimmed = ordered.Skip(1).ToArray();

                if (n > trimmed.Length) return false;

                int[] subtracted = trimmed.Take(n).Select(_answer => _answer - 1).Concat(trimmed.Skip(n)).ToArray();

                _answers = subtracted;
            }
        }
    }
}