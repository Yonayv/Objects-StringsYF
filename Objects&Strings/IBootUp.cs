using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Strings
{
    internal interface IBootUp
    {
        /// <summary>
        /// Interface IBootUp
        /// Boolean propety has automatic getter and setter
        /// The method PowerOnOff is declared
        /// </summary>

        public bool IsOn { get; set; }

        public void PowerOnOff();



    }
}
