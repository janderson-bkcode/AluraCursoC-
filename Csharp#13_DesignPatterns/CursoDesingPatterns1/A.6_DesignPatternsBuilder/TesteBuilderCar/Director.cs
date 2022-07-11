using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBuilder.TesteBuilderCar
{
    public class Director
    {
        void makeSUV(Builder builder);
        void makeSportsCar(Builder builder)
        {
            builder.reset();
            builder.setSeats(2);
            builder.setEngine(new SportEngine());
            builder.setTripComputer();
            builder.setGPS();
        }
    }
}