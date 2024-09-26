using NLog;
using ReservationCrudService;
using skyBook.Entiti;
using skyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Impl
{
    public class CrudReservationsImpl : ICrudReservations
    {

        private readonly IReservationCrud reservationCrud;
        private readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public CrudReservationsImpl() {
            reservationCrud = new ReservationCrudClient();
        }

        public CrudReservationsImpl(IReservationCrud reservationCrud_)
        {
            reservationCrud = reservationCrud_;
        }

        public object CreateReservation(RequestcreateReservation request)
        {
            try {
                if (request.Tickets != null)
                {
                    var response = reservationCrud.createReservation(new createReservationRequest() { idUser = request.IdUser, tickets = request.Tickets.ToArray() }).createReservationResult;
                    return response;
                }
                else {
                    throw new NullReferenceException();
                }
               
            }
            catch (Exception ex) {
                this.logger.Error($"Error in CrudReservationsImpl function CreateReservation ERROR: {ex}");
                throw;
            }
           
        }

        public object DeletReservation(int idReservation)
        {
            try
            {
                var response = reservationCrud.deletReservation(new deletReservationRequest() { idReservation = idReservation}).deletReservationResult;
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in CrudReservationsImpl function DeletReservation ERROR: {ex}");
                throw;
            }
        }

        public object GetFlight(int idFligth)
        {
            try
            {
                var response = reservationCrud.getFlight(new getFlightRequest() { idFligth = idFligth }).getFlightResult;
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in CrudReservationsImpl function GetFlight ERROR: {ex}");
                throw;
            }
        }

        public object GetFlights()
        {
            try
            {
                var response = reservationCrud.getFlights(new getFlightsRequest()).getFlightsResult;
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in CrudReservationsImpl function GetFlights ERROR: {ex}");
                throw;
            }
        }

        public object GetReservations(int idUser)
        {
            try
            {
                var response = reservationCrud.getReservation(new getReservationRequest() { idUser = idUser}).getReservationResult;
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in CrudReservationsImpl function GetReservation ERROR: {ex}");
                throw;
            }
        }

        public object UpdateReservation(RequestUpdateReservation request)
        {
            try
            {
                if (request.Tickets != null)
                {
                    var response = reservationCrud.updateReservation(new updateReservationRequest() { idReservation = request.IdReservation, tickets = request.Tickets.ToArray() }).updateReservationResult;
                    return response;
                }
                else {

                    throw new NullReferenceException();
                }
                
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in CrudReservationsImpl function UpdateReservation ERROR: {ex}");
                throw;
            }
        }
    }
}
