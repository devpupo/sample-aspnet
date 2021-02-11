using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hurb_sap.Services.Payments;
using hurb_sap.Models;
using hurb_sap.Domain.Services.Payments;

namespace hurb_sap.Controllers
{
    [ApiController]
    [Route("v1/payments")]    
    public class PaymentsController: ControllerBase
    {
        private readonly IPaymentsService _paymentsService;

    public PaymentsController(IPaymentsService paymentsService){
         _paymentsService = paymentsService;
    }
        [HttpPost]
        [Route("")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult<ResponseModel> Post([FromBody]PaymentsModel entity)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            try
            {
                return Created("", _paymentsService.Add(entity));    
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }            
        }

        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<ResponseModel> Get(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            try
            {
                return Ok(_paymentsService.Read(id));    
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }            
        }
    }
}