namespace hurb_sap.Models
{
    public class ResponseModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public object Objects { get; set; }
    }
}