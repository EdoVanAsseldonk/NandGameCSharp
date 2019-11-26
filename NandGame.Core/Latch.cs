namespace NandGame.Core
{
    /// <summary>
    /// A latch component stores and outputs a single bit.
    /// </summary>
    public class Latch
    {
        private bool state;

        /// <summary>
        /// A latch component stores and outputs a single bit.
        /// When st(store) is 1, the value on d is stored and emitted.
        /// When st is 0, the value of d is ignored, and the previously stored value is still emitted.
        /// </summary>
        /// <param name="st">Store: yes/no</param>
        /// <param name="d">Data</param>
        /// <returns>The previously stored value</returns>
        public bool Do(bool st, bool d)
        {
            state = Select.Do(st, d, state);
            
            return state;
        }
    }
}