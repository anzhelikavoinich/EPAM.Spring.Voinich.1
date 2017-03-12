using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Class searching maximum element of array
    /// </summary>
    public class MaximumElementOfArray
    {
        #region Fields
        /// <summary>
        /// array of doubles 
        /// </summary>
        private readonly double[] _arrDoubles;
        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        public MaximumElementOfArray(double[] arrDoubles)
        {
            this._arrDoubles = arrDoubles;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Method telling us if the index is center of the array
        /// </summary>
        /// <returns>boolean value</returns>
        private static bool IsCenter(int left, int right)
        {
            return !((left + right) % 2 > 0);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Determination of the maximum of a array using recursion
        /// </summary>
        /// <returns>maximum element of array</returns>
        public double GetMaximum(int left,int right)
        {
            if(_arrDoubles == null || _arrDoubles.Length == 0)
                return default(double);
            if (left == right)
                return _arrDoubles[left];
            var median = (left + right) / 2;
            var x = IsCenter(left, median) ? GetMaximum(left, median) : GetMaximum(left, median - 1);
            var y = IsCenter(median, right) ? GetMaximum(median, right) : GetMaximum(median + 1, right);
            return (x > y) ? x : y;
        }
        #endregion

    }
}
