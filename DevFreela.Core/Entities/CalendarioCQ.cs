using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class CalendarioCQ
    {
        public CalendarioCQ(string mes, int dia, string titulo, string descricao)
        {
            Mes = mes;
            Dia = dia;
            Titulo = titulo;
            Descricao = descricao;

            IsFinished = false;
            IsExcluded = false;
            MotivoExclusao = " ";
        }

        public string Mes { get; private set; }
        public int Dia { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public bool IsFinished { get; private set; }
        public bool IsExcluded { get; private set; }
        public string FinalizadoPor { get; private set; }
        public string MotivoExclusao { get; private set; }
        public DateTime DataFinalizacao { get; private set; }
    }
}
