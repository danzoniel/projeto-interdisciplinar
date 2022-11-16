using System;

namespace projeto_rfid.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestid => !string.IsNullOrEmpty(RequestId);
    }
}
