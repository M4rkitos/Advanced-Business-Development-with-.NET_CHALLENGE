using EasyAccess.Application.DTOs;
using EasyAccess.Domain.Entities;
using EasyAccess.Domain.Repositories;

namespace EasyAccess.Application.Services
{
    public class VagaService
    {
        private readonly IVagaRepository _vagaRepository;

        public VagaService(IVagaRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public async Task RealizarReservaVagaAsync(ReservaVagaDto reservaDto)
        {
            if (reservaDto.DataInicio >= reservaDto.DataFim)
            {
                throw new ArgumentException("A data de início deve ser anterior à data de fim.");
            }

            var novaReserva = new VagaReserva
            {
                MoradorId = reservaDto.MoradorId,
                DataInicio = reservaDto.DataInicio,
                DataFim = reservaDto.DataFim,
                PlacaVeiculo = reservaDto.PlacaVeiculo
            };

            await _vagaRepository.AdicionarAsync(novaReserva);
        }
    }
}