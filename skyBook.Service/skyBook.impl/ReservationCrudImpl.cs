using NLog;
using skyBook.database;
using skyBook.database.Internal;
using skyBook.Entiti;
using skyBook.@interface;
using System;
using System.Collections.Generic;

namespace skyBook.impl
{
    public class ReservationCrudImpl : IReservationCrud
    {
        private readonly IdataProvider provider;
        private readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ReservationCrudImpl()
        {
            DatabaseInitializer.InitializeDatabase();
            provider = new dataProvider();
        }
        public Reservation createReservation(int idUser, List<Ticket> tickets)
        {
            try
            {
                this.logger.Info($"start query createReservation with user : {idUser}");
                long reservationId = provider.CreateReservation(idUser, tickets);
                var reservation = new Reservation
                {
                    IdReservation = (int)reservationId,
                    IdUser = idUser,
                    Tickets = tickets
                };

                provider.UpdateReservation(reservation.IdReservation, tickets);
                this.logger.Info($"succesfull creation of reservation  idReservation: {reservation.IdReservation}");
                return reservation;

            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in creation of reservation with iduser :{idUser} ERROR : {ex}");
                throw;
            }

        }

        public bool deletReservation(int idReservation)
        {
            try
            {
                this.logger.Info($"start query deletReservation with id : {idReservation}");
                provider.DeleteReservation(idReservation);
                this.logger.Info($"succesfull delete reservation  with id: {idReservation}");
                return true;

            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in delete reservation with id :{idReservation} ERROR : {ex}");
                return false;
            }

        }

        public FligthDetail getFlight(int idFligth)
        {
            try
            {
                this.logger.Info($"start query getFlight with id {idFligth} ");

                var response = provider.GetFlightById(idFligth);
                this.logger.Info($"succesfull  finding flight  with id: {idFligth}");
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in finding flight with id {idFligth} ERROR : {ex}");
                throw;
            }
        }

        public List<Fligth> getFlights()
        {
            try
            {
                this.logger.Info($"start query getFlights ");

                return provider.GetAllFlights();

            }
            catch (Exception ex)
            {
                this.logger.Error($"Error in finding flights ERROR : {ex}");
                throw;
            }

        }

        public List<Reservation> getReservation(int idUser)
        {
            try
            {
                this.logger.Info($"start query getReservation with iduser : {idUser}");
                var response = provider.GetReservations(idUser);
                this.logger.Info($"succesfull finding reservations  with iduser: {idUser}");
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error finding reservations with iduser :{idUser} ERROR : {ex}");
                throw;
            }

        }

        public Reservation updateReservation(int idReservation, List<Ticket> tickets)
        {
            try
            {
                this.logger.Info($"start query updateReservation with idReservation : {idReservation}");
                provider.UpdateReservation(idReservation, tickets);
                var response = new Reservation { IdReservation = idReservation, Tickets = tickets };
                this.logger.Info($"succesfull update reservation with idReservation: {idReservation}");
                return response;
            }
            catch (Exception ex)
            {
                this.logger.Error($"Error update reservation with idReservation :{idReservation} ERROR : {ex}");
                throw;
            }
        }
    }
}
