using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBuilder.TesteBuilderCar
{
    public interface Builder
    {
        void reset();
        void setSeats(int number);

        void setEngine(string engine);

        void setTripComputer();

        void setGPS();
    }
}