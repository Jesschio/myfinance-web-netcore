using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_netcore.Models
{
    public class RelatorioTransacaoModel
    {
        public DateTime Data {get; set; }
        public string? Tipo { get; set; }
    }
}