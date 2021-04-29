using Microsoft.AspNetCore.Mvc;
using System;
using studing.Models;
using System.Collections.Generic;

namespace studing.Controllers
{
    public class FundoCapitalController : Controller
    {
        [HttpGet("v1/fundoscapital")]
        public IActionResult ListarFundos()
        {
            return Ok(
                new List<FundoCapital> {
                    new FundoCapital {
                        name = "Viagem de f�rias",
                        actualValue = 200,
                        necessaryValue = 5000,
                        rescueDate = new DateTime(2021,04,29)
                    },
                    new FundoCapital {
                        name = "Reserva de emerg�ncia",
                        actualValue = 1100,
                        necessaryValue = 10000,
                    }
                }
              );
        }

        [HttpPost("v1/fundoscapital")]
        public IActionResult AdicionarFundo([FromBody] FundoCapital fundo)
        {
            return Ok();
        }

        [HttpPut("v1/fundoscapital/{id}")]
        public IActionResult AdicionarFundo(Guid id, [FromBody] FundoCapital fundo)
        {
            return Ok();
        }

        [HttpPut("v1/fundoscapital/{id}")]
        public IActionResult ObeterFundo(Guid id)
        {
            return Ok(
                new FundoCapital
                {
                    name = "Viagem de f�rias",
                    actualValue = 200,
                    necessaryValue = 5000,
                    rescueDate = new DateTime(2021, 04, 29)
                }
                );
        }

        [HttpGet("v1/fundoscapital/{id}")]
        public IActionResult RemoverFundo(Guid id)
        {
            return Ok();
        }
    }
}