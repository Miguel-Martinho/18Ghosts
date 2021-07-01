using System;

namespace MVC_Conway.Common
{
    /// <summary>
    /// Class that contains the games parameters
    /// </summary>
    public class Parameters
    {
        public short Xdim {get; private set;}
        public short Ydim {get; private set;}
        public float Move_rate_exp {get; private set;}
        public float Rep_rate_exp {get; private set;}
        public float Fight_rate_exp {get; private set;}
        public bool ValidParam {get; private set;}
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
            Xdim = xdimension;
            Ydim = ydimension;
            
            ValidParam = CheckValue(_swap_rate_exp);
            Move_rate_exp = _swap_rate_exp;
            ValidParam = CheckValue(_repr_rate_exp);
            Rep_rate_exp = _repr_rate_exp;
            ValidParam = CheckValue(_selc_rate_exp);
            Fight_rate_exp = _selc_rate_exp;
        }
        private bool CheckValue(float value)
        {
        if (value < -1.0f || value > 1.0f)
            return false;
        return true;
        }
    }
}