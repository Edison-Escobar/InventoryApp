namespace InventoryApp.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public DateTime CreadoEn { get; set; }
    }
}
