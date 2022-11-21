using System;

namespace projeto_rfid.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel() { }
        public ErrorViewModel(string erro)
        {
            this.Erro = erro;
        }
        public string Erro { get; set; }
        public string RequestId { get; set; }
        public bool ShowRequestid => !string.IsNullOrEmpty(RequestId);
    }
}
