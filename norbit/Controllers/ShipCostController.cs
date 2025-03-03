using Microsoft.AspNetCore.Mvc;
using ShipCostCalculator.Models;

namespace ShipCostCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShipCostController : ControllerBase
    {
        [HttpPost("calculate")]
        public ActionResult<ShipCost> CalculateCost([FromBody] ShipDetails details)
        {
            // Базовая стоимость судна
            double baseCost = 1000000;

            // Коэффициент для материала
            double materialFactor = details.Material == "Steel" ? 1.2 : 1.1;

            // Вычисляем объем судна
            double volume = details.Length * details.Width * details.Height;

            // Рассчитываем общую стоимость
            double totalCost = baseCost * materialFactor * (volume / 1000); // Делим на 1000 для удобства

            // Возвращаем результат
            return Ok(new ShipCost { TotalCost = totalCost });
        }
    }
}
