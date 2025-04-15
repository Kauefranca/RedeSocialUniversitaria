using DDDCommerceComRepository.Domain.RedeSocial.Entidades;
using DDDCommerceComRepository.Domain.RedeSocial.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceComRepository.Domain.RedeSocial.DomainServices
{
    public class EventoPolicyService
    {
        //private readonly IBloqueioRepository _bloqueioRepository;

        //public EventoPolicyService(IBloqueioRepository bloqueioRepository)
        //{
        //    _bloqueioRepository = bloqueioRepository;
        //}
        

        public async Task<bool> PodeParticipar(Usuario usuario, Evento evento)
        {
            if (evento.Participantes.Any(p => p.Id == usuario.Id))
                return false;

            if (evento.Participantes.Count >= 50)
                return false;

            //foreach (var participante in evento.Participantes)
            //{
            //    var bloqueado = await _bloqueioRepository.ExisteBloqueio(participante.Id, usuario.Id);
            //    if (bloqueado)
            //        return false;
            //}

            return true;
        }
    }

}
