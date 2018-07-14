using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17ClassWork.Contract
{
    interface IMoving
    {
        /// <summary>
        /// уменьшает количество топлива на случайное значение
        /// </summary>
        void Move();
    }
}
