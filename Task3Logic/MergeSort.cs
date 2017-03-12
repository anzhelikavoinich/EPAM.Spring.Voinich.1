using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    /// <summary>
    /// Class sorting elements array by mergesort
    /// </summary>
    public class MergeSort
    {
        #region Fields 
        /// <summary>
        /// array to sort 
        /// </summary>
        private readonly int[] _arr;
        
        #endregion

        #region Constructor
        public MergeSort(int[] arrInts)
        {
            _arr = arrInts;
        }
        #endregion

        #region Public Methods
        public void Sort(int l, int r)
        {
            if (_arr==null || l == r) return;
            var middle = (l + r) / 2;
            Sort(l, middle);
            Sort(middle + 1, r);
            Merge(l, middle, r);
        }
        public void Merge(int l, int middle, int r)
        {
            var buffer = new int[_arr.Length + 1];
            var i = l;
            var j = middle + 1;
            var k = 1;

            while (i <= middle && j <= r)
            {
                if (_arr[i] < _arr[j])
                    buffer[k++] = _arr[i++];
                else
                    buffer[k++] = _arr[j++];
            }

            while (i <= middle)
                buffer[k++] = _arr[i++];

            while (j <= r)
                buffer[k++] = _arr[j++];

            k = 0;
            for (i = l; i <= r; i++)
                _arr[i] = buffer[++k];
        }
        #endregion


    }
}
