using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Logic
{
    /// <summary>
    /// Class concatenating two strings into one sorted string
    /// </summary>
    public class StringConcatenation
    {
        #region Fields
        /// <summary>
        /// array to sort 
        /// </summary>
        private readonly string _str1;

        /// <summary>
        /// default variable of capacity of array
        /// </summary>
        private readonly string _str2;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor 
        /// </summary>
        public StringConcatenation(string str1, string str2)
        {
            this._str1 = str1;
            this._str2 = str2;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Concatenate strings into one sorted string
        /// </summary>
        /// <returns>sorted string</returns>
        public string Concatenation()
        {
            if(_str1 == null || _str2 == null)
                return null;
            var str = _str1.Distinct().Union(_str2).ToArray();
            Array.Sort(str);
            return new string(str);
        }
        #endregion
    }
}
