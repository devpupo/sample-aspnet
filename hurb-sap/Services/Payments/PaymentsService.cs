using System;
using hurb_sap.Domain.Services.Payments;
using hurb_sap.Models;

namespace hurb_sap.Services.Payments
{
    public class PaymentsService: IPaymentsService
    {
        public ResponseModel Add(PaymentsModel payment){

            
            //**************************
            // add di-api code here ^-^
            //**************************
            

            var response = new ResponseModel{
                Id = payment.DocEntry,
                Status = "Sucesso",
                Message = "Pagamento cadastrado",
                Objects = payment
            };

            return response;
        }

        public ResponseModel Read(int id){
            
                        
            //**************************
            // add your data source here ^-^
            //**************************

             var rng = new Random();

            var response = new ResponseModel{
                Id = id,
                Status = "Sucesso",
                Message = "Pagamento resgatado",
                Objects = new PaymentsModel(){ DocEntry = id, PayDay = DateTime.Now, DocTotal = rng.Next(1, 10000)}
            };

            return response;
        }
    }
}