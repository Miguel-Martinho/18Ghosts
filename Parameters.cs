using System;

namespace Common
{
    /// <summary>
    /// Class that contains the games parameters
    /// </summary>
    public class Parameters
    {
        public short xdim {get; private set;}
        public short ydim {get; private set;}
        public float swap_rate_exp {get; private set;}
        public float repr_rate_exp {get; private set;}
        public float selc_rate_exp {get; private set;}
        /// <summary>
        /// Constructor for Parameters class
        /// </summary>
        /// <param name="xdimension">board size on the X axis</param>
        /// <param name="ydimension">board size on the Y axis</param>
        /// <param name="_swap_rate_exp">
        /// number between -1.0 e 1.0, that represents frequency of Movement
        /// event</param>
        /// <param name="_repr_rate_exp">
        /// number between -1.0 e 1.0, that represents frequency of Reproduction
        /// event</param>
        /// <param name="_selc_rate_exp">
        /// number between -1.0 e 1.0, that represents frequency of Fight
        /// event</param>
        public Parameters(short xdimension, short ydimension, 
                float _swap_rate_exp,
                float _repr_rate_exp,
                float _selc_rate_exp)
        {
            xdim = xdimension;
            ydim = ydimension;
            swap_rate_exp = _swap_rate_exp;
            repr_rate_exp = _repr_rate_exp;
            selc_rate_exp = _selc_rate_exp;
        }
    }
}