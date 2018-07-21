using Module19ClassWork.Contract;
using Module19ClassWork.Contract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Module19ClassWork
{
    class MilitaryBase
    {
        private List<MilitaryUnit> _units;

        private void Alarm()
        {
            var myplayer = new WindowsMediaPlayer();
            myplayer.URL = @"e:\Air-raid-siren.mp3";
            myplayer.controls.play();
        }

        public void GoToAttack()
        {
            Alarm();

            foreach (MilitaryUnit item in _units)
            {
                item.Attack();
            }
        }

        public void AirAttack()
        {
            Alarm();

            foreach (MilitaryUnit item in _units)
            {
                if (item is IAirDefender)
                {
                    ((IAirDefender)item).Defend();
                    continue;
                }
                
                if (item is IDefender)
                {
                    ((IDefender)item).Hide();
                }
            }
        }

        public void GroundAttack()
        {
            Alarm();

            foreach (MilitaryUnit item in _units)
            {
                if (item is IGroundDefender)
                {
                    ((IGroundDefender)item).Defend();
                    continue;
                }

                if (item is IDefender)
                {
                    ((IDefender)item).Hide();
                }
            }
        }

        public MilitaryBase(List<MilitaryUnit> units)
        {
            _units = units ?? throw new ArgumentNullException(nameof(units));
        }
    }
}
