using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    /// <summary>
    /// Class searching index of array's element so that sums of elements on the right and left are equals
    /// </summary>
    public class EqualsSumsOfArray
    {
        #region Fields
        /// <summary>
        /// array of int 
        /// </summary>
        private readonly int[] _ints;
        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        public EqualsSumsOfArray(int[] ints)
        {
            this._ints = ints;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Determination of the maximum of a array using recursion
        /// </summary>
        /// <returns>index element of array</returns>
        public int GetIndex()
        {
            var lsum = 0;
            var rsum = 0;
            for (var i = 1; i < _ints.Length; i++)
                rsum += _ints[i];

            for (var i = 1; i < _ints.Length; i++)
            {
                if (lsum == rsum)
                    return i - 1;
                lsum += _ints[i-1];
                rsum -= _ints[i];
            }
            return -1;
        }
        #endregion
    }
}
