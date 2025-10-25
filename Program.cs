using InventoryApp.Repositories;

using InventoryApp.WinForms;

using InventoryApp.Infrastructure.Repositories;

Application.Run(new ProductsInlineForm(new ProductRepository()));

var clientRepo = new ClientRepository();
var clientesForm = new ClientesForm(clientRepo);
Application.Run(clientesForm);

namespace InventoryApp

{

    internal static class Program

    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            ApplicationConfiguration.Initialize();

            // 🔹 Instanciar repositorios
            var productRepo = new ProductRepository();
            var clientRepo = new ClientRepository();
            var saleRepo = new SaleRepository();


        }

    }

}
