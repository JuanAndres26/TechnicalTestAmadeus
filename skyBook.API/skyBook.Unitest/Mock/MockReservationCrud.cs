using Moq;
using ReservationCrudService;
using skyBook.Unitest.Stubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagmentService;

namespace skyBook.Unitest.Mock
{
    public class MockReservationCrud
    {
        public Mock<IReservationCrud> moq { get; set; }

        public MockReservationCrud(string type)
        {
            moq = new Mock<IReservationCrud>();

            switch (type)
            {
                case "ReturnError":
                    RetunError();
                    break;
                case "FuntionReady":
                    RetunReady();
                    break;
                default:
                    break;
            }
        }

        private void RetunReady()
        {
            moq.Setup(x => x.createReservation(It.IsAny<createReservationRequest>())).Returns(CreateReservationResponseStub.Reservation);
            moq.Setup(x => x.deletReservation(It.IsAny<deletReservationRequest>())).Returns(DeletReservationResponseStub.response);
            moq.Setup(x => x.updateReservation(It.IsAny<updateReservationRequest>())).Returns(UpdateReservationResponseStub.Reservation);
            moq.Setup(x => x.getReservation(It.IsAny<getReservationRequest>())).Returns(GetReservationResponseStub.Reservations);
            moq.Setup(x => x.getFlights(It.IsAny<getFlightsRequest>())).Returns(GetFlightsResponseStub.Flights);
            moq.Setup(x => x.getFlight(It.IsAny<getFlightRequest>())).Returns(GetFlightResponseStub.FligthDetail);
        }

        private void RetunError()
        {
            moq.Setup(x => x.createReservation(It.IsAny<createReservationRequest>())).Throws(new Exception("No se encontraron datos"));
            moq.Setup(x => x.deletReservation(It.IsAny<deletReservationRequest>())).Throws(new Exception("No se encontraron datos"));
            moq.Setup(x => x.updateReservation(It.IsAny<updateReservationRequest>())).Throws(new Exception("No se encontraron datos"));
            moq.Setup(x => x.getReservation(It.IsAny<getReservationRequest>())).Throws(new Exception("No se encontraron datos"));
            moq.Setup(x => x.getFlights(It.IsAny<getFlightsRequest>())).Throws(new Exception("No se encontraron datos"));
            moq.Setup(x => x.getFlight(It.IsAny<getFlightRequest>())).Throws(new Exception("No se encontraron datos"));
        }
    }
}
