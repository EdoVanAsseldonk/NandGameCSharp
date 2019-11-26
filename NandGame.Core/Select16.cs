namespace NandGame.Core
{
    public static class Select16
    {
        /// <summary>
        /// Is this the best implementation?
        /// </summary>
        /// <param name="s"></param>
        /// <param name="d1"></param>
        /// <param name="d0"></param>
        /// <returns></returns>
        public static Byte2 Do(bool s, Byte2 d1, Byte2 d0)
        {
            var selectedByte2 = new Byte2(Select.Do(s, d1.Fifteen, d0.Fifteen),
                                          Select.Do(s, d1.Fourteen, d0.Fourteen),
                                          Select.Do(s, d1.Thirteen, d0.Thirteen),
                                          Select.Do(s, d1.Twelve, d0.Twelve),
                                          Select.Do(s, d1.Eleven, d0.Eleven),
                                          Select.Do(s, d1.Ten, d0.Ten),
                                          Select.Do(s, d1.Nine, d0.Nine),
                                          Select.Do(s, d1.Eight, d0.Eight),
                                          Select.Do(s, d1.Seven, d0.Seven),
                                          Select.Do(s, d1.Six, d0.Six),
                                          Select.Do(s, d1.Five, d0.Five),
                                          Select.Do(s, d1.Four, d0.Four),
                                          Select.Do(s, d1.Three, d0.Three),
                                          Select.Do(s, d1.Two, d0.Two),
                                          Select.Do(s, d1.One, d0.One),
                                          Select.Do(s, d1.Zero, d0.Zero));

            return selectedByte2;
        }
    }
}
