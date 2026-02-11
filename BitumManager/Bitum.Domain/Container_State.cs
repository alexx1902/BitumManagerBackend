using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitum.Domain
{
    public class Container_State
    {
        public int Container_StateID { get; set; }

        public Guid ContainerID { get; set; }

        public double ActualCapacity { get; set; } = 0;

        public int ActualTemperature { get; set; } = 0;

        public bool IsWorking { get; set; } = false;

        public enum ContainerStatus
        { 
            Full,
            Empty,
            PartiallyEmpty,
            Heating
        }
    }
}


// чтобы отслеживать историю изменений, в таблице будет много записей