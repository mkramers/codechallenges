namespace Challenges.Easy
{
    /// <summary>
    /// https://www.reddit.com/r/dailyprogrammer/comments/bazy5j/20190408_challenge_377_easy_axisaligned_crate/
    /// </summary>
    public static class CrateBoxFitting
    {
        public static int HowManyBoxesFit(int _crateX, int _crateY, int _boxX, int _boxY)
        {
            if (_boxX > _crateX || _boxY > _crateY)
            {
                return 0;
            }

            int horizontalBoxes = _crateX / _boxX;
            int verticalBoxes = _crateY / _boxY;

            return horizontalBoxes * verticalBoxes;
        }
    }
}