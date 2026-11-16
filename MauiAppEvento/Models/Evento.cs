using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;

        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataFim { get; set; } = DateTime.Today.AddDays(1);

        public int NumeroParticipantes { get; set; } = 1;

        public decimal ValorPorParticipante { get; set; } = 50m;

        public TimeSpan Duracao => DataFim.Date - DataInicio.Date;

        public int DuracaoEmDias => Duracao.Days;

        public decimal CustoTotal => NumeroParticipantes * ValorPorParticipante;

        public string DuracaoFormatada =>
            DuracaoEmDias == 1 ? "1 dia" : $"{DuracaoEmDias} dias";

        public string CustoTotalFormatado =>
            CustoTotal.ToString("C2", new CultureInfo("pt-BR"));

        public string ValorPorParticipanteFormatado =>
            ValorPorParticipante.ToString("C2", new CultureInfo("pt-BR"));
    }
}
