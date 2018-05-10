using System.ComponentModel;

namespace TesteEdeployNet.GabrielFaria.ViewModel
{
    public class ViewCidadeViewModel
    {
        [DisplayName("Cidade")]
        public string Nome { get; set; }
        [DisplayName("Estado")]
        public string Estado { get; set; }

    }
}