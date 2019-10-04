using FormsPractice.Models;

namespace FormsPractice
{
    public interface ICalculatorFacade
    {
        CalculatorNumberForm GettingModel(CalculatorNumberForm dataFromView);
    }
}