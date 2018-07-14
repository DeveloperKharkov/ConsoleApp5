using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17ClassWork.Contract
{
    interface IFuel
    {
        /// <summary>
        /// тип топлива (дизель, бензин, газ)
        /// </summary>
        FuelType Type { get; }

        /// <summary>
        /// объем бака
        /// </summary>
        int TankVolume { get; }

        /// <summary>
        /// текущее количество топлива
        /// </summary>
        int TankState { get; }

        /// <summary>
        /// позволяет добавить в бак топлива
        /// </summary>
        /// <param name="newFuel"></param>
        void FillTank(int newFuel);
    }
}
