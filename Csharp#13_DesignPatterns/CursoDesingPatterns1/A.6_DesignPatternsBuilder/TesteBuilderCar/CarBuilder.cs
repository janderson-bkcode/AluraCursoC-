using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A._6_DesignPatternsBuilder.TesteBuilderCar
{
    public class CarBuilder : Builder
    {
        private Car carro { get; set; }

        public void reset()
        {
            this.carro = new Car();
        }

        public Car getResult()
        {

            return this.carro;
        }

    }
}