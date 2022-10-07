using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTiaraju.Application.Commands.CreateCalendarioCQ
{
    internal class CreateCalendarioCQCommandHandler : IRequestHandler<CreateCalendarioCQCommand, int>
    {
        private readonly ICalendarioCQRepository _calendariocqRepository;

        public CreateCalendarioCQCommandHandler(ICalendarioCQRepository calendariocqRepository)
        {
            _calendariocqRepository = calendariocqRepository;
        }

        public async Task<int> Handle(CreateCalendarioCQCommand request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            var calendario = new CalendarioCQ(request.Mes, request.Dia, request.Titulo, request.Descricao);
            await _calendariocqRepository.AddAsync(calendario);

            //O certo é retornar um Id..Fazer mais tarde.
            return calendario.Dia;
        }
    }
}
