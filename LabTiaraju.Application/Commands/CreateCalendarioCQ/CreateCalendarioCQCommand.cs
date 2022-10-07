using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTiaraju.Application.Commands.CreateCalendarioCQ
{
    public class CreateCalendarioCQCommand : IRequest<int>
    {
        public string Mes { get; set; }
        public int Dia { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }


    }
}
