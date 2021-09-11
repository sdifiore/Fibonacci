public static class Calculo
{
    public static double[] Ate(int totalElementos)
    {
        if (totalElementos == 1)
            return new double[] { 0 };
        else if (totalElementos == 2)
            return new double[] { 0, 1 };

        double[] FibonacciArray = new double[totalElementos];

        FibonacciArray[0] = 0;
        FibonacciArray[1] = 1;

        for (int i = 2; i < totalElementos; i++)
            FibonacciArray[i] = FibonacciArray[i - 2] + FibonacciArray[i - 1];

        return FibonacciArray;
    }
}