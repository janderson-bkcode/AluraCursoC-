using A._6_DesignPatternsBuilder.TesteBuilderCar;



namespace TA._6_DesignPatternsBuilder.TesteBuilderCar
{


    public static void Main(string[] args)
    {
        Director diretor = new Director();
        CarBuilder carBuilder = new CarBuilder();

        diretor.makeSUV(carBuilder);
        Car car = new Car();
        car = carBuilder.getResult();
    }


}